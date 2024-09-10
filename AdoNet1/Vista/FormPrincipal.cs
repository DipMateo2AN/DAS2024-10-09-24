namespace Vista
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formCategorias = new FormCategorias
            {
                MdiParent = this
            };
            formCategorias.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formProductos = new FormProductos
            {
                MdiParent = this
            };
            formProductos.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formProveedores = new FormProveedores
            {
                MdiParent = this
            };
            formProveedores.Show();
        }
    }
}
