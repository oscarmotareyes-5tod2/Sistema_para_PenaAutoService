# Guía de Uso del Sistema de Login y Autorización

## Resumen del Proyecto Actualizado

Se ha implementado un sistema completo de autenticación y autorización basado en roles para el Sistema de Peña Auto Service.

## Componentes Nuevos

### 1. **SesionUsuario.cs**
Clase estática que mantiene el estado del usuario autenticado.

```csharp
// Usar en cualquier parte del código para verificar autenticación
if (SesionUsuario.EstaAutenticado)
{
	string username = SesionUsuario.UsuarioActual.Username;
	int rolId = SesionUsuario.IdRolActual;
	string rolNombre = SesionUsuario.NombreRol;
}
```

### 2. **AutorizacionRoles.cs**
Clase estática para gestionar permisos por rol.

```csharp
// Verificar si el usuario actual puede acceder a un módulo
if (AutorizacionRoles.TieneAcceso(SesionUsuario.IdRolActual, "Usuarios"))
{
	// Mostrar módulo de usuarios
}

// Obtener descripción del rol
string descripcion = AutorizacionRoles.ObtenerDescripcionRol(SesionUsuario.IdRolActual);

// Obtener módulos disponibles para el rol
List<string> modulos = AutorizacionRoles.ObtenerModulosDisponibles(SesionUsuario.IdRolActual);
```

## Usuarios de Prueba (Credenciales por Defecto)

| Usuario | Contraseña | Rol | Módulos Disponibles |
|---------|-----------|-----|-------------------|
| admin | admin123 | Administrador | Todos (8 módulos) |
| recepcionista | recep123 | Recepcionista | Dashboard, Clientes, Órdenes, Reportes, Perfil |
| mecanico | mec123 | Mecánico | Dashboard, Órdenes, Vehículos, Perfil |

## Ejemplo: Controlar Visibilidad de Botones por Rol

```csharp
private void FormPrincipal_Load(object sender, EventArgs e)
{
	// Mostrar/ocultar botón de usuarios según rol
	if (AutorizacionRoles.TieneAcceso(SesionUsuario.IdRolActual, "Usuarios"))
	{
		btnUsuarios.Visible = true;
	}
	else
	{
		btnUsuarios.Visible = false;
	}

	// Mostrar/ocultar botón de configuración
	if (SesionUsuario.IdRolActual == AutorizacionRoles.ROL_ADMINISTRADOR)
	{
		btnConfiguracion.Visible = true;
	}
	else
	{
		btnConfiguracion.Visible = false;
	}

	// Mostrar información del usuario
	lblBienvenida.Text = $"Bienvenido {SesionUsuario.UsuarioActual.Username} ({SesionUsuario.NombreRol})";
}
```

## Ejemplo: Implementar Logout

```csharp
private void btnCerrarSesion_Click(object sender, EventArgs e)
{
	// Cerrar sesión
	SesionUsuario.CerrarSesion();

	// Cerrar formulario principal
	this.Close();

	// Mostrar login nuevamente (se abre automáticamente desde Program.cs)
	Application.Restart();
}
```

## Ejemplo: Verificar Acceso a Acciones Específicas

```csharp
private void btnCrearOrden_Click(object sender, EventArgs e)
{
	// Verificar si el usuario puede crear órdenes
	if (AutorizacionRoles.TieneAccesoAccion(SesionUsuario.IdRolActual, "CrearOrden"))
	{
		// Abrir formulario de nueva orden
		FrmNuevaOrden frm = new FrmNuevaOrden();
		frm.ShowDialog();
	}
	else
	{
		MessageBox.Show("No tiene permiso para crear órdenes de trabajo.", 
			"Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
	}
}
```

## Ejemplo: Personalizar Interfaz por Rol

```csharp
private void PersonalizarInterfazPorRol()
{
	int rolId = SesionUsuario.IdRolActual;

	switch (rolId)
	{
		case AutorizacionRoles.ROL_ADMINISTRADOR:
			btnUsuarios.Visible = true;
			btnConfiguracion.Visible = true;
			btnReportes.Visible = true;
			lblRol.Text = "Administrador";
			pnlAdministracion.Visible = true;
			break;

		case AutorizacionRoles.ROL_RECEPCIONISTA:
			btnUsuarios.Visible = false;
			btnConfiguracion.Visible = false;
			btnReportes.Visible = true;
			lblRol.Text = "Recepcionista";
			pnlAdministracion.Visible = false;
			break;

		case AutorizacionRoles.ROL_MECANICO:
			btnUsuarios.Visible = false;
			btnConfiguracion.Visible = false;
			btnReportes.Visible = false;
			lblRol.Text = "Mecánico";
			pnlAdministracion.Visible = false;
			break;
	}
}
```

## Mátrices de Permisos

### Acceso a Módulos

| Módulo | Administrador | Recepcionista | Mecánico |
|--------|:---:|:---:|:---:|
| Dashboard | ✓ | ✓ | ✓ |
| Clientes | ✓ | ✓ | ✗ |
| Órdenes | ✓ | ✓ | ✓ |
| Vehículos | ✓ | ✗ | ✓ |
| Usuarios | ✓ | ✗ | ✗ |
| Reportes | ✓ | ✓ | ✗ |
| Configuración | ✓ | ✗ | ✗ |
| Perfil | ✓ | ✓ | ✓ |

### Acceso a Acciones

| Acción | Administrador | Recepcionista | Mecánico |
|--------|:---:|:---:|:---:|
| CrearOrden | ✓ | ✓ | ✗ |
| EditarOrden | ✓ | ✓ | ✗ |
| ActualizarEstadoOrden | ✓ | ✗ | ✓ |
| ConsultarClientes | ✓ | ✓ | ✗ |
| VerReportes | ✓ | ✓ | ✗ |
| VerVehiculos | ✓ | ✗ | ✓ |
| EditarPerfil | ✓ | ✓ | ✓ |

## Mejoras Futuras Recomendadas

1. **Hasheo de Contraseñas**: Implementar BCrypt o similar
2. **Recuperación de Contraseña**: Sistema de tokens
3. **Auditoría**: Registro de todos los logins y acciones
4. **Bloqueo de Cuenta**: Tras múltiples intentos fallidos
5. **Sesión**: Validación en tiempo real de permisos
6. **Encriptación**: De datos sensibles en tránsito
7. **Logs**: Sistema de registros de errores

## Archivo de Base de Datos

Ejecute el archivo `INSTALACION_BASE_DATOS.sql` en SQL Server para:
- Crear el stored procedure de autenticación
- Crear las tablas si no existen
- Insertar roles por defecto
- Insertar usuarios de prueba

## Notas de Seguridad

⚠️ **IMPORTANTE PARA PRODUCCIÓN**:

1. **Contraseñas**: Las contraseñas de prueba ('admin123', 'recep123', 'mec123') son para desarrollo únicamente
2. **Hasheo**: Implemente hasheo BCrypt o similar antes de ir a producción
3. **HTTPS**: Use HTTPS si la aplicación está en red
4. **Validación**: Siempre valide en servidor, no confíe solo en cliente
5. **Sesión**: Implemente timeout de sesión
6. **Datos Sensibles**: No registre contraseñas en logs

