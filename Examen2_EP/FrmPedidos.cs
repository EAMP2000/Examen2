
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

        ProductoDA productoDA = new ProductoDA();
        Pedido pedidos = new Pedido();
        Producto producto;
        PedidoDA pedidoDA = new PedidoDA();

        List<Pedido> PedidosLista = new List<Pedido>();


        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            this.Close();
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




                Pedido pedido = new Pedido();
                pedido.CodigoProducto = producto.CodigoProducto;
                pedido.Descripcion = producto.Descripcion;
                pedido.Cantidad = Convert.ToInt32(CantidadTextBox.Text);
                pedido.Precio = producto.Precio;
                pedido.Total=producto.Precio * Convert.ToInt32(CantidadTextBox.Text);
                pedido.Cliente = ClienteTextBox.Text;


                PedidosLista.Add(pedido);
                PedidosDataGridView.DataSource = null;
                PedidosDataGridView.DataSource = PedidosLista;


                    foreach (var item in PedidosLista)
                    {
                        pedidoDA.InsertarPedido(item);
                    }
                

            


            }
            catch (Exception ex)
            {


            }
            DeshabilitarControles();
        }





        private void HabilitarControles()
        {
            NoTextBox.Enabled = true;
            CodigoProductoTextBox.Enabled = true;
            DescripcionTextBox.Enabled = true;
            CantidadTextBox.Enabled = true;   
            ClienteTextBox.Enabled = true;

            GuardarButton.Enabled = true;
            Cancelarbutton.Enabled = true;
            NuevoButton.Enabled = false;

        }

        private void DeshabilitarControles()
        {
            NoTextBox.Enabled = false;
            CodigoProductoTextBox.Enabled = false;
            DescripcionTextBox.Enabled = false;
            CantidadTextBox.Enabled = false;

            ClienteTextBox.Enabled = false;

        
            Cancelarbutton.Enabled = false;
            NuevoButton.Enabled = true;
        }

        private void LimpiarControles()
        {
            NoTextBox.Clear();
            CodigoProductoTextBox.Clear();
            ClienteTextBox.Clear();
            DescripcionTextBox.Clear();
            CantidadTextBox.Clear();
            NoTextBox.Focus();

        }



        private void FrmPedidos_Load(object sender, EventArgs e)
        {
            PedidosDataGridView.DataSource = PedidosLista;
            ListarPedidos();
            
        }

        private void ListarPedidos()
        {
            PedidosDataGridView.DataSource = pedidoDA.ListarPedidos();
        }

        private void CodigoProductoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                producto = new Producto();
                producto = productoDA.GetProductoPorCodigo(CodigoProductoTextBox.Text);
                DescripcionTextBox.Text = producto.Descripcion;
                ClienteTextBox.Focus();
            }
            else
            {
                producto = null;
                DescripcionTextBox.Clear();
                CantidadTextBox.Clear();
            }

        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            HabilitarControles();
        }
    }
}
