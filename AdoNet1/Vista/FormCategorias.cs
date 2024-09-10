using Modelo_V2.Objetos;
namespace Vista
{
    public partial class FormCategorias : Form
    {

        public FormCategorias()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvCategorias.AutoGenerateColumns = false;
            ActualizarVista();
        }

        private void ActualizarVista()
        {
            var list = Controladora.ControladoraCategorias.Instancia.RecuperarCategorias();
            dgvCategorias.DataSource = null;
            dgvCategorias.DataSource = list;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var formCategoria = new FormCategoria();
            formCategoria.ShowDialog();
            ActualizarVista();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.Rows.Count > 0)
            {
                var categoria = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
                var formCategoria = new FormCategoria(categoria);
                formCategoria.ShowDialog();
                ActualizarVista();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.Rows.Count > 0)
            {
                var categoria = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
                bool ok = Controladora.ControladoraCategorias.Instancia.EliminarCategoria(categoria);
                if (ok) ActualizarVista();
                else MessageBox.Show("No se pudo eliminar la categoría");
            }
        }
    }
}
