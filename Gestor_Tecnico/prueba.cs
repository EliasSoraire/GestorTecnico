using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_Tecnico
{
    public partial class prueba : Form
    {
        public prueba()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConexionSQL conexion = new ConexionSQL();
            conexion.ProbarConexion();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConexionSQL conexion = new ConexionSQL();
            string info = conexion.ObtenerInfoServidor();
            MessageBox.Show(info, "Informacion del servidor");
        }
    }
}
