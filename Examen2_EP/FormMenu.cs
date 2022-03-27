using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Examen2_EP
{
    public partial class FormMenu : Syncfusion.Windows.Forms.Office2010Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        FrmProductos frmProductos = null;
        FrmPedidos frmPedidos = null;

        private void ProductostoolStripButton_Click(object sender, EventArgs e)
        {
            if (frmProductos == null)
            {
                frmProductos = new FrmProductos();
                frmProductos.MdiParent = this;
                frmProductos.FormClosed += FrmProductos_FormClosed;
                frmProductos.Show();
            }
            else
            {
                frmProductos.Activate();
            }
        }

        private void FrmProductos_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmProductos = null;
        }

        private void PedidotoolStripButton_Click(object sender, EventArgs e)
        {
            if (frmPedidos == null)
            {
                frmPedidos = new FrmPedidos();
                frmPedidos.MdiParent = this;
                frmPedidos.FormClosed += FrmPedidos_FormClosed;
                frmPedidos.Show();
            }
            else
            {
                frmPedidos.Activate();
            }
        }

        private void FrmPedidos_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmPedidos = null;
        }
    }
}
