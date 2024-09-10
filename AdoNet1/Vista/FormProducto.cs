using Modelo_V2.Objetos;
using Modelo_V2.Repositorios;

namespace Vista
{
    public partial class FormProducto : Form
    {
        private readonly Producto producto;
        private readonly bool modifica = false;
        public FormProducto()
        {
            InitializeComponent();
        }

        public FormProducto(Producto producto)
        {
            InitializeComponent();
            this.producto = producto;
            modifica = true;
        }

        private void FormProducto_Load(object sender, EventArgs e)
        {
            cBoxCategorias.DataSource = Controladora.ControladoraProductos.Instancia.RecuperarCategorias();
            cBoxCategorias.DisplayMember = "Descripcion";
            cmbProveedor.DataSource = Controladora.ControladoraProductos.Instancia.RecuperarProveedor();
            cmbProveedor.DisplayMember = "Cuit";
            if (producto != null)
            {
                txtCodigo.Text = producto.Codigo;
                txtCodigo.Enabled = false;
                txtDescripcion.Text = producto.Descripcion;
                
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (!modifica)
                {
                    AgregarProducto();
                }
                else
                {
                    ModificarProducto();
                }
            }
        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Debe ingresar un código");
                return false;
            }
            if (string.IsNullOrEmpty(txtCantidadActual.Text))
            {
                MessageBox.Show("Debe ingresar la cantidad actual");
                return false;
            }
            if (string.IsNullOrEmpty(txtCantidadMinima.Text))
            {
                MessageBox.Show("Debe ingresar la cantidad minima");
                return false;
            }
            if (string.IsNullOrEmpty(txtPrecioCompra.Text))
            {
                MessageBox.Show("Debe ingresar el precio de compra");
                return false;
            }
            if (string.IsNullOrEmpty(txtPrecioVenta.Text))
            {
                MessageBox.Show("Debe ingresar el precio de venta");
                return false;
            }
            if (string.IsNullOrEmpty(cBoxCategorias.Text))
            {
                MessageBox.Show("Debe seleccionar una categoría");
                return false;
            }
            if (string.IsNullOrEmpty(cmbProveedor.Text))
            {
                MessageBox.Show("Debe seleccionar un proveedor");
                return false;
            }

            return true;
        }

        private void AgregarProducto()
        {
            var producto = new Producto
            {
                Codigo = txtCodigo.Text,
                Descripcion = txtDescripcion.Text,
                CantidadActual = Convert.ToInt32(txtCantidadActual.Text),
                CantidadMinima = Convert.ToInt32(txtCantidadMinima.Text),
                PrecioCompra = Convert.ToDecimal(txtPrecioCompra.Text),
                PrecioVenta = Convert.ToDecimal(txtPrecioVenta.Text),
                Categoria = (Categoria)cBoxCategorias.SelectedItem,
                Proveedor = (Proveedor)cmbProveedor.SelectedItem,
            };
            var ok = Controladora.ControladoraProductos.Instancia.AgregarProducto(producto);
            if (ok)
            {
                MessageBox.Show("Categoría agregada correctamente");
                Close();
            }
            else
            {
                MessageBox.Show("No se pudo agregar la categoría");
            }
        }

        private void ModificarProducto()
        {
            producto.Descripcion = txtDescripcion.Text;
            producto.PrecioCompra = Convert.ToDecimal(txtPrecioCompra.Text);
            producto.PrecioVenta = Convert.ToDecimal(txtPrecioVenta.Text);
            producto.CantidadActual = Convert.ToInt32(txtCantidadActual.Text);
            producto.CantidadMinima = Convert.ToInt32(txtCantidadMinima.Text);
            producto.Categoria = (Categoria)cBoxCategorias.SelectedItem;
            var ok = Controladora.ControladoraProductos.Instancia.ModificarProducto(producto);
            if (ok)
            {
                MessageBox.Show("Producto modificado correctamente");
                Close();
            }
            else
            {
                MessageBox.Show("No se pudo modificar el producto");
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // Allow digits only
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // Allow digits and a single decimal point
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Allow only one decimal point
            if (e.KeyChar == '.' && this.Text.Contains("."))
            {
                e.Handled = true;
            }
        }
    }
}
