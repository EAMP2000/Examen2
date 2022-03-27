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
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        string Operacion = "";
        ProductoDA productoDA = new ProductoDA();

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            Operacion = "Nuevo";
            HabilitarControles();
        }

        private void HabilitarControles()
        {
            CodigoProductoTextBox.Enabled = true;
            DescripcionTextBox.Enabled = true;
            PrecioTextBox.Enabled = true;
            ExistenciasTextBox.Enabled = true;
           
            Guardarbutton.Enabled = true;
            CancelarButton.Enabled = true;
            AgregarButton.Enabled = false;
            
        }

        private void DeshabilitarControles()
        {
            CodigoProductoTextBox.Enabled = false;
            DescripcionTextBox.Enabled = false;
            PrecioTextBox.Enabled = false;
            ExistenciasTextBox.Enabled = false;
           
            Guardarbutton.Enabled = false;
            CancelarButton.Enabled = false;
            AgregarButton.Enabled = true;
            
        }

        private void LimpiarControles()
        {
            CodigoProductoTextBox.Clear();
            DescripcionTextBox.Clear();
            PrecioTextBox.Clear();
            ExistenciasTextBox.Clear();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(CodigoProductoTextBox.Text))
                {
                    errorProvider1.SetError(CodigoProductoTextBox, "Ingrese el Codigo del producto.");
                    CodigoProductoTextBox.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(DescripcionTextBox.Text))
                {
                    errorProvider1.SetError(DescripcionTextBox, "Ingrese la descripcion del producto.");
                    DescripcionTextBox.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(PrecioTextBox.Text))
                {
                    errorProvider1.SetError(PrecioTextBox, "Ingrese el Precio del producto.");
                    PrecioTextBox.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(ExistenciasTextBox.Text))
                {
                    errorProvider1.SetError(ExistenciasTextBox, "Ingrese la cantidad de existencias del producto.");
                    ExistenciasTextBox.Focus();
                    return;
                }

                Producto producto = new Producto();
                producto.CodigoProducto = Convert.ToInt32(CodigoProductoTextBox.Text);
                producto.Descripcion = DescripcionTextBox.Text;
                producto.Precio = Convert.ToDecimal(PrecioTextBox.Text);
                producto.Existencias = Convert.ToInt32(ExistenciasTextBox.Text);


                if (Operacion == "Nuevo")
                {
                    bool Insertado = productoDA.InsertarProducto(producto);

                    if (Insertado)
                    {
                        DeshabilitarControles();
                        LimpiarControles();
                        ListarProductos();
                        MessageBox.Show("Producto Agregado Exitosamente.");

                    }
                }
                else if (Operacion == "Modificar")
                {
                    bool Modificar = productoDA.ModificarProducto(producto);
                    if (Modificar)
                    {
                        LimpiarControles();
                        DeshabilitarControles();
                        ListarProductos();
                        MessageBox.Show("Producto a sido Modificado");

                    }
                }
            }
            catch (Exception ex)
            {


            }
        }

        private void ListarProductos()
        {
             ProductosDataGridView1.DataSource = productoDA.ListarProductos();
        }

        private void PrecioTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            //valida que no se ingrese mas de un punto.
            if ((e.KeyChar == '.') && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void ExistenciasTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //private void Modificarbutton_Click(object sender, EventArgs e)
        //{
        //    Operacion = "Modificar";

        //    if (ProductosDataGridView1.SelectedRows.Count > 0)
        //    {
        //        CodigoProductoTextBox.Text = ProductosDataGridView1.CurrentRow.Cells["CodigoProducto"].Value.ToString();
        //        DescripcionTextBox.Text = ProductosDataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString(); ;
        //        PrecioTextBox.Text = ProductosDataGridView1.CurrentRow.Cells["Precio"].Value.ToString(); ;
        //        ExistenciasTextBox.Text = ProductosDataGridView1.CurrentRow.Cells["Existencias"].Value.ToString(); ;

        //        HabilitarControles();
        //        CodigoProductoTextBox.Focus();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Seleccione el producto");
        //    }
        //}

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (ProductosDataGridView1.SelectedRows.Count > 0)
            {
                bool Eliminado = productoDA.EliminarProducto(ProductosDataGridView1.CurrentRow.Cells["CodigoProducto"].Value.ToString());

                if (Eliminado) //se entiende como TRUE
                {
                    MessageBox.Show("Producto  eliminado Exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListarProductos();
                }
                else
                {
                    MessageBox.Show("Producto  no eliminado ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            Guardarbutton.Enabled = false;
            CancelarButton.Enabled = true;
            ListarProductos();
        }
    }
}
