namespace Examen2_EP
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
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ClienteTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CantidadTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CodigoProductoTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PedidosDataGridView = new System.Windows.Forms.DataGridView();
            this.Cancelarbutton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.NoTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NuevoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PedidosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Enabled = false;
            this.DescripcionTextBox.Location = new System.Drawing.Point(125, 123);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(100, 20);
            this.DescripcionTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Descripcion: ";
            // 
            // ClienteTextBox
            // 
            this.ClienteTextBox.Enabled = false;
            this.ClienteTextBox.Location = new System.Drawing.Point(125, 86);
            this.ClienteTextBox.Name = "ClienteTextBox";
            this.ClienteTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClienteTextBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cliente:";
            // 
            // CantidadTextBox
            // 
            this.CantidadTextBox.Enabled = false;
            this.CantidadTextBox.Location = new System.Drawing.Point(125, 158);
            this.CantidadTextBox.Name = "CantidadTextBox";
            this.CantidadTextBox.Size = new System.Drawing.Size(100, 20);
            this.CantidadTextBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cantidad:";
            // 
            // CodigoProductoTextBox
            // 
            this.CodigoProductoTextBox.Enabled = false;
            this.CodigoProductoTextBox.Location = new System.Drawing.Point(125, 44);
            this.CodigoProductoTextBox.Name = "CodigoProductoTextBox";
            this.CodigoProductoTextBox.Size = new System.Drawing.Size(100, 20);
            this.CodigoProductoTextBox.TabIndex = 17;
            this.CodigoProductoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CodigoProductoTextBox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Codigo Producto:";
            // 
            // PedidosDataGridView
            // 
            this.PedidosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PedidosDataGridView.Location = new System.Drawing.Point(12, 240);
            this.PedidosDataGridView.Name = "PedidosDataGridView";
            this.PedidosDataGridView.Size = new System.Drawing.Size(509, 150);
            this.PedidosDataGridView.TabIndex = 18;
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.Location = new System.Drawing.Point(257, 211);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(75, 23);
            this.Cancelarbutton.TabIndex = 21;
            this.Cancelarbutton.Text = "Cancelar";
            this.Cancelarbutton.UseVisualStyleBackColor = true;
            this.Cancelarbutton.Click += new System.EventHandler(this.Cancelarbutton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(160, 211);
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
            // NoTextBox
            // 
            this.NoTextBox.Enabled = false;
            this.NoTextBox.Location = new System.Drawing.Point(126, 12);
            this.NoTextBox.Name = "NoTextBox";
            this.NoTextBox.Size = new System.Drawing.Size(96, 20);
            this.NoTextBox.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "No.";
            // 
            // NuevoButton
            // 
            this.NuevoButton.Location = new System.Drawing.Point(66, 211);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(64, 23);
            this.NuevoButton.TabIndex = 24;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // FrmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 396);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.NoTextBox);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.Cancelarbutton);
            this.Controls.Add(this.PedidosDataGridView);
            this.Controls.Add(this.CodigoProductoTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CantidadTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ClienteTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.label1);
            this.Name = "FrmPedidos";
            this.Text = "Formulario de Pedidos";
            this.Load += new System.EventHandler(this.FrmPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PedidosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ClienteTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CantidadTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CodigoProductoTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView PedidosDataGridView;
        private System.Windows.Forms.Button Cancelarbutton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox NoTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button NuevoButton;
    }
}