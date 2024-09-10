using System.Reflection;

namespace Vista
{
    public partial class FrmCalculadora : Form
    {
        private Assembly assembly;
        
        public FrmCalculadora()
        {
            InitializeComponent();
        }
  
        private void frmCalculadora_Load(object sender, EventArgs e)
        {
            var userPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            //obtiene la ruta de la carpeta del usuario actual de windows (c:\Users\Navegador)
            var fullPath = @$"{userPath}\source\repos\DAS2024\Vista\Files\Assemblies.dll";
            //ruta completa donde se encuentra el ensamblado
            assembly = Assembly.LoadFile(fullPath);
            //cargamos el ensamblado en memoria

            if (assembly == null)
            {
                MessageBox.Show("No se pudo cargar el ensablado");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                Calcular();
            }
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNumero1.Text = string.Empty;
            txtNumero2.Text = string.Empty;
            this.txtNumero1.Focus();
        }

        private void Calcular()
        {
            var myType = assembly.GetTypes()[0];//devuelve el unico tipo (clase) que existe

            var method = myType.GetMethod("Sumar"); //obtiene la metadata del metodo Sumar del tipo Calculadora

            var myInstance = Activator.CreateInstance(myType); //crea un objeto del tipo calculadora y lo asigna a myInstance

            var value1 = Convert.ToDecimal(txtNumero1.Text); 
            var value2 = Convert.ToDecimal(txtNumero1.Text);

            var result = method.Invoke(myInstance, [value1, value2]); //a la metadata del metodo llama a invocarlo y pasa la propia instancia creada
                                                                      //ademas si hay parametros, luego devuelve el resultado
            MessageBox.Show($"El resultado es: {result}");
        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(txtNumero1.Text))
            {
                MessageBox.Show("Debe ingresar el primer número","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtNumero2.Text))
            {
                MessageBox.Show("Debe ingresar el segundo número", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
