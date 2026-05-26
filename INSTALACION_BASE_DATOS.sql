-- ============================================================
-- Script SQL para crear Stored Procedure de Autenticación
-- Sistema de Peña Auto Service
-- ============================================================

-- Verificar si el stored procedure existe y eliminarlo
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'SP_AutenticarUsuario')
	DROP PROCEDURE SP_AutenticarUsuario
GO

-- Crear el stored procedure de autenticación
CREATE PROCEDURE SP_AutenticarUsuario
	@Username NVARCHAR(100),
	@PasswordHash NVARCHAR(MAX)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT 
		IdUsuario,
		Username,
		PasswordHash,
		Activo,
		IdRol
	FROM Usuarios
	WHERE Username = @Username 
	AND PasswordHash = @PasswordHash
	AND Activo = 1
END
GO

-- ============================================================
-- Script para agregar datos de prueba (OPCIONAL)
-- Descomente si desea agregar usuarios de prueba
-- ============================================================

-- Verificar si la tabla Usuarios existe
IF NOT EXISTS (SELECT * FROM sys.objects WHERE type = 'U' AND name = 'Usuarios')
BEGIN
	CREATE TABLE Usuarios (
		IdUsuario INT PRIMARY KEY IDENTITY(1,1),
		Username NVARCHAR(100) NOT NULL UNIQUE,
		PasswordHash NVARCHAR(MAX) NOT NULL,
		Activo INT DEFAULT 1,
		IdRol INT NOT NULL,
		FOREIGN KEY (IdRol) REFERENCES Roles(IdRol)
	)
END

-- Verificar si la tabla Roles existe
IF NOT EXISTS (SELECT * FROM sys.objects WHERE type = 'U' AND name = 'Roles')
BEGIN
	CREATE TABLE Roles (
		IdRol INT PRIMARY KEY,
		Nombre NVARCHAR(100) NOT NULL,
		Descripcion NVARCHAR(MAX)
	)
END

-- Insertar roles si no existen
IF NOT EXISTS (SELECT * FROM Roles WHERE IdRol = 1)
	INSERT INTO Roles (IdRol, Nombre, Descripcion) 
	VALUES (1, 'Administrador', 'Acceso completo al sistema')

IF NOT EXISTS (SELECT * FROM Roles WHERE IdRol = 2)
	INSERT INTO Roles (IdRol, Nombre, Descripcion) 
	VALUES (2, 'Recepcionista', 'Gestión de clientes y órdenes')

IF NOT EXISTS (SELECT * FROM Roles WHERE IdRol = 3)
	INSERT INTO Roles (IdRol, Nombre, Descripcion) 
	VALUES (3, 'Mecánico', 'Gestión de órdenes de trabajo asignadas')

-- Insertar usuarios de prueba (opcional)
-- IMPORTANTE: En producción, use contraseñas hasheadas segurizadas
-- Por ahora, es solo para demostración

IF NOT EXISTS (SELECT * FROM Usuarios WHERE Username = 'admin')
	INSERT INTO Usuarios (Username, PasswordHash, Activo, IdRol)
	VALUES ('admin', 'admin123', 1, 1)

IF NOT EXISTS (SELECT * FROM Usuarios WHERE Username = 'recepcionista')
	INSERT INTO Usuarios (Username, PasswordHash, Activo, IdRol)
	VALUES ('recepcionista', 'recep123', 1, 2)

IF NOT EXISTS (SELECT * FROM Usuarios WHERE Username = 'mecanico')
	INSERT INTO Usuarios (Username, PasswordHash, Activo, IdRol)
	VALUES ('mecanico', 'mec123', 1, 3)

-- ============================================================
-- Verificación: Ejecutar el SP para probar
-- ============================================================
-- EXEC SP_AutenticarUsuario @Username = 'admin', @PasswordHash = 'admin123'
-- EXEC SP_AutenticarUsuario @Username = 'recepcionista', @PasswordHash = 'recep123'
-- EXEC SP_AutenticarUsuario @Username = 'mecanico', @PasswordHash = 'mec123'
