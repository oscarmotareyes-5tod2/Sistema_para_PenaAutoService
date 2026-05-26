# Sistema de Login - Peña Auto Service

## Descripción General
Se ha implementado un sistema de autenticación profesional para el Sistema de Peña Auto Service con soporte para roles y permisos específicos.

## Flujo de Autenticación

1. **Punto de Entrada**: El usuario inicia la aplicación y se muestra el formulario de login (FrmIngreso)
2. **Ingreso de Credenciales**: El usuario ingresa su usuario y contraseña
3. **Validación**: Las credenciales se validan contra la base de datos
4. **Sesión**: Se inicia la sesión del usuario autenticado
5. **Acceso**: Se abre FormPrincipal con los módulos disponibles según el rol

## Paleta de Colores

- **Fondo Principal**: Blanco (#FFFFFF)
- **Fondo Alternativo**: Gris muy claro (#F5F5F5)
- **Botones**: Azul (#2196F3)
- **Texto Principal**: Gris oscuro (#424242)
- **Bordes**: Gris claro

## Roles y Permisos

### 1. **Administrador** (ID: 1)
**Descripción**: Acceso completo al sistema. Puede gestionar usuarios, configuración y todos los módulos.

**Módulos Disponibles**:
- Dashboard
- Clientes
- Órdenes
- Vehículos
- Usuarios
- Reportes
- Configuración
- Perfil

**Acciones Permitidas**:
- Crear, editar, eliminar clientes
- Crear, editar, eliminar órdenes
- Crear, editar, eliminar vehículos
- Crear, editar, desactivar usuarios
- Acceso a configuración del sistema
- Ver todos los reportes

### 2. **Recepcionista** (ID: 2)
**Descripción**: Puede gestionar clientes, crear órdenes de trabajo y generar reportes.

**Módulos Disponibles**:
- Dashboard
- Clientes
- Órdenes
- Reportes
- Perfil

**Acciones Permitidas**:
- Crear cliente
- Editar clientes existentes
- Crear órdenes de trabajo
- Editar órdenes propias
- Ver reportes
- Editar su perfil

### 3. **Mecánico** (ID: 3)
**Descripción**: Puede ver órdenes asignadas, actualizar su estado y consultar información de vehículos.

**Módulos Disponibles**:
- Dashboard
- Órdenes
- Vehículos
- Perfil

**Acciones Permitidas**:
- Ver órdenes asignadas
- Actualizar estado de órdenes
- Ver información de vehículos
- Editar su perfil

## Clases Principales

### SesionUsuario
Clase estática que mantiene la información del usuario autenticado durante la sesión.

**Propiedades**:
- `UsuarioActual`: Objeto E_Usuarios del usuario logueado
- `NombreRol`: Nombre del rol del usuario
- `EstaAutenticado`: Indica si hay usuario autenticado
- `IdRolActual`: ID del rol actual

**Métodos**:
- `IniciarSesion(usuario, rol)`: Inicia sesión de un usuario
- `CerrarSesion()`: Cierra la sesión actual

### AutorizacionRoles
Clase estática que gestiona la autorización y permisos según el rol.

**Métodos principales**:
- `ObtenerNombreRol(idRol)`: Obtiene el nombre del rol
- `TieneAcceso(idRol, modulo)`: Verifica si puede acceder a un módulo
- `TieneAccesoAccion(idRol, accion)`: Verifica si puede realizar una acción
- `ObtenerModulosDisponibles(idRol)`: Obtiene lista de módulos para el rol
- `ObtenerDescripcionRol(idRol)`: Obtiene descripción del rol

### FrmIngreso
Formulario de autenticación del usuario.

**Características**:
- Validación de campos requeridos
- Autenticación contra base de datos
- Soporte para tecla Enter
- Checkbox "Recuérdame"
- Link "¿Olvidó su contraseña?"
- Mensajes de error y éxito

## Métodos Agregados a la Capa de Datos

### D_Usuarios
- `AutenticarUsuario(username, passwordHash)`: Autentica un usuario y retorna sus datos si son correctos
- `ObtenerRolUsuario(idRol)`: Obtiene la información del rol de un usuario

### N_Usuarios
- `AutenticarUsuario(username, passwordHash)`: Método de negocio para autenticación
- `ObtenerRolUsuario(idRol)`: Método de negocio para obtener rol

## Flujo de Autorización

Para verificar si un usuario tiene acceso a una funcionalidad, use:

```csharp
// Verificar acceso a módulo
if (AutorizacionRoles.TieneAcceso(SesionUsuario.IdRolActual, "Usuarios"))
{
	// Mostrar módulo de usuarios
}

// Verificar acceso a acción específica
if (AutorizacionRoles.TieneAccesoAccion(SesionUsuario.IdRolActual, "CrearOrden"))
{
	// Permitir crear orden
}

// Obtener módulos disponibles
List<string> modulos = AutorizacionRoles.ObtenerModulosDisponibles(SesionUsuario.IdRolActual);
```

## Seguridad

### Consideraciones Importantes:
1. **Contraseñas**: Asegúrese de que las contraseñas se almacenen hasheadas en la base de datos
2. **SQL Injection**: Se utilizan parámetros en todas las consultas
3. **Sesión**: La sesión se mantiene en memoria durante la ejecución de la aplicación
4. **Cierre de Sesión**: Implemente cierre de sesión en FormPrincipal al cerrar la aplicación

## Próximas Mejoras Recomendadas

1. Implementar recuperación de contraseña olvidada
2. Agregar funcionalidad "Recuérdame" (guardar usuario localmente)
3. Auditoría de intentos de login fallidos
4. Bloqueo temporal de cuenta tras múltiples intentos fallidos
5. Cambio de contraseña en primer login
6. Implementar logout del sistema
7. Validación de sesión en cada módulo
8. Encriptación adicional de datos sensibles

## Archivos Modificados/Creados

- ✅ `CapaPresentacion/FrmIngreso.cs` - Lógica de login
- ✅ `CapaPresentacion/FrmIngreso.Designer.cs` - Interfaz de login
- ✅ `CapaPresentacion/SesionUsuario.cs` - Gestión de sesión (NUEVO)
- ✅ `CapaPresentacion/AutorizacionRoles.cs` - Gestión de permisos (NUEVO)
- ✅ `CapaPresentacion/Program.cs` - Punto de entrada actualizado
- ✅ `CapaDatos/D_Usuarios.cs` - Métodos de autenticación
- ✅ `CapaNegocio/N_Usuarios.cs` - Métodos de negocio

## Compilación

El proyecto compila sin errores. Para probar:

1. Asegúrese de que los stored procedures existan en la base de datos:
   - `SP_AutenticarUsuario`
   - Otros stored procedures existentes

2. Ejecute la aplicación: `F5` en Visual Studio

3. Ingrese credenciales de un usuario existente en la base de datos

