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
    public partial class FormCategoria : Form
    {
        private readonly Categoria categoria;
        private readonly bool modifica = false;
        public FormCategoria()
        {
            InitializeComponent();
        }
        
        public FormCategoria(Categoria categoria)
        {
            InitializeComponent();
            this.categoria = categoria;
            modifica = true;
        }

        private void FormCategoria_Load(object sender, EventArgs e)
        {
            if (categoria != null)
            {
                txtCodigo.Text = categoria.Codigo;
                txtCodigo.Enabled = false;
                txtDescripcion.Text = categoria.Descripcion;
               
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
                if(!modifica)
                {
                    AgregarCategoria();
                }
                else
                {
                    ModificarCategoria();
                }
            }    
        }

        private bool ValidarDatos()
        {
            if(string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Debe ingresar un código");
                return false;
            }
            return true;
        }
        
        private void AgregarCategoria()
        {
            var categoria = new Categoria
            {
                Codigo = txtCodigo.Text,
                Descripcion = txtDescripcion.Text
            };
            var ok = Controladora.ControladoraCategorias.Instancia.AgregarCategoria(categoria);
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
        
        private void ModificarCategoria()
        {
            categoria.Descripcion = txtDescripcion.Text;
            var ok = Controladora.ControladoraCategorias.Instancia.ModificarCategoria(categoria);
            if (ok)
            {
                MessageBox.Show("Categoría modificada correctamente");
                Close();
            }
            else
            {
                MessageBox.Show("No se pudo modificar la categoría");
            }
        }
    }
}
