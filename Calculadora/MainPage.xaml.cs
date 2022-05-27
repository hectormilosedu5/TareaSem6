using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculadora
{
    public partial class MainPage : ContentPage
    {
        private double numero1 = 0;
        private double numero2 = 0;
        private string operacion = "";

        public MainPage()
        {
            InitializeComponent();

        }


        void ClicAc(System.Object sender, System.EventArgs e) 
        {
            Resultados.Text = "";
        }

        void ClicBotonMIn(System.Object sender, System.EventArgs e)
        {
            string str = Resultados.Text;
            numero1 = Double.Parse(str);
            operacion = "<";
            Resultados.Text = "";

        }

        void ClicBotonMax(System.Object sender, System.EventArgs e)
        {
            string str = Resultados.Text;
            numero1 = Double.Parse(str);
            operacion = ">";
            Resultados.Text = "";

        }
        void ClicBoton7(System.Object sender, System.EventArgs e)
        {
            string str = Resultados.Text;
            if (str == "0") {
                str = "7";
            }
            else
            {
                str += "7";
            }
            Resultados.Text = str;
        }

        void ClicBoton8(System.Object sender, System.EventArgs e)
        {
            string str = Resultados.Text;
            if (str == "0")
            {
                str = "8";
            }
            else
            {
                str += "8";
            }
            Resultados.Text = str;
        }

        void ClicBoton9(System.Object sender, System.EventArgs e)
        {
            string str = Resultados.Text;
            if (str == "0")
            {
                str = "9";
            }
            else
            {
                str += "9";
            }
            Resultados.Text = str;
        }

        void ClicBoton1(System.Object sender, System.EventArgs e)
        {
            string str = Resultados.Text;
            if (str == "0")
            {
                str = "1";
            }
            else
            {
                str += "1";
            }
            Resultados.Text = str;
        }

        void ClicBoton2(System.Object sender, System.EventArgs e)
        {
            string str = Resultados.Text;
            if (str == "0")
            {
                str = "2";
            }
            else
            {
                str += "2";
            }
            Resultados.Text = str;
        }

        void ClicBoton3(System.Object sender, System.EventArgs e)
        {
            string str = Resultados.Text;
            if (str == "0")
            {
                str = "3";
            }
            else
            {
                str += "3";
            }
            Resultados.Text = str;
        }

        void ClicBoton4(System.Object sender, System.EventArgs e)
        {
            string str = Resultados.Text;
            if (str == "0")
            {
                str = "4";
            }
            else
            {
                str += "4";
            }
            Resultados.Text = str;
        }

        void ClicBoton5(System.Object sender, System.EventArgs e)
        {
            string str = Resultados.Text;
            if (str == "0")
            {
                str = "5";
            }
            else
            {
                str += "5";
            }
            Resultados.Text = str;
        }

        void ClicBoton6(System.Object sender, System.EventArgs e)
        {
            string str = Resultados.Text;
            if (str == "0")
            {
                str = "6";
            }
            else
            {
                str += "6";
            }
            Resultados.Text = str;
        }

        void ClicBoton0(System.Object sender, System.EventArgs e)
        {
            string str = Resultados.Text;
            if (str == "0")
            {
                str = "0";
            }
            else
            {
                str += "0";
            }
            Resultados.Text = str;
        }

        void ClicBotonPunto(System.Object sender, System.EventArgs e)
        {
            string str = Resultados.Text;
            if (str == "0")
            {
                str = ".";
            }
            else
            {
                str += ".";
            }
            Resultados.Text = str;
        }
        void ClicBotonMas(System.Object sender, System.EventArgs e)
        {
            string str = Resultados.Text;
            numero1 = Double.Parse(str);
            operacion = "+";
            Resultados.Text="";

        }


        void ClicBotonMenos(System.Object sender, System.EventArgs e)
        {
            string str = Resultados.Text;
            numero1 = Double.Parse(str);
            operacion = "-";
            Resultados.Text = "";

        }

        void ClicBotonDiv(System.Object sender, System.EventArgs e)
        {
            string str = Resultados.Text;
            numero1 = Double.Parse(str);
            operacion = "/";
            Resultados.Text = "";

        }

        void ClicBotonMult(System.Object sender, System.EventArgs e)
        {
            string str = Resultados.Text;
            numero1 = Double.Parse(str);
            operacion = "*";
            Resultados.Text = "";

        }

        void ClicBotonIgual(System.Object sender, System.EventArgs e)
        {
            string str = Resultados.Text;
            numero2 = Double.Parse(str);
            double resultcalculo=0;

            switch (operacion) {

                case "+":
                    resultcalculo = numero1 + numero2;
                    break;
                case "-":
                    resultcalculo = numero1 - numero2;
                    break;
                case "*":
                    resultcalculo = numero1 * numero2;
                    break;
                case "/":
                    resultcalculo = numero1 / numero2;
                    break;
                case "<":
                    if (numero1 < numero2)
                    {
                        resultcalculo = numero1;
                    }
                    else
                    {
                        resultcalculo = numero2;
                    }
                    
                    break;
                case ">":
                    if (numero1 > numero2)
                    {
                        resultcalculo = numero1;
                    }
                    else
                    {
                        resultcalculo = numero2;
                    }
                    break;
                default:
                    break;

            }

            Resultados.Text = resultcalculo.ToString();


        }

    }
}
