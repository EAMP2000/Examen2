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
    public partial class FrmPedidos : Form
    {
        public FrmPedidos()
        {
            InitializeComponent();
        }

        string Operacion = "";
        PedidoDA pedidoDA = new PedidoDA();

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Operacion = "Nuevo";
            HabilitarControles();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(CodigoProductoTextBox.Text))
                {
                    errorProvider1.SetError(CodigoProductoTextBox, "Ingrese el Codigo del pedido.");
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
                    errorProvider1.SetError(PrecioTextBox, "Ingrese el Precio del pedido.");
                    PrecioTextBox.Focus();
                    return;
                }


                Pedido pedido = new Pedido();
                pedido.CodigoPedido = Convert.ToInt32(CodigoPedidoTextBox.Text);
                pedido.CodigoProducto = Convert.ToInt32(CodigoProductoTextBox.Text);
                pedido.Descripcion = DescripcionTextBox.Text;
                pedido.Precio = Convert.ToDecimal(PrecioTextBox.Text);
                pedido.Cantidad = Convert.ToInt32(CantidadTextBox.Text);
                pedido.Total = Convert.ToDecimal(TotalTextBox.Text);
                pedido.Cliente = ClienteTextBox.Text;



                if (Operacion == "Nuevo")
                {
                    bool Insertado = pedidoDA.InsertarPedido(pedido);

                    if (Insertado)
                    {
                        DeshabilitarControles();
                        LimpiarControles();
                        ListarPedidos();
                        MessageBox.Show("Producto Agregado Exitosamente.");

                    }
                }

            }
            catch (Exception ex)
            {


            }
        }





        private void HabilitarControles()
        {
            CodigoPedidoTextBox.Enabled = true;
            CodigoProductoTextBox.Enabled = true;
            DescripcionTextBox.Enabled = true;
            CantidadTextBox.Enabled = true;
            PrecioTextBox.Enabled = true;
            TotalTextBox.Enabled = true;    
            ClienteTextBox.Enabled = true;

            GuardarButton.Enabled = true;
            Cancelarbutton.Enabled = true;
            NuevoButton.Enabled = false;

        }

        private void DeshabilitarControles()
        {
            CodigoPedidoTextBox.Enabled = false;
            CodigoProductoTextBox.Enabled = false;
            DescripcionTextBox.Enabled = false;
            CantidadTextBox.Enabled = false;
            PrecioTextBox.Enabled = false;
            TotalTextBox.Enabled = false;
            ClienteTextBox.Enabled = false;

            GuardarButton.Enabled = false;
            Cancelarbutton.Enabled = false;
            NuevoButton.Enabled = true;
        }

        private void LimpiarControles()
        {
            CodigoPedidoTextBox.Clear();
            CodigoProductoTextBox.Clear();
            PrecioTextBox.Clear();
            ClienteTextBox.Clear();
            DescripcionTextBox.Clear();
            CantidadTextBox.Clear();
            PrecioTextBox.Clear();
            TotalTextBox.Clear();
        }

        private void ListarPedidos()
        {
            PedidosDataGridView.DataSource = pedidoDA.ListarPedidos();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (PedidosDataGridView.SelectedRows.Count > 0)
            {
                bool Eliminado = pedidoDA.EliminarPedido(PedidosDataGridView.CurrentRow.Cells["CodigoProducto"].Value.ToString());

                if (Eliminado) //se entiende como TRUE
                {
                    MessageBox.Show("Producto  eliminado Exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListarPedidos();
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

        private void FrmPedidos_Load(object sender, EventArgs e)
        {
            ListarPedidos();
        }
    }
}
