using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculadora_IMC
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            bool isAlturaEmpty = string.IsNullOrEmpty(Altura.Text);
            bool isPesoEmpty = string.IsNullOrEmpty(Peso.Text);
            if (!isAlturaEmpty && !isPesoEmpty)
            {
                double altura = Double.Parse(Altura.Text);
                double peso = Double.Parse(Peso.Text);
                double imc = peso / (altura * altura);
                IMC.Text = imc.ToString();
                string resultado = "";

                if (imc < 18.5)
                {
                    resultado = "Tienes bajo peso";
                }
                else if (imc >= 18.5 && imc <= 24.9)
                {
                    resultado = "Tienes un peso normal";
                }
                else if (imc >= 25 && imc <= 29.9) {
                    resultado = "Tienes sobrepeso";
                }
                else
                {
                    resultado = "Tienes obesidad ¡Cuidate!";
                }

                DisplayAlert("Resultado", resultado, "Aceptar");
            }
            else
            {
                string datos = "Rellena los datos de " + ((isAlturaEmpty) ? "altura" : "peso");
                DisplayAlert("Error en los datos", datos, "OK");
            }

        }
    }
}