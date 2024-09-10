namespace Vista
{
    partial class FormProveedor
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
            groupBox1 = new GroupBox();
            txtDireccion = new TextBox();
            label4 = new Label();
            txtTelefono = new TextBox();
            label3 = new Label();
            btnAceptar = new Button();
            txtCuit = new TextBox();
            txtRazonSocial = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnCancelar = new Button();
            lblLeyenda = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnAceptar);
            groupBox1.Controls.Add(txtCuit);
            groupBox1.Controls.Add(txtRazonSocial);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Location = new Point(10, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(258, 175);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Proveedor";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(103, 109);
            txtDireccion.MaxLength = 150;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(149, 23);
            txtDireccion.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 112);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 9;
            label4.Text = "Direccion";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(103, 80);
            txtTelefono.MaxLength = 150;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(151, 23);
            txtTelefono.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 84);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 7;
            label3.Text = "Telefono";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(8, 141);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtCuit
            // 
            txtCuit.Location = new Point(103, 22);
            txtCuit.MaxLength = 15;
            txtCuit.Name = "txtCuit";
            txtCuit.Size = new Size(149, 23);
            txtCuit.TabIndex = 2;
            // 
            // txtRazonSocial
            // 
            txtRazonSocial.Location = new Point(103, 51);
            txtRazonSocial.MaxLength = 150;
            txtRazonSocial.Name = "txtRazonSocial";
            txtRazonSocial.Size = new Size(151, 23);
            txtRazonSocial.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 26);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 4;
            label1.Text = "Cuit";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 55);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 5;
            label2.Text = "Razon Social";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(178, 141);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblLeyenda
            // 
            lblLeyenda.AutoSize = true;
            lblLeyenda.Location = new Point(10, 188);
            lblLeyenda.Name = "lblLeyenda";
            lblLeyenda.Size = new Size(38, 15);
            lblLeyenda.TabIndex = 8;
            lblLeyenda.Text = "label8";
            lblLeyenda.Visible = false;
            // 
            // FormProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 206);
            Controls.Add(lblLeyenda);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormProveedor";
            Text = "FormProveedor";
            Load += FormProveedor_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtDireccion;
        private Label label7;
        private ComboBox cBoxCategorias;
        private TextBox txtCantidadMinima;
        private Label label6;
        private TextBox txtCantidadActual;
        private Label label5;
        private TextBox txtPrecioVenta;
        private Label label4;
        private TextBox txtTelefono;
        private TextBox txtPrecioCompra;
        private Label label3;
        private Button btnAceptar;
        private TextBox txtCuit;
        private TextBox txtCodigo;
        private TextBox txtRazonSocial;
        private Label label1;
        private Label label2;
        private Button btnCancelar;
        private Label lblLeyenda;
    }
}