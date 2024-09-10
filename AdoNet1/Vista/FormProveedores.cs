using Modelo_V2.Objetos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FormProveedores : Form
    {
        public FormProveedores()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var formProveedor = new FormProveedor();
            formProveedor.ShowDialog();
            ActualizarVista();
        }

        private void ActualizarVista()
        {
            var list = Controladora.ControladoraProveedor.Instance.RecuperarProveedores();
            dgvProveedores.DataSource = null;
            dgvProveedores.DataSource = list;
        }

        private void FormProveedores_Load(object sender, EventArgs e)
        {
            //dgvProveedores.AutoGenerateColumns = false;
            ActualizarVista();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (dgvProveedores.Rows.Count > 0)
            {
                var proveedor = (Proveedor)dgvProveedores.CurrentRow.DataBoundItem;
                bool ok = Controladora.ControladoraProveedor.Instance.EliminarProveedor(proveedor);
                if (ok) ActualizarVista();
                else MessageBox.Show("No se pudo eliminar el proveedor");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.Rows.Count > 0)
            {
                var proveedor = (Proveedor)dgvProveedores.CurrentRow.DataBoundItem;
                var formProveedor = new FormProveedor(proveedor);
                formProveedor.ShowDialog();
                ActualizarVista();
            }
        }
    }
}
