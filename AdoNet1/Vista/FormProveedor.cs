using Controladora;
using Modelo_V2.Objetos;

namespace Vista
{
    public partial class FormProveedor : Form
    {
        private readonly Proveedor proveedor;
        private readonly bool modifica = false;
        public FormProveedor()
        {
            InitializeComponent();
        }


        public FormProveedor(Proveedor proveedor)
        {
            InitializeComponent();
            this.proveedor = proveedor;
            modifica = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!modifica)
            {
                var proveedor = ValidarYCrear();
                if (proveedor != null)
                {
                    if (ControladoraProveedor.Instance.AgregarProveedor(proveedor))
                    {
                        lblLeyenda.Text = "Proveedor cargado con éxito";
                    }
                    else
                    {
                        lblLeyenda.Text = "null";
                    }

                }
                else
                {
                    lblLeyenda.Text = "Debe llenar todos los campos!";
                }
                lblLeyenda.Visible = true;
            }
            else
            {
                var proveedor = ValidarYCrear();
                if (proveedor != null)
                {
                    if (ControladoraProveedor.Instance.ModificarProveedor(proveedor))
                    {
                        lblLeyenda.Text = "Proveedor modificado con éxito";
                    }
                    else
                    {
                        lblLeyenda.Text = "null";
                    }
                }
                else
                {
                    lblLeyenda.Text = "Debe llenar todos los campos!";
                }
                lblLeyenda.Visible = true;
            }            
        }

        private Proveedor ValidarYCrear()
        {
            if(proveedor  == null)
            {
                if (txtCuit.Text != "" && txtRazonSocial.Text != "" && txtTelefono.Text != "" && txtDireccion.Text != "")
                {
                    Proveedor proveedor = new Proveedor()
                    {
                        Cuit = int.Parse(txtCuit.Text),
                        RazonSocial = txtRazonSocial.Text,
                        Telefono = int.Parse(txtTelefono.Text),
                        Direccion = txtDireccion.Text,
                    };
                    return proveedor;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                if (txtRazonSocial.Text != "" && txtTelefono.Text != "" && txtDireccion.Text != "")
                {
                    Proveedor proveedor = new Proveedor()
                    {
                        RazonSocial = txtRazonSocial.Text,
                        Telefono = int.Parse(txtTelefono.Text),
                        Direccion = txtDireccion.Text,
                    };
                    return proveedor;
                }
                else
                {
                    return null;
                }
            }
            
        }

        private void FormProveedor_Load(object sender, EventArgs e)
        {
            if(proveedor != null)
            {
                txtCuit.Enabled = false;
                txtRazonSocial.Text = proveedor.RazonSocial;
                txtTelefono.Text = proveedor.Telefono.ToString();
                txtDireccion.Text = proveedor.Direccion;
            }
        }
    }
}
