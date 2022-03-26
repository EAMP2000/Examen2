namespace Examen2_EP
{
    partial class FrmProductos
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
            this.label1 = new System.Windows.Forms.Label();
            this.CodigoProductoTextBox = new System.Windows.Forms.TextBox();
            this.ExistenciasTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PrecioTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.ProductosDataGridView1 = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ProductosDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // CodigoProductoTextBox
            // 
            this.CodigoProductoTextBox.Enabled = false;
            this.CodigoProductoTextBox.Location = new System.Drawing.Point(109, 33);
            this.CodigoProductoTextBox.Name = "CodigoProductoTextBox";
            this.CodigoProductoTextBox.Size = new System.Drawing.Size(100, 20);
            this.CodigoProductoTextBox.TabIndex = 1;
            // 
            // ExistenciasTextBox
            // 
            this.ExistenciasTextBox.Enabled = false;
            this.ExistenciasTextBox.Location = new System.Drawing.Point(109, 105);
            this.ExistenciasTextBox.Name = "ExistenciasTextBox";
            this.ExistenciasTextBox.Size = new System.Drawing.Size(100, 20);
            this.ExistenciasTextBox.TabIndex = 3;
            this.ExistenciasTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ExistenciasTextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Existencias:";
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Enabled = false;
            this.DescripcionTextBox.Location = new System.Drawing.Point(326, 33);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(212, 20);
            this.DescripcionTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descripcion:";
            // 
            // PrecioTextBox
            // 
            this.PrecioTextBox.Enabled = false;
            this.PrecioTextBox.Location = new System.Drawing.Point(109, 71);
            this.PrecioTextBox.Name = "PrecioTextBox";
            this.PrecioTextBox.Size = new System.Drawing.Size(100, 20);
            this.PrecioTextBox.TabIndex = 7;
            this.PrecioTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PrecioTextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Precio:";
            // 
            // AgregarButton
            // 
            this.AgregarButton.Location = new System.Drawing.Point(109, 152);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(75, 22);
            this.AgregarButton.TabIndex = 8;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Location = new System.Drawing.Point(326, 153);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 22);
            this.Eliminarbutton.TabIndex = 10;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(211, 153);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 22);
            this.Guardarbutton.TabIndex = 11;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(434, 153);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(75, 23);
            this.CancelarButton.TabIndex = 12;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // ProductosDataGridView1
            // 
            this.ProductosDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductosDataGridView1.Location = new System.Drawing.Point(1, 205);
            this.ProductosDataGridView1.Name = "ProductosDataGridView1";
            this.ProductosDataGridView1.Size = new System.Drawing.Size(570, 193);
            this.ProductosDataGridView1.TabIndex = 13;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 401);
            this.Controls.Add(this.ProductosDataGridView1);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.AgregarButton);
            this.Controls.Add(this.PrecioTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ExistenciasTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CodigoProductoTextBox);
            this.Controls.Add(this.label1);
            this.Name = "FrmProductos";
            this.Text = "FrmProductos";
            this.Load += new System.EventHandler(this.FrmProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductosDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CodigoProductoTextBox;
        private System.Windows.Forms.TextBox ExistenciasTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PrecioTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.DataGridView ProductosDataGridView1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}