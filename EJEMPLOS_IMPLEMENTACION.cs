// ============================================================================
// EJEMPLOS DE IMPLEMENTACIÓN: Sistema de Login y Autorización
// ============================================================================

// ============================================================================
// EJEMPLO 1: Controlar Visibilidad de Menú por Rol
// ============================================================================

public partial class FormPrincipal : Form
{
    private void FormPrincipal_Load(object sender, EventArgs e)
    {
        // Verificar si el usuario está autenticado
        if (!SesionUsuario.EstaAutenticado)
        {
            MessageBox.Show("Debe iniciar sesión primero");
            this.Close();
            return;
        }

        // Mostrar bienvenida
        lblBienvenida.Text = $"Bienvenido {SesionUsuario.UsuarioActual.Username} - {SesionUsuario.NombreRol}";

        // Configurar visibilidad de botones según rol
        ConfigurarMenuPorRol();
    }

    private void ConfigurarMenuPorRol()
    {
        int rolId = SesionUsuario.IdRolActual;

        // Módulo de Usuarios - Solo Administrador
        btnUsuarios.Visible = AutorizacionRoles.TieneAcceso(rolId, "Usuarios");

        // Módulo de Configuración - Solo Administrador
        btnConfiguracion.Visible = (rolId == AutorizacionRoles.ROL_ADMINISTRADOR);

        // Módulo de Reportes - Admin y Recepcionista
        btnReportes.Visible = AutorizacionRoles.TieneAcceso(rolId, "Reportes");

        // Módulo de Órdenes - Todos
        btnOrdenes.Visible = AutorizacionRoles.TieneAcceso(rolId, "Ordenes");

        // Módulo de Clientes - Admin y Recepcionista
        btnClientes.Visible = AutorizacionRoles.TieneAcceso(rolId, "Clientes");

        // Módulo de Vehículos - Admin y Mecánico
        btnVehiculos.Visible = AutorizacionRoles.TieneAcceso(rolId, "Vehiculos");

        // Dashboard - Todos
        btnDashboard.Visible = AutorizacionRoles.TieneAcceso(rolId, "Dashboard");
    }
}

// ============================================================================
// EJEMPLO 2: Validar Acceso a Funcionalidad Específica
// ============================================================================

public void CrearNuevaOrden()
{
    // Verificar permisos específicos
    if (!AutorizacionRoles.TieneAccesoAccion(SesionUsuario.IdRolActual, "CrearOrden"))
    {
        MessageBox.Show(
            "No tiene permiso para crear órdenes de trabajo. Solo Administradores y Recepcionistas pueden crear órdenes.",
            "Acceso Denegado",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning
        );
        return;
    }

    // Si tiene acceso, abrir formulario
    FrmNuevaOrden frmNuevaOrden = new FrmNuevaOrden();
    frmNuevaOrden.ShowDialog();
}

// ============================================================================
// EJEMPLO 3: Personalizar Interfaz Completa por Rol
// ============================================================================

private void PersonalizarInterfazPorRol()
{
    int rolId = SesionUsuario.IdRolActual;

    switch (rolId)
    {
        case AutorizacionRoles.ROL_ADMINISTRADOR:
            PersonalizarParaAdministrador();
            break;

        case AutorizacionRoles.ROL_RECEPCIONISTA:
            PersonalizarParaRecepcionista();
            break;

        case AutorizacionRoles.ROL_MECANICO:
            PersonalizarParaMecanico();
            break;
    }
}

private void PersonalizarParaAdministrador()
{
    // Mostrar todos los módulos
    panelMenuPrincipal.Visible = true;
    panelMenuAdministracion.Visible = true;

    // Permitir todas las acciones
    btnEliminar.Enabled = true;
    btnEditar.Enabled = true;
    btnCrear.Enabled = true;

    // Mostrar información adicional
    lblNivel.Text = "Nivel de Acceso: TOTAL";
    lblNivel.ForeColor = Color.Green;
}

private void PersonalizarParaRecepcionista()
{
    // Mostrar solo módulos permitidos
    panelMenuPrincipal.Visible = true;
    panelMenuAdministracion.Visible = false;

    // Restringir acciones
    btnEliminar.Enabled = false;
    btnEditar.Enabled = true;
    btnCrear.Enabled = true;

    lblNivel.Text = "Nivel de Acceso: LIMITADO";
    lblNivel.ForeColor = Color.Orange;
}

private void PersonalizarParaMecanico()
{
    // Mostrar solo módulos permitidos
    panelMenuPrincipal.Visible = true;
    panelMenuAdministracion.Visible = false;

    // Solo lectura y actualización de estado
    btnEliminar.Enabled = false;
    btnEditar.Enabled = false;
    btnActualizarEstado.Enabled = true;

    lblNivel.Text = "Nivel de Acceso: LECTURA Y ACTUALIZACIÓN";
    lblNivel.ForeColor = Color.Blue;
}

// ============================================================================
// EJEMPLO 4: Implementar Cierre de Sesión
// ============================================================================

private void CerrarSesion()
{
    // Confirmar cierre de sesión
    DialogResult resultado = MessageBox.Show(
        "¿Está seguro que desea cerrar sesión?",
        "Confirmar Cierre de Sesión",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    );

    if (resultado == DialogResult.Yes)
    {
        // Limpiar sesión
        SesionUsuario.CerrarSesion();

        // Registrar cierre de sesión (opcional)
        RegistrarEventoAuditoria("Cierre de Sesión");

        // Cerrar formulario actual
        this.Close();

        // Reiniciar aplicación para mostrar login
        Application.Restart();
    }
}

private void RegistrarEventoAuditoria(string evento)
{
    // TODO: Implementar registro de auditoría
    // Guardar evento en base de datos con timestamp
}

// ============================================================================
// EJEMPLO 5: Validación en Tiempo Real de Permisos
// ============================================================================

private bool ValidarAccesoAccion(string accion)
{
    bool tieneAcceso = AutorizacionRoles.TieneAccesoAccion(SesionUsuario.IdRolActual, accion);

    if (!tieneAcceso)
    {
        string mensaje = $"No tiene permiso para: {accion}";
        MessageBox.Show(mensaje, "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    return tieneAcceso;
}

// Uso:
private void btnEliminarUsuario_Click(object sender, EventArgs e)
{
    if (ValidarAccesoAccion("EliminarUsuario"))
    {
        // Ejecutar eliminación
        EliminarUsuarioSeleccionado();
    }
}

// ============================================================================
// EJEMPLO 6: Obtener y Mostrar Información del Rol Actual
// ============================================================================

private void MostrarInformacionRol()
{
    int rolId = SesionUsuario.IdRolActual;

    // Obtener nombre del rol
    string nombreRol = AutorizacionRoles.ObtenerNombreRol(rolId);

    // Obtener descripción del rol
    string descripcion = AutorizacionRoles.ObtenerDescripcionRol(rolId);

    // Obtener módulos disponibles
    List<string> modulos = AutorizacionRoles.ObtenerModulosDisponibles(rolId);

    // Mostrar en interfaz
    lblRolActual.Text = $"Rol: {nombreRol}";
    txtDescripcionRol.Text = descripcion;

    // Llenar ListBox con módulos disponibles
    lstModulosDisponibles.DataSource = modulos;
}

// ============================================================================
// EJEMPLO 7: Agregar Nuevo Rol (Extensible)
// ============================================================================

/*
Para agregar un nuevo rol, modificar AutorizacionRoles.cs:

1. Agregar constante del rol:
   public const int ROL_GERENTE = 4;
   public const string NOMBRE_GERENTE = "Gerente";

2. Actualizar ObtenerNombreRol():
   case ROL_GERENTE:
       return NOMBRE_GERENTE;

3. Actualizar TieneAcceso():
   case ROL_GERENTE:
       return modulo == "Dashboard" || 
              modulo == "Ordenes" || 
              modulo == "Reportes" || 
              modulo == "Perfil";

4. Actualizar ObtenerModulosDisponibles():
   case ROL_GERENTE:
       modulos.AddRange(new[] { "Dashboard", "Ordenes", "Reportes", "Perfil" });
       break;

5. Actualizar ObtenerDescripcionRol():
   case ROL_GERENTE:
       return "Gerente: Puede gestionar órdenes, ver reportes y supervisar operaciones.";
*/

// ============================================================================
// EJEMPLO 8: Crear Formulario de Gestión de Permisos (Para Admin)
// ============================================================================

public class FrmGestionPermisos : Form
{
    private void CargarRolesYPermisos()
    {
        // Crear tabla de permisos
        DataTable dtPermisos = new DataTable();
        dtPermisos.Columns.Add("Modulo");
        dtPermisos.Columns.Add("Administrador", typeof(bool));
        dtPermisos.Columns.Add("Recepcionista", typeof(bool));
        dtPermisos.Columns.Add("Mecanico", typeof(bool));

        // Agregar módulos
        string[] modulos = { "Dashboard", "Clientes", "Ordenes", "Vehiculos", "Usuarios", "Reportes", "Configuracion", "Perfil" };

        foreach (string modulo in modulos)
        {
            DataRow row = dtPermisos.NewRow();
            row["Modulo"] = modulo;
            row["Administrador"] = AutorizacionRoles.TieneAcceso(AutorizacionRoles.ROL_ADMINISTRADOR, modulo);
            row["Recepcionista"] = AutorizacionRoles.TieneAcceso(AutorizacionRoles.ROL_RECEPCIONISTA, modulo);
            row["Mecanico"] = AutorizacionRoles.TieneAcceso(AutorizacionRoles.ROL_MECANICO, modulo);
            dtPermisos.Rows.Add(row);
        }

        // Mostrar en DataGridView
        dgvPermisos.DataSource = dtPermisos;
    }
}

// ============================================================================
// EJEMPLO 9: Registrar Evento de Login en BD
// ============================================================================

public class D_EventosAuditoria
{
    public void RegistrarLogin(int idUsuario, string username, DateTime fechaHora)
    {
        using (SqlConnection cn = Conexion.ObtenerConexion())
        {
            SqlCommand cmd = new SqlCommand("SP_RegistrarEventoLogin", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@FechaHora", fechaHora);

            cn.Open();
            cmd.ExecuteNonQuery();
        }
    }

    public void RegistrarIntentofallido(string username, DateTime fechaHora)
    {
        using (SqlConnection cn = Conexion.ObtenerConexion())
        {
            SqlCommand cmd = new SqlCommand("SP_RegistrarIntentoFallido", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@FechaHora", fechaHora);

            cn.Open();
            cmd.ExecuteNonQuery();
        }
    }
}

// ============================================================================
// EJEMPLO 10: Implementar Multi-Idioma en Mensajes (Extensible)
// ============================================================================

public static class Mensajes
{
    public static class Spanish
    {
        public const string AccesoDenegado = "No tiene permiso para acceder a este módulo";
        public const string LoginExitoso = "¡Ingreso exitoso!";
        public const string UsuarioInactivo = "Este usuario está inactivo";
        public const string CampoRequerido = "Campo requerido";
    }

    public static class English
    {
        public const string AccesoDenegado = "You do not have permission to access this module";
        public const string LoginExitoso = "Successful login!";
        public const string UsuarioInactivo = "This user is inactive";
        public const string CampoRequerido = "Required field";
    }
}

// ============================================================================

