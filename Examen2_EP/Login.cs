
using Examen2_EP.Accesos;
using Examen2_EP.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen2_EP
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void IngresarButton_Click(object sender, EventArgs e)
        {
            UsuarioDA usuarioDA = new UsuarioDA();
            Usuario usuario = new Usuario();

            usuario = usuarioDA.Login(CodigoTextBox.Text, ClaveTextBox.Text);

            if (usuario == null)
            {
                MessageBox.Show("Usuario desconocido.");
                return; //el return detiene la ejecucion de las demas lineas del programa
            }
            else
            {
                MessageBox.Show("Usuario Correcto.");
            }

            //FrmProductos frmProductos = new FrmProductos();
            //frmProductos.Show();
            //this.Hide();

            FrmPedidos frmPedidos = new FrmPedidos();
            frmPedidos.Show();
            this.Hide();

        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
