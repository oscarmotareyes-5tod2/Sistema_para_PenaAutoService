-- =====================================================
-- VERIFICACIÓN RÁPIDA DE LA CONFIGURACIÓN
-- =====================================================

-- 1. Verificar que la base de datos existe
SELECT name FROM sys.databases WHERE name = 'PenaAutoServiceDB';
GO

-- 2. Verificar tablas
SELECT name FROM sys.tables WHERE database_id = DB_ID('PenaAutoServiceDB');
GO

-- 3. Estructura de tabla Usuarios
EXEC sp_columns 'Usuarios';
GO

-- 4. Estructura de tabla Roles
EXEC sp_columns 'Roles';
GO

-- 5. Verificar que el SP existe
SELECT name FROM sys.procedures WHERE name = 'sp_ListarUsuarios';
GO

-- 6. Ver contenido del SP
EXEC sp_helptext 'sp_ListarUsuarios';
GO

-- 7. Ejecutar el SP para ver si retorna datos
EXEC sp_ListarUsuarios;
GO

-- 8. Ver todos los datos de Usuarios
SELECT * FROM Usuarios;
GO

-- 9. Ver todos los datos de Roles
SELECT * FROM Roles;
GO

-- 10. Conteo de registros
SELECT 'Usuarios' as Tabla, COUNT(*) as Total FROM Usuarios
UNION ALL
SELECT 'Roles', COUNT(*) FROM Roles;
GO

-- =====================================================
-- Si NO hay datos, ejecutar esto para insertar:
-- =====================================================

-- Insertar roles si no existen
IF NOT EXISTS (SELECT 1 FROM Roles WHERE IdRol = 1)
BEGIN
	INSERT INTO Roles (NombreRol) VALUES ('Administrador');
	INSERT INTO Roles (NombreRol) VALUES ('Recepcionista');
	INSERT INTO Roles (NombreRol) VALUES ('Mecanico');
END
GO

-- Insertar usuarios de prueba si no existen
IF NOT EXISTS (SELECT 1 FROM Usuarios WHERE Username = 'admin1')
BEGIN
	INSERT INTO Usuarios (Username, PasswordHash, Activo, IdRol) VALUES ('admin1', '123', 1, 1);
	INSERT INTO Usuarios (Username, PasswordHash, Activo, IdRol) VALUES ('recep1', '123', 1, 2);
	INSERT INTO Usuarios (Username, PasswordHash, Activo, IdRol) VALUES ('meca1', '123', 1, 3);
END
GO

-- =====================================================
-- Verificar después de insertar
-- =====================================================

SELECT * FROM Usuarios;
SELECT * FROM Roles;
GO
