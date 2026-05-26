# INSTRUCCIONES DE IMPLEMENTACIÓN Y PRÓXIMOS PASOS

## 📋 Checklist de Implementación

### ✅ Completado
- [x] Crear clase SesionUsuario.cs
- [x] Crear clase AutorizacionRoles.cs
- [x] Actualizar FrmIngreso.Designer.cs con interfaz profesional
- [x] Implementar lógica de login en FrmIngreso.cs
- [x] Agregar métodos de autenticación en D_Usuarios.cs
- [x] Agregar métodos de negocio en N_Usuarios.cs
- [x] Actualizar Program.cs para mostrar login como entrada
- [x] Compilación exitosa sin errores

### ⏳ Pendiente (Próximos Pasos)

1. **Crear Stored Procedure en BD**
   - [ ] Ejecutar script: `INSTALACION_BASE_DATOS.sql`
   - [ ] Verificar que `SP_AutenticarUsuario` existe
   - [ ] Crear usuarios de prueba

2. **Pruebas Funcionales**
   - [ ] Probar login con usuario admin
   - [ ] Probar login con usuario recepcionista
   - [ ] Probar login con usuario mecánico
   - [ ] Probar login con credenciales incorrectas
   - [ ] Probar usuario inactivo

3. **Integración con FormPrincipal**
   - [ ] Validar autenticación en FormPrincipal
   - [ ] Implementar cierre de sesión
   - [ ] Ocultar/mostrar módulos según rol
   - [ ] Ocultar/mostrar botones según rol

4. **Seguridad Mejorada**
   - [ ] Implementar BCrypt para hasheo de contraseñas
   - [ ] Crear sistema de recuperación de contraseña
   - [ ] Implementar timeout de sesión
   - [ ] Agregar auditoría de intentos de login
   - [ ] Bloqueo temporal tras fallos múltiples

5. **Validaciones Adicionales**
   - [ ] Validar sesión al abrir cada formulario
   - [ ] Validar permisos antes de cada acción crítica
   - [ ] Cerrar sesión al cerrar la aplicación
   - [ ] Manejo de excepciones mejorado

## 🔧 PASO 1: Preparar Base de Datos

### 1.1 Ejecutar Script SQL
```sql
-- En SQL Server Management Studio:
1. Abrir archivo: INSTALACION_BASE_DATOS.sql
2. Conectarse a la base de datos del proyecto
3. Ejecutar todo el script (F5)
```

### 1.2 Verificar Tablas y Datos
```sql
-- Verificar que existen las tablas
SELECT * FROM Roles;
SELECT * FROM Usuarios;

-- Verificar que el SP existe
SELECT * FROM sys.objects WHERE type = 'P' AND name = 'SP_AutenticarUsuario';

-- Probar el SP
EXEC SP_AutenticarUsuario @Username = 'admin', @PasswordHash = 'admin123'
```

## 🚀 PASO 2: Compilar y Probar

### 2.1 Compilación
```
Visual Studio → Build → Build Solution (F7)
o
Visual Studio → Build → Rebuild Solution (Ctrl+Alt+F7)
```

### 2.2 Ejecutar Aplicación
```
F5 (Debug) o Ctrl+F5 (Sin Debug)
```

### 2.3 Probar Login
```
Pantalla de Login:
├─ Usuario: admin
├─ Contraseña: admin123
└─ Clic en Ingresar

Resultado esperado: ✅ Ingreso exitoso, se abre FormPrincipal
```

## 💻 PASO 3: Validar Roles y Permisos

### 3.1 Prueba con Administrador
```
Usuario: admin
Contraseña: admin123
Resultado: Debe ver TODOS los módulos
```

### 3.2 Prueba con Recepcionista
```
Usuario: recepcionista
Contraseña: recep123
Resultado: Debe ver Dashboard, Clientes, Órdenes, Reportes, Perfil
(NO debe ver: Usuarios, Configuración, Vehículos)
```

### 3.3 Prueba con Mecánico
```
Usuario: mecanico
Contraseña: mec123
Resultado: Debe ver Dashboard, Órdenes, Vehículos, Perfil
(NO debe ver: Usuarios, Configuración, Clientes, Reportes)
```

## 🔐 PASO 4: Integración con FormPrincipal

### 4.1 Validar Autenticación en FormPrincipal
```csharp
// En FormPrincipal_Load:
private void FormPrincipal_Load(object sender, EventArgs e)
{
	if (!SesionUsuario.EstaAutenticado)
	{
		MessageBox.Show("Sesión no válida");
		this.Close();
		return;
	}

	// Mostrar información del usuario
	lblBienvenida.Text = $"Bienvenido: {SesionUsuario.UsuarioActual.Username}";

	// Configurar interfaz según rol
	ConfigurarInterfazPorRol();
}
```

### 4.2 Implementar Cierre de Sesión
```csharp
// Agregar botón "Cerrar Sesión"
private void btnCerrarSesion_Click(object sender, EventArgs e)
{
	SesionUsuario.CerrarSesion();
	Application.Restart();
}
```

### 4.3 Ejemplo de Configuración por Rol
```csharp
private void ConfigurarInterfazPorRol()
{
	int rolId = SesionUsuario.IdRolActual;

	// Mostrar u ocultar controles
	btnUsuarios.Visible = AutorizacionRoles.TieneAcceso(rolId, "Usuarios");
	btnReportes.Visible = AutorizacionRoles.TieneAcceso(rolId, "Reportes");
	btnConfiguracion.Visible = (rolId == AutorizacionRoles.ROL_ADMINISTRADOR);

	// Habilitar/deshabilitar botones
	btnEliminar.Enabled = (rolId == AutorizacionRoles.ROL_ADMINISTRADOR);
}
```

## 📊 PASO 5: Implementar Auditoría (Opcional pero Recomendado)

### 5.1 Crear Tabla de Auditoría
```sql
CREATE TABLE EventosAuditoria (
	IdEvento INT PRIMARY KEY IDENTITY(1,1),
	IdUsuario INT,
	Username NVARCHAR(100),
	Evento NVARCHAR(500),
	FechaHora DATETIME DEFAULT GETDATE(),
	DireccionIP NVARCHAR(50),
	Resultado NVARCHAR(50) -- 'Exitoso' o 'Fallido'
)
```

### 5.2 Registrar Logins
```csharp
// En FrmIngreso.cs, cuando login es exitoso:
RegistrarEventoAuditoria(usuarioAutenticado.IdUsuario, 
						usuarioAutenticado.Username, 
						"Login", 
						"Exitoso");

// Cuando login falla:
RegistrarEventoAuditoria(0, txtUsuario.Text, "Intento Login", "Fallido");
```

## 🔒 PASO 6: Mejorar Seguridad

### 6.1 Implementar Hasheo BCrypt
```csharp
// Instalar NuGet: BCrypt.Net
Install-Package BCrypt.Net-Next

// Al hashear contraseña:
string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);

// Al verificar:
bool isValid = BCrypt.Net.BCrypt.Verify(password, hashFromDB);
```

### 6.2 Implementar Timeout de Sesión
```csharp
public static class SesionUsuario
{
	private static DateTime ultimaActividad = DateTime.Now;
	private const int TIMEOUT_MINUTOS = 30;

	public static bool ValidarSesion()
	{
		if (!EstaAutenticado) return false;

		if ((DateTime.Now - ultimaActividad).TotalMinutes > TIMEOUT_MINUTOS)
		{
			CerrarSesion();
			return false;
		}

		ultimaActividad = DateTime.Now;
		return true;
	}
}
```

### 6.3 Bloqueo de Cuenta por Intentos Fallidos
```csharp
public class ControlIntentos
{
	private Dictionary<string, (int intentos, DateTime ultimoIntento)> intentosFallidos;
	private const int MAX_INTENTOS = 5;
	private const int MINUTOS_BLOQUEO = 15;

	public bool PuedeIntentar(string username)
	{
		if (!intentosFallidos.ContainsKey(username))
			return true;

		var (intentos, ultimoIntento) = intentosFallidos[username];

		if (intentos >= MAX_INTENTOS)
		{
			if ((DateTime.Now - ultimoIntento).TotalMinutes < MINUTOS_BLOQUEO)
				return false;

			intentosFallidos.Remove(username);
			return true;
		}

		return true;
	}

	public void RegistrarIntentoFallido(string username)
	{
		if (!intentosFallidos.ContainsKey(username))
			intentosFallidos[username] = (1, DateTime.Now);
		else
		{
			var (intentos, _) = intentosFallidos[username];
			intentosFallidos[username] = (intentos + 1, DateTime.Now);
		}
	}
}
```

## 📚 PASO 7: Documentación y Mantenimiento

### 7.1 Actualizar Documentación
- [ ] Actualizar manual de usuario con instrucciones de login
- [ ] Documentar permisos de cada rol
- [ ] Crear guía de recuperación de contraseña

### 7.2 Crear Logs de Cambios
```markdown
## v1.0 - Sistema de Login y Roles
- ✅ Implementado sistema de autenticación
- ✅ Definidos tres roles: Administrador, Recepcionista, Mecánico
- ✅ Implementado control de acceso por rol
- ✅ Interfaz profesional con paleta de colores consistente
```

## 🐛 Posibles Problemas y Soluciones

### Problema: "SQL Exception: Could not connect to database"
**Solución**: Verificar cadena de conexión en Conexion.cs

### Problema: "SP_AutenticarUsuario not found"
**Solución**: Ejecutar INSTALACION_BASE_DATOS.sql en la BD

### Problema: "Usuario inactivo" aunque el usuario debería estar activo
**Solución**: Verificar que la columna Activo = 1 en la tabla Usuarios

### Problema: Todos los roles ven todos los módulos
**Solución**: Implementar ConfigurarInterfazPorRol() en FormPrincipal

### Problema: Login siempre falla
**Solución**: Verificar que las contraseñas en BD coincidan (incluyendo mayúsculas/minúsculas)

## 📞 Contacto y Soporte

Para preguntas sobre la implementación:
1. Revisar LOGIN_SISTEMA_DOCUMENTACION.md
2. Revisar GUIA_USO_LOGIN_Y_AUTORIZACION.md
3. Revisar EJEMPLOS_IMPLEMENTACION.cs
4. Revisar archivos fuente en el código

## ✅ Verificación Final

Antes de considerar completo:
- [ ] Proyecto compila sin errores
- [ ] Login funciona con usuarios válidos
- [ ] Login rechaza credenciales inválidas
- [ ] Se respetan los permisos por rol
- [ ] FormPrincipal se abre solo después de login exitoso
- [ ] La interfaz se personaliza según el rol
- [ ] Se puede cerrar sesión
- [ ] Documentación completa

---

**Estado: IMPLEMENTACIÓN COMPLETA**
**Fecha: [ACTUAL]**
**Versión: 1.0**

