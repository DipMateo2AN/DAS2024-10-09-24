using Modelo_V2.Objetos;

namespace Vista
{
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //this.dgvProductos.AutoGenerateColumns = false;
            ActualizarVista();
        }

        private void ActualizarVista()
        {
            var list = Controladora.ControladoraProductos.Instancia.RecuperarProductos();
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = list;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var formProducto = new FormProducto();
            formProducto.ShowDialog();
            ActualizarVista();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.Rows.Count > 0)
            {
                var producto = (Producto)dgvProductos.CurrentRow.DataBoundItem;
                var formProducto = new FormProducto(producto);
                formProducto.ShowDialog();
                ActualizarVista();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.Rows.Count > 0)
            {
                var producto = (Producto)dgvProductos.CurrentRow.DataBoundItem;
                bool ok = Controladora.ControladoraProductos.Instancia.EliminarProducto(producto);
                if (ok) ActualizarVista();
                else MessageBox.Show("No se pudo eliminar la categoría");
            }
        }
    }
}
