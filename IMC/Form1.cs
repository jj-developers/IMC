using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float peso, altura;
            float imc = 0;

            // Suponiendo que txt_peso y txt_talla son controles TextBox donde los usuarios ingresan peso y altura en metros
            if (float.TryParse(txt_peso.Text, out peso) && float.TryParse(txt_talla.Text, out altura))
            {
                imc = peso / (altura * altura);
                imc = (float)Math.Round(imc, 2); // Redondea el IMC a dos decimales
                txt_imc.Text = imc.ToString();
                diagnostico.Text = obtenerDiagnostico(imc);
            }


        }

        private string obtenerDiagnostico(float imc)
        {
            string diagnostico;

            switch (imc)
            {
                case float _ when imc < 18.5:
                    diagnostico = "Bajo peso";
                    break;
                case float _ when imc < 24.9:
                    diagnostico = "Peso normal";
                    break;
                case float _ when imc < 29.9:
                    diagnostico = "Sobrepeso";
                    break;
                case float _ when imc < 34.9:
                    diagnostico = "Obesidad tipo I (Moderada)";
                    break;
                case float _ when imc < 39.9:
                    diagnostico = "Obesidad tipo II (Severa)";
                    break;
                default:
                    diagnostico = "Obesidad tipo III (Muy severa o mórbida)";
                    break;
            }

            return diagnostico;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_imc.Text = "";
            txt_peso.Text = "";
            txt_talla.Text = "";
            diagnostico.Text = "";
        }

        private void txt_talla_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}