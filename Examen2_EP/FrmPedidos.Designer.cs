﻿namespace Examen2_EP
{
    partial class FrmPedidos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CodigoPedidoTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ClienteTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CantidadTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PrecioTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CodigoProductoTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PedidosDataGridView = new System.Windows.Forms.DataGridView();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Cancelarbutton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Modificarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PedidosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // CodigoPedidoTextBox
            // 
            this.CodigoPedidoTextBox.Enabled = false;
            this.CodigoPedidoTextBox.Location = new System.Drawing.Point(125, 49);
            this.CodigoPedidoTextBox.Name = "CodigoPedidoTextBox";
            this.CodigoPedidoTextBox.Size = new System.Drawing.Size(100, 20);
            this.CodigoPedidoTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Codigo Pedido:";
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Enabled = false;
            this.DescripcionTextBox.Location = new System.Drawing.Point(125, 165);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(100, 20);
            this.DescripcionTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Descripcion: ";
            // 
            // ClienteTextBox
            // 
            this.ClienteTextBox.Enabled = false;
            this.ClienteTextBox.Location = new System.Drawing.Point(125, 128);
            this.ClienteTextBox.Name = "ClienteTextBox";
            this.ClienteTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClienteTextBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cliente:";
            // 
            // CantidadTextBox
            // 
            this.CantidadTextBox.Enabled = false;
            this.CantidadTextBox.Location = new System.Drawing.Point(340, 86);
            this.CantidadTextBox.Name = "CantidadTextBox";
            this.CantidadTextBox.Size = new System.Drawing.Size(100, 20);
            this.CantidadTextBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cantidad:";
            // 
            // PrecioTextBox
            // 
            this.PrecioTextBox.Enabled = false;
            this.PrecioTextBox.Location = new System.Drawing.Point(340, 52);
            this.PrecioTextBox.Name = "PrecioTextBox";
            this.PrecioTextBox.Size = new System.Drawing.Size(100, 20);
            this.PrecioTextBox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Precio:";
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Enabled = false;
            this.TotalTextBox.Location = new System.Drawing.Point(340, 127);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.TotalTextBox.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(298, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Total:";
            // 
            // CodigoProductoTextBox
            // 
            this.CodigoProductoTextBox.Enabled = false;
            this.CodigoProductoTextBox.Location = new System.Drawing.Point(125, 86);
            this.CodigoProductoTextBox.Name = "CodigoProductoTextBox";
            this.CodigoProductoTextBox.Size = new System.Drawing.Size(100, 20);
            this.CodigoProductoTextBox.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Codigo Producto:";
            // 
            // PedidosDataGridView
            // 
            this.PedidosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PedidosDataGridView.Location = new System.Drawing.Point(0, 247);
            this.PedidosDataGridView.Name = "PedidosDataGridView";
            this.PedidosDataGridView.Size = new System.Drawing.Size(509, 150);
            this.PedidosDataGridView.TabIndex = 18;
            // 
            // NuevoButton
            // 
            this.NuevoButton.Location = new System.Drawing.Point(29, 211);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(75, 23);
            this.NuevoButton.TabIndex = 19;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Location = new System.Drawing.Point(312, 211);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 23);
            this.Eliminarbutton.TabIndex = 20;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.Location = new System.Drawing.Point(422, 211);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(75, 23);
            this.Cancelarbutton.TabIndex = 21;
            this.Cancelarbutton.Text = "Cancelar";
            this.Cancelarbutton.UseVisualStyleBackColor = true;
            this.Cancelarbutton.Click += new System.EventHandler(this.Cancelarbutton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(211, 211);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 23);
            this.GuardarButton.TabIndex = 22;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Modificarbutton
            // 
            this.Modificarbutton.Location = new System.Drawing.Point(125, 211);
            this.Modificarbutton.Name = "Modificarbutton";
            this.Modificarbutton.Size = new System.Drawing.Size(75, 23);
            this.Modificarbutton.TabIndex = 23;
            this.Modificarbutton.Text = "Modificar";
            this.Modificarbutton.UseVisualStyleBackColor = true;
            // 
            // FrmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 396);
            this.Controls.Add(this.Modificarbutton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.Cancelarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.PedidosDataGridView);
            this.Controls.Add(this.CodigoProductoTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PrecioTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CantidadTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ClienteTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CodigoPedidoTextBox);
            this.Controls.Add(this.label3);
            this.Name = "FrmPedidos";
            this.Text = "Formulario de Pedidos";
            this.Load += new System.EventHandler(this.FrmPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PedidosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox CodigoPedidoTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ClienteTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CantidadTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PrecioTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CodigoProductoTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView PedidosDataGridView;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Cancelarbutton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button Modificarbutton;
    }
}