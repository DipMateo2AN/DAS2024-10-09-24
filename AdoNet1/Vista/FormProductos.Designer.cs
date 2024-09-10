using System.Windows.Forms;

namespace Vista
{
    partial class FormProductos
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
            dgvProductos = new DataGridView();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            colCodigo = new DataGridViewTextBoxColumn();
            colDescripcion = new DataGridViewTextBoxColumn();
            colPrecioCompra = new DataGridViewTextBoxColumn();
            colPrecioVenta = new DataGridViewTextBoxColumn();
            colCantidadActual = new DataGridViewTextBoxColumn();
            colCantidadMinima = new DataGridViewTextBoxColumn();
            colCategoria = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { colCodigo, colDescripcion, colPrecioCompra, colPrecioVenta, colCantidadActual, colCantidadMinima, colCategoria });
            dgvProductos.Location = new Point(14, 16);
            dgvProductos.Margin = new Padding(3, 4, 3, 4);
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(1040, 379);
            dgvProductos.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(14, 403);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(86, 69);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.Bottom;
            btnModificar.Location = new Point(486, 403);
            btnModificar.Margin = new Padding(3, 4, 3, 4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(86, 69);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEliminar.Location = new Point(968, 403);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(86, 69);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // colCodigo
            // 
            colCodigo.DataPropertyName = "Codigo";
            colCodigo.HeaderText = "Código";
            colCodigo.MinimumWidth = 6;
            colCodigo.Name = "colCodigo";
            colCodigo.ReadOnly = true;
            // 
            // colDescripcion
            // 
            colDescripcion.DataPropertyName = "Descripcion";
            colDescripcion.HeaderText = "Descripción";
            colDescripcion.MinimumWidth = 6;
            colDescripcion.Name = "colDescripcion";
            colDescripcion.ReadOnly = true;
            // 
            // colPrecioCompra
            // 
            colPrecioCompra.DataPropertyName = "PrecioCompra";
            colPrecioCompra.HeaderText = "Precio de Compra";
            colPrecioCompra.MinimumWidth = 6;
            colPrecioCompra.Name = "colPrecioCompra";
            colPrecioCompra.ReadOnly = true;
            // 
            // colPrecioVenta
            // 
            colPrecioVenta.DataPropertyName = "PrecioVenta";
            colPrecioVenta.HeaderText = "Precio de Venta";
            colPrecioVenta.MinimumWidth = 6;
            colPrecioVenta.Name = "colPrecioVenta";
            colPrecioVenta.ReadOnly = true;
            // 
            // colCantidadActual
            // 
            colCantidadActual.DataPropertyName = "CantidadActual";
            colCantidadActual.HeaderText = "Cantidad Actual";
            colCantidadActual.MinimumWidth = 6;
            colCantidadActual.Name = "colCantidadActual";
            colCantidadActual.ReadOnly = true;
            // 
            // colCantidadMinima
            // 
            colCantidadMinima.DataPropertyName = "CantidadMinima";
            colCantidadMinima.HeaderText = "Cantidad Minima";
            colCantidadMinima.MinimumWidth = 6;
            colCantidadMinima.Name = "colCantidadMinima";
            colCantidadMinima.ReadOnly = true;
            // 
            // colCategoria
            // 
            colCategoria.DataPropertyName = "Categoria";
            colCategoria.HeaderText = "Categoría";
            colCategoria.MinimumWidth = 6;
            colCategoria.Name = "colCategoria";
            colCategoria.ReadOnly = true;
            // 
            // FormProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 488);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvProductos);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Productos";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvProductos;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private DataGridViewTextBoxColumn colCodigo;
        private DataGridViewTextBoxColumn colDescripcion;
        private DataGridViewTextBoxColumn colPrecioCompra;
        private DataGridViewTextBoxColumn colPrecioVenta;
        private DataGridViewTextBoxColumn colCantidadActual;
        private DataGridViewTextBoxColumn colCantidadMinima;
        private DataGridViewTextBoxColumn colCategoria;
    }
}