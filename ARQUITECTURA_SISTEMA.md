# ARQUITECTURA DEL SISTEMA DE LOGIN Y AUTORIZACIÓN

## 📐 Diagrama General del Flujo

```
┌─────────────────────────────────────────────────────────────────┐
│                      APLICACIÓN WINDOWS                         │
└─────────────────────────────────────────────────────────────────┘
								│
								▼
						┌───────────────┐
						│  Program.cs   │
						│  (Entrada)    │
						└───────────────┘
								│
								▼
						┌───────────────────┐
						│  FrmIngreso.cs    │
						│  (Login Screen)   │
						└───────────────────┘
								│
								▼
					┌─────────────────────────┐
					│  Validar Credenciales   │
					│  N_Usuarios.cs          │
					│  D_Usuarios.cs          │
					│  (Capa Negocio/Datos)   │
					└─────────────────────────┘
								│
					┌───────────┴───────────┐
					│                       │
					▼                       ▼
			✅ LOGIN EXITOSO        ❌ LOGIN FALLIDO
					│                       │
					▼                       ▼
		┌───────────────────┐    Mostrar Error
		│ SesionUsuario.cs  │    Limpiar Campos
		│ (Iniciar Sesión)  │    Reintentar
		└───────────────────┘
					│
					▼
		┌───────────────────────┐
		│ FormPrincipal.cs      │
		│ (Menu Principal)      │
		└───────────────────────┘
					│
					▼
		┌───────────────────────────────┐
		│ AutorizacionRoles.cs          │
		│ (Validar Permisos por Módulo) │
		└───────────────────────────────┘
					│
		┌───────────┼───────────┬───────────┐
		│           │           │           │
		▼           ▼           ▼           ▼
	┌───────┐  ┌────────┐  ┌────────┐  ┌────────┐
	│Admin? │  │Recep?  │  │Mec?    │  │Otros?  │
	└───────┘  └────────┘  └────────┘  └────────┘
		│           │           │           │
		▼           ▼           ▼           ▼
	┌───────────┐  ┌───────────┐  ┌───────────┐
	│ Todos los │  │ Solo      │  │ Solo      │
	│ Módulos   │  │ Permitidos│  │ Permitidos│
	└───────────┘  └───────────┘  └───────────┘
```

## 🏗️ Arquitectura de Capas

```
┌──────────────────────────────────────────────────────────┐
│            CAPA DE PRESENTACIÓN (UI)                     │
├──────────────────────────────────────────────────────────┤
│                                                          │
│  ┌─────────────┐  ┌──────────────┐  ┌──────────────┐  │
│  │ FrmIngreso  │  │ FormPrincipal│  │ Otros Forms  │  │
│  │ (Login)     │  │ (Menú)       │  │              │  │
│  └─────────────┘  └──────────────┘  └──────────────┘  │
│                                                          │
│  ┌──────────────────────────────────────────────────┐   │
│  │ SesionUsuario.cs (Sesión del Usuario)           │   │
│  │ AutorizacionRoles.cs (Control de Acceso)        │   │
│  └──────────────────────────────────────────────────┘   │
│                                                          │
└──────────────────────────────────────────────────────────┘
			  △
			  │
			  │
┌──────────────────────────────────────────────────────────┐
│            CAPA DE NEGOCIO                              │
├──────────────────────────────────────────────────────────┤
│                                                          │
│  ┌──────────────────────────────────────────────────┐   │
│  │ N_Usuarios.cs                                   │   │
│  │ - AutenticarUsuario()                           │   │
│  │ - ObtenerRolUsuario()                           │   │
│  │ - ListarUsuarios()                              │   │
│  │ - ActualizarUsuario()                           │   │
│  └──────────────────────────────────────────────────┘   │
│                                                          │
│  ┌──────────────────────────────────────────────────┐   │
│  │ N_Roles.cs                                      │   │
│  │ - ListarRoles()                                 │   │
│  └──────────────────────────────────────────────────┘   │
│                                                          │
└──────────────────────────────────────────────────────────┘
			  △
			  │
			  │
┌──────────────────────────────────────────────────────────┐
│            CAPA DE DATOS (Acceso BD)                    │
├──────────────────────────────────────────────────────────┤
│                                                          │
│  ┌──────────────────────────────────────────────────┐   │
│  │ D_Usuarios.cs                                   │   │
│  │ - AutenticarUsuario()         [NEW]             │   │
│  │ - ObtenerRolUsuario()         [NEW]             │   │
│  │ - ListarUsuarios()                              │   │
│  │ - InsertarUsuario()                             │   │
│  │ - ActualizarUsuario()                           │   │
│  │ - DesactivarUsuario()                           │   │
│  └──────────────────────────────────────────────────┘   │
│                                                          │
│  ┌──────────────────────────────────────────────────┐   │
│  │ D_Roles.cs                                      │   │
│  │ - ListarRoles()                                 │   │
│  └──────────────────────────────────────────────────┘   │
│                                                          │
│  ┌──────────────────────────────────────────────────┐   │
│  │ Conexion.cs                                     │   │
│  │ - ObtenerConexion()                             │   │
│  └──────────────────────────────────────────────────┘   │
│                                                          │
└──────────────────────────────────────────────────────────┘
			  △
			  │
			  │
┌──────────────────────────────────────────────────────────┐
│            CAPA DE ENTIDADES                            │
├──────────────────────────────────────────────────────────┤
│                                                          │
│  ┌──────────────────────────────────────────────────┐   │
│  │ E_Usuarios.cs                                   │   │
│  │ - IdUsuario                                     │   │
│  │ - Username                                      │   │
│  │ - PasswordHash                                  │   │
│  │ - Activo                                        │   │
│  │ - IdRol                                         │   │
│  └──────────────────────────────────────────────────┘   │
│                                                          │
└──────────────────────────────────────────────────────────┘
			  △
			  │
			  │
┌──────────────────────────────────────────────────────────┐
│                   BASE DE DATOS SQL                     │
├──────────────────────────────────────────────────────────┤
│                                                          │
│  ┌──────────────────────────────────────────────────┐   │
│  │ Tabla: Usuarios                                 │   │
│  │ - IdUsuario (PK)                                │   │
│  │ - Username (UNIQUE)                             │   │
│  │ - PasswordHash                                  │   │
│  │ - Activo                                        │   │
│  │ - IdRol (FK)                                    │   │
│  └──────────────────────────────────────────────────┘   │
│                                                          │
│  ┌──────────────────────────────────────────────────┐   │
│  │ Tabla: Roles                                    │   │
│  │ - IdRol (PK)                                    │   │
│  │ - Nombre                                        │   │
│  │ - Descripcion                                   │   │
│  └──────────────────────────────────────────────────┘   │
│                                                          │
│  ┌──────────────────────────────────────────────────┐   │
│  │ SP: SP_AutenticarUsuario    [NEW]               │   │
│  │ SP: Otros SPs existentes                        │   │
│  └──────────────────────────────────────────────────┘   │
│                                                          │
└──────────────────────────────────────────────────────────┘
```

## 🔄 Flujo de Autenticación Detallado

```
1. Usuario inicia aplicación
   │
   ├─► Program.cs carga FrmIngreso
   │
2. Usuario ingresa credenciales
   │
   ├─► txtUsuario: "admin"
   ├─► txtPassword: "admin123"
   │
3. Usuario hace clic en "Ingresar"
   │
   ├─► btnIngresar_Click(sender, e)
   │   │
   │   ├─► Validar campos no vacíos
   │   │   ├─ Si vacío ─► Mostrar error y terminar
   │   │   └─ Si OK ─► Continuar
   │   │
   │   ├─► N_Usuarios.AutenticarUsuario(usuario, contraseña)
   │   │   │
   │   │   ├─► D_Usuarios.AutenticarUsuario(usuario, contraseña)
   │   │   │   │
   │   │   │   ├─► Ejecutar SP_AutenticarUsuario
   │   │   │   │   │
   │   │   │   │   ├─ Si encuentra usuario ─► Retornar E_Usuarios
   │   │   │   │   └─ Si NO encuentra ─► Retornar null
   │   │   │   │
   │   │   │   └─► Retornar E_Usuarios o null
   │   │   │
   │   │   └─► Retornar E_Usuarios o null
   │   │
   │   ├─► ¿usuarioAutenticado != null?
   │   │   │
   │   │   ├─ NO
   │   │   │   ├─► Mostrar "Usuario o contraseña incorrectos"
   │   │   │   └─► Limpiar txtPassword y establecer foco
   │   │   │
   │   │   └─ SÍ
   │   │       │
   │   │       ├─► ¿usuarioAutenticado.Activo == 0?
   │   │       │   │
   │   │       │   ├─ SÍ
   │   │       │   │   └─► Mostrar "Usuario inactivo"
   │   │       │   │
   │   │       │   └─ NO
   │   │       │       │
   │   │       │       ├─► Obtener nombre rol
   │   │       │       │   nombreRol = AutorizacionRoles.ObtenerNombreRol(IdRol)
   │   │       │       │
   │   │       │       ├─► SesionUsuario.IniciarSesion(usuario, rol)
   │   │       │       │   ├─ UsuarioActual = usuario
   │   │       │       │   └─ NombreRol = rol
   │   │       │       │
   │   │       │       ├─► Mostrar mensaje "Bienvenido"
   │   │       │       │
   │   │       │       ├─► AbrirFormularioPrincipal()
   │   │       │       │   └─► new FormPrincipal().Show()
   │   │       │       │
   │   │       │       └─► this.Close() (cerrar FrmIngreso)
   │   │       │
   │   │       └─ FIN

4. FormPrincipal se abre
   │
   ├─► FormPrincipal_Load(sender, e)
   │   │
   │   ├─► Validar SesionUsuario.EstaAutenticado
   │   │   ├─ NO ─► Cerrar FormPrincipal
   │   │   └─ SÍ ─► Continuar
   │   │
   │   ├─► Mostrar información del usuario
   │   │   lblBienvenida = "Bienvenido: admin"
   │   │
   │   ├─► ConfigurarInterfazPorRol()
   │   │   │
   │   │   ├─► Obtener IdRolActual = SesionUsuario.IdRolActual
   │   │   │
   │   │   ├─ Si IdRol == ADMINISTRADOR
   │   │   │   ├─ btnUsuarios.Visible = true
   │   │   │   ├─ btnConfiguracion.Visible = true
   │   │   │   └─ (Mostrar todos los botones)
   │   │   │
   │   │   ├─ Si IdRol == RECEPCIONISTA
   │   │   │   ├─ btnUsuarios.Visible = false
   │   │   │   ├─ btnConfiguracion.Visible = false
   │   │   │   └─ (Mostrar solo módulos permitidos)
   │   │   │
   │   │   └─ Si IdRol == MECANICO
   │   │       ├─ btnVehiculos.Visible = true
   │   │       ├─ btnUsuarios.Visible = false
   │   │       └─ (Mostrar solo módulos permitidos)
   │   │
   │   └─► Aplicación lista para usar

5. Usuario interactúa con módulos
   │
   ├─► Al hacer clic en cualquier botón
   │   │
   │   └─► Validar AutorizacionRoles.TieneAcceso(IdRol, modulo)
   │       ├─ NO ─► Mostrar "Acceso denegado"
   │       └─ SÍ ─► Abrir módulo
   │
   └─► FIN
```

## 📊 Matriz de Estados

```
┌─────────────────┬─────────────────────────────────┐
│ ESTADO          │ DESCRIPCIÓN                     │
├─────────────────┼─────────────────────────────────┤
│ NO AUTENTICADO  │ Muestra FrmIngreso              │
│ EN LOGIN        │ Validando credenciales          │
│ AUTENTICADO     │ Sesión activa, FormPrincipal   │
│ SESION EXPIRADA │ Debe volver a login             │
│ LOGOUT          │ Sesión cerrada                  │
└─────────────────┴─────────────────────────────────┘
```

## 🔐 Matriz de Permisos por Rol

```
┌──────────────────────┬────────┬────────┬────────┐
│ MODULO/ACCION        │ ADMIN  │ RECEP  │ MECA   │
├──────────────────────┼────────┼────────┼────────┤
│ Dashboard            │   ✓    │   ✓    │   ✓    │
│ Clientes             │   ✓    │   ✓    │   ✗    │
│ Órdenes              │   ✓    │   ✓    │   ✓    │
│ Vehículos            │   ✓    │   ✗    │   ✓    │
│ Usuarios             │   ✓    │   ✗    │   ✗    │
│ Reportes             │   ✓    │   ✓    │   ✗    │
│ Configuración        │   ✓    │   ✗    │   ✗    │
│ Perfil               │   ✓    │   ✓    │   ✓    │
├──────────────────────┼────────┼────────┼────────┤
│ CrearOrden           │   ✓    │   ✓    │   ✗    │
│ EditarOrden          │   ✓    │   ✓    │   ✗    │
│ ActualizarEstado     │   ✓    │   ✗    │   ✓    │
│ EliminarUsuario      │   ✓    │   ✗    │   ✗    │
│ CrearCliente         │   ✓    │   ✓    │   ✗    │
│ EditarCliente        │   ✓    │   ✓    │   ✗    │
└──────────────────────┴────────┴────────┴────────┘
```

## 🎨 Paleta de Colores

```
┌─────────────────┬──────────┬────────────────────┐
│ ELEMENTO        │ COLOR    │ CÓDIGO HEX         │
├─────────────────┼──────────┼────────────────────┤
│ Fondo Principal │ Blanco   │ #FFFFFF            │
│ Fondo Secundrio │ Gris     │ #F5F5F5            │
│ Botones         │ Azul     │ #2196F3            │
│ Texto Principal │ Gris     │ #424242            │
│ Bordes          │ Gris Clr │ #BDBDBD            │
│ Error           │ Rojo     │ #F44336            │
│ Éxito           │ Verde    │ #4CAF50            │
│ Advertencia     │ Naranja  │ #FF9800            │
└─────────────────┴──────────┴────────────────────┘
```

---

**Arquitectura Completa del Sistema de Login y Autorización**
**Estado: Implementado y Compilado Exitosamente**

