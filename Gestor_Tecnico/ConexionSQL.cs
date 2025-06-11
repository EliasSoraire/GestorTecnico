using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gestor_Tecnico
{
    public class ConexionSQL
    {
        private readonly string cadenaConexion;

        public ConexionSQL()
        {
            cadenaConexion = "Server=(localdb)\\MSSQLLocalDB;Database=Gestor_Tecnico;Trusted_Connection=True;";
        }

        public SqlConnection ObtenerConexion()
        {
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar: {ex.Message}", "Error de Conexión",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        // Método específico para probar la conexión
        public bool ProbarConexion()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    MessageBox.Show("¡Conexión exitosa!", "Éxito",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar:\n{ex.Message}", "Error de Conexión",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Método para obtener información del servidor
        public string ObtenerInfoServidor()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string info = $"Servidor: {conexion.DataSource}\n";
                    info += $"Base de Datos: {conexion.Database}\n";
                    info += $"Versión: {conexion.ServerVersion}\n";
                    info += $"Estado: {conexion.State}";
                    return info;
                }
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }
    }
}