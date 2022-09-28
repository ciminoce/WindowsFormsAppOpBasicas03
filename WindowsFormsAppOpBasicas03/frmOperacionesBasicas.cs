using System;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsAppOpBasicas03
{
    public partial class frmOperacionesBasicas : Form
    {
        public frmOperacionesBasicas()
        {
            InitializeComponent();
        }
        private int numero1;
        private int numero2;
        private void OkButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                StringBuilder sb = new StringBuilder();
                int suma = 0;
                int resta = 0;
                int producto = 0;
                int cociente = 0;
                if (sumarCheckBox.Checked)
                {
                    suma = CalcularSuma(numero1, numero2);
                    sb.AppendLine($"La suma es {suma}");
                }
                if (restarCheckBox.Checked)
                {
                    resta = CalcularResta(numero1, numero2);
                    sb.AppendLine($"La resta es {resta}");

                }
                if (multiplicarCheckBox.Checked)
                {
                    producto = CalcularProducto(numero1, numero2);
                    sb.AppendLine($"El producto es {producto}");
                }
                if (divisionCheckBox.Checked)
                {
                    cociente = CalcularDivision(numero1, numero2);
                    sb.AppendLine($"La división es {cociente}");
                }
                MessageBox.Show(sb.ToString(), "Resultados",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                InicializarControles();
            }
        }

        private int CalcularDivision(int numero1, int numero2)
        {
            if (numero2!=0)
            {
                return numero1 / numero2;
            }
            throw new DivideByZeroException("No se puede dividir por cero");
        }

        private int CalcularProducto(int numero1, int numero2) => numero1 * numero2;

        private int CalcularSuma(int numero1, int numero2) => numero1 + numero2;
        private int CalcularResta(int numero1, int numero2)
        {
            return numero1 - numero2;
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (!int.TryParse(numero1TextBox.Text, out numero1))
            {
                valido = false;
                errorProvider1.SetError(numero1TextBox, "Número mal ingresado");
            }
            if (!int.TryParse(numero2TextBox.Text, out numero2))
            {
                valido = false;
                errorProvider1.SetError(numero2TextBox, "Número mal ingresado");
            }
            if (!sumarCheckBox.Checked && !restarCheckBox.Checked 
                && !multiplicarCheckBox.Checked && !divisionCheckBox.Checked)
            {
                valido = false;
                errorProvider1.SetError(groupBox1, "Debe seleccionar al menos una operación");

            }
            return valido;
        }

        private void InicializarControles()
        {
            numero1TextBox.Clear();
            numero2TextBox.Clear();
            numero1TextBox.Focus();
            restarCheckBox.Checked = false;
            multiplicarCheckBox.Checked = false;
            divisionCheckBox.Checked = false;
            sumarCheckBox.Checked = true;
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            InicializarControles();
        }
    }
}
