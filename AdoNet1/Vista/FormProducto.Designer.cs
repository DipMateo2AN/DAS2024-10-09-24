namespace Vista
{
    partial class FormProducto
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
            btnAceptar = new Button();
            btnCancelar = new Button();
            txtCodigo = new TextBox();
            txtDescripcion = new TextBox();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            label7 = new Label();
            cBoxCategorias = new ComboBox();
            txtCantidadMinima = new TextBox();
            label6 = new Label();
            txtCantidadActual = new TextBox();
            label5 = new Label();
            txtPrecioVenta = new TextBox();
            label4 = new Label();
            txtPrecioCompra = new TextBox();
            label3 = new Label();
            label8 = new Label();
            cmbProveedor = new ComboBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(7, 335);
            btnAceptar.Margin = new Padding(3, 4, 3, 4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(86, 31);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(204, 335);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 31);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(118, 29);
            txtCodigo.Margin = new Padding(3, 4, 3, 4);
            txtCodigo.MaxLength = 15;
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(170, 27);
            txtCodigo.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(118, 68);
            txtDescripcion.Margin = new Padding(3, 4, 3, 4);
            txtDescripcion.MaxLength = 150;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(172, 27);
            txtDescripcion.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 33);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 4;
            label1.Text = "Código";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 72);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 5;
            label2.Text = "Descripción";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(cmbProveedor);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cBoxCategorias);
            groupBox1.Controls.Add(txtCantidadMinima);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtCantidadActual);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtPrecioVenta);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtPrecioCompra);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnAceptar);
            groupBox1.Controls.Add(txtCodigo);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Location = new Point(14, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(295, 376);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Producto";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 265);
            label7.Name = "label7";
            label7.Size = new Size(74, 20);
            label7.TabIndex = 15;
            label7.Text = "Categoria";
            // 
            // cBoxCategorias
            // 
            cBoxCategorias.DropDownStyle = ComboBoxStyle.DropDownList;
            cBoxCategorias.FormattingEnabled = true;
            cBoxCategorias.Location = new Point(118, 261);
            cBoxCategorias.Margin = new Padding(3, 4, 3, 4);
            cBoxCategorias.Name = "cBoxCategorias";
            cBoxCategorias.Size = new Size(170, 28);
            cBoxCategorias.TabIndex = 14;
            // 
            // txtCantidadMinima
            // 
            txtCantidadMinima.Location = new Point(118, 223);
            txtCantidadMinima.Margin = new Padding(3, 4, 3, 4);
            txtCantidadMinima.MaxLength = 150;
            txtCantidadMinima.Name = "txtCantidadMinima";
            txtCantidadMinima.Size = new Size(170, 27);
            txtCantidadMinima.TabIndex = 12;
            txtCantidadMinima.KeyPress += txtCantidad_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 227);
            label6.Name = "label6";
            label6.Size = new Size(123, 20);
            label6.TabIndex = 13;
            label6.Text = "Cantidad Minima";
            // 
            // txtCantidadActual
            // 
            txtCantidadActual.Location = new Point(118, 184);
            txtCantidadActual.Margin = new Padding(3, 4, 3, 4);
            txtCantidadActual.MaxLength = 150;
            txtCantidadActual.Name = "txtCantidadActual";
            txtCantidadActual.Size = new Size(170, 27);
            txtCantidadActual.TabIndex = 10;
            txtCantidadActual.KeyPress += txtCantidad_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 188);
            label5.Name = "label5";
            label5.Size = new Size(118, 20);
            label5.TabIndex = 11;
            label5.Text = "Cantidad Actual:";
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(118, 145);
            txtPrecioVenta.Margin = new Padding(3, 4, 3, 4);
            txtPrecioVenta.MaxLength = 150;
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(170, 27);
            txtPrecioVenta.TabIndex = 8;
            txtPrecioVenta.KeyPress += txtPrecio_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 149);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 9;
            label4.Text = "Precio Venta:";
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.Location = new Point(118, 107);
            txtPrecioCompra.Margin = new Padding(3, 4, 3, 4);
            txtPrecioCompra.MaxLength = 150;
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.Size = new Size(172, 27);
            txtPrecioCompra.TabIndex = 6;
            txtPrecioCompra.KeyPress += txtPrecio_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 111);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 7;
            label3.Text = "Precio Compra:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 301);
            label8.Name = "label8";
            label8.Size = new Size(77, 20);
            label8.TabIndex = 17;
            label8.Text = "Proveedor";
            // 
            // cmbProveedor
            // 
            cmbProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProveedor.FormattingEnabled = true;
            cmbProveedor.Location = new Point(118, 297);
            cmbProveedor.Margin = new Padding(3, 4, 3, 4);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(170, 28);
            cmbProveedor.TabIndex = 16;
            // 
            // FormProducto
            // 
            AcceptButton = btnAceptar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(322, 395);
            ControlBox = false;
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            MinimizeBox = false;
            Name = "FormProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormProducto_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnAceptar;
        private Button btnCancelar;
        private TextBox txtCodigo;
        private TextBox txtDescripcion;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Label label7;
        private ComboBox cBoxCategorias;
        private TextBox txtCantidadMinima;
        private Label label6;
        private TextBox txtCantidadActual;
        private Label label5;
        private TextBox txtPrecioVenta;
        private Label label4;
        private TextBox txtPrecioCompra;
        private Label label3;
        private Label label8;
        private ComboBox cmbProveedor;
    }
}