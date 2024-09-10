namespace Vista
{
    partial class FrmCalculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSumar = new Button();
            btnSalir = new Button();
            lblNumero2 = new Label();
            lblNumero1 = new Label();
            txtNumero1 = new MaskedTextBox();
            txtNumero2 = new MaskedTextBox();
            SuspendLayout();
            // 
            // btnSumar
            // 
            btnSumar.Location = new Point(29, 134);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(75, 23);
            btnSumar.TabIndex = 2;
            btnSumar.Text = "Sumar";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(180, 134);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblNumero2
            // 
            lblNumero2.AutoSize = true;
            lblNumero2.Location = new Point(29, 77);
            lblNumero2.Name = "lblNumero2";
            lblNumero2.Size = new Size(63, 15);
            lblNumero2.TabIndex = 4;
            lblNumero2.Text = "Numero 2:";
            // 
            // lblNumero1
            // 
            lblNumero1.AutoSize = true;
            lblNumero1.Location = new Point(29, 24);
            lblNumero1.Name = "lblNumero1";
            lblNumero1.Size = new Size(63, 15);
            lblNumero1.TabIndex = 5;
            lblNumero1.Text = "Numero 1:";
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(98, 21);
            txtNumero1.Mask = "0000000000000";
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(157, 23);
            txtNumero1.TabIndex = 6;
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(98, 74);
            txtNumero2.Mask = "0000000000000";
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(157, 23);
            txtNumero2.TabIndex = 7;
            // 
            // FrmCalculadora
            // 
            AcceptButton = btnSumar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnSalir;
            ClientSize = new Size(291, 185);
            ControlBox = false;
            Controls.Add(txtNumero2);
            Controls.Add(txtNumero1);
            Controls.Add(lblNumero1);
            Controls.Add(lblNumero2);
            Controls.Add(btnSalir);
            Controls.Add(btnSumar);
            Name = "FrmCalculadora";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            Load += frmCalculadora_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSumar;
        private Button btnSalir;
        private Label lblNumero2;
        private Label lblNumero1;
        private MaskedTextBox txtNumero1;
        private MaskedTextBox txtNumero2;
    }
}
