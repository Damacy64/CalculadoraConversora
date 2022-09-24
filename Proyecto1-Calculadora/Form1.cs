using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConversionDinero;
using ConversionGrados;
namespace Proyecto1_Calculadora
{
    public partial class CalculadoraProgramador : Form
    {
        // Instancias (Creando Objetos)
        OperadorBasicoSuma.ClaseSuma operadorUno = new OperadorBasicoSuma.ClaseSuma();
        OperadorBasicoResta.ClaseResta operadorDos = new OperadorBasicoResta.ClaseResta();
        OperadorBasicoMultiplicacion.ClaseMultiplicacion operadorTres = new OperadorBasicoMultiplicacion.ClaseMultiplicacion();
        OperadorBasicoDivision.ClaseDivision operadorCuatro = new OperadorBasicoDivision.ClaseDivision();
        ConversionBinaria.ConversionBinaria bin = new ConversionBinaria.ConversionBinaria();
        ConversionOctal.ConversionOctal oct = new ConversionOctal.ConversionOctal();
        ConversionHexadecimal.ConversionHexadecimal hex = new ConversionHexadecimal.ConversionHexadecimal();
        ConversionExcesoTres.ConversionExceso3 exeso = new ConversionExcesoTres.ConversionExceso3();
        ConversionGray.ConversionGray gray = new ConversionGray.ConversionGray();
        ConversionDinero.ConversionDinero conversor = new ConversionDinero.ConversionDinero();
        ConversionGrados.ConversionGrados convertir = new ConversionGrados.ConversionGrados();
        // Variables Publicas
        double mecanismoUno, mecanismoDos;
        String operador;

        public CalculadoraProgramador()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {}

        private void label4_Click(object sender, EventArgs e)
        {}

        private void label5_Click(object sender, EventArgs e)
        {}

        // Boton 0
        private void btnN0_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "0";
        }
        
        // Boton 1
        private void btnN1_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "1";
        }
        
        // Boton 2
        private void btnN2_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "2";
        }

        // Boton 3
        private void btnN3_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "3";
        }

        // Boton 4
        private void btnN4_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "4";
        }

        // Boton 5
        private void btnN5_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "5";
        }

        // Boton 6
        private void btnN6_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "6";
        }

        // Boton 7
        private void btnN7_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "7";
        }

        // Boton 8
        private void btnN8_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "8";
        }

        // Boton +
        private void btnSuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            mecanismoUno = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        // Boton -
        private void btnResta_Click(object sender, EventArgs e)
        {
            operador = "-";
            mecanismoUno = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        // Boton x
        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            operador = "*";
            mecanismoUno = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        // Boton /
        private void btnDivision_Click(object sender, EventArgs e)
        {
            operador = "/";
            mecanismoUno = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        // Boton $
        private void btnDinero_Click(object sender, EventArgs e)
        {
            double dinero = conversor.ToDolar(int.Parse(pantalla.Text));
            pantallaDolar.Text = dinero.ToString();
            pantallaPeso.Text = pantalla.Text;
            dinero = conversor.ToEuro(int.Parse(pantalla.Text));
            pantallaEuro.Text = dinero.ToString();
            dinero = conversor.ToSoles(int.Parse(pantalla.Text));
            pantallaSoles.Text = dinero.ToString();
            dinero = conversor.ToLibras(int.Parse(pantalla.Text));
            pantallaLibras.Text = dinero.ToString();
        }

        // Boton °
        private void btnGrados_Click(object sender, EventArgs e)
        {
            double grado = convertir.CelsiusToFahrenheit(double.Parse(pantalla.Text));
            pantallaFahrenheit.Text = grado.ToString();
            pantallaCelsius.Text = pantalla.Text;
            grado = convertir.CelsiusToKelvin(double.Parse(pantalla.Text));
            pantallaKelvin.Text = grado.ToString();
        }
        // Boton =
        private void btnIgual_Click(object sender, EventArgs e)
        {
            mecanismoDos = double.Parse(pantalla.Text);
            double suma, resta, multiplicacion, division, nulo;
            switch (operador)
            {
                case "+":
                    suma = operadorUno.suma((mecanismoUno), (mecanismoDos));
                    pantalla.Text = suma.ToString();
                    conversiones(Convert.ToInt32(suma));
                    break;

                case "-":
                    resta = operadorDos.resta((mecanismoUno), (mecanismoDos));
                    pantalla.Text = resta.ToString();
                    conversiones(Convert.ToInt32(resta));
                    break;

                case "*":
                    multiplicacion = operadorTres.multiplicacion((mecanismoUno), (mecanismoDos));
                    pantalla.Text = multiplicacion.ToString();
                    conversiones(Convert.ToInt32(multiplicacion));
                    break;

                case "/":
                    division = operadorCuatro.division((mecanismoUno), (mecanismoDos));
                    pantalla.Text = division.ToString();
                    conversiones(Convert.ToInt32(division));
                    break;
                default:
                    nulo = Convert.ToDouble(pantalla.Text);
                    conversiones(Convert.ToInt32(nulo));
                    break;

            }
        }

        // Boton CE
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            mecanismoUno = 0;
            mecanismoDos = 0;
            pantalla.Clear();
            pantallaBin.Clear();
            pantallaOct.Clear();
            pantallaHex.Clear();
            pantallaExeso.Clear();
            pantallaGray.Clear();
            pantallaPeso.Clear();
            pantallaDolar.Clear();
            pantallaEuro.Clear();
            pantallaLibras.Clear();
            pantallaSoles.Clear();
            pantallaCelsius.Clear();
            pantallaFahrenheit.Clear();
            pantallaKelvin.Clear();
        }

        // Boton ←
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (pantalla.Text.Length == 1)
            {
                pantalla.Text = "";
            }
            else
            {
                pantalla.Text = pantalla.Text.Substring(0, pantalla.Text.Length - 1);
            }
        }

        private void pantallaBin_TextChanged(object sender, EventArgs e)
        {}

        // Metodo Que Realiza Las Conversiones
        public void conversiones(int numero)
        {
            // Conversion De Decimal A Binario
            int binario = Convert.ToInt32(pantalla.Text);
            long conversion1 = bin.binario(binario);
            pantallaBin.Text = Convert.ToString(conversion1);

            // Conversion De Decimal A Octal
            int octal = Convert.ToInt32(pantalla.Text);
            long conversion2 = oct.octal(octal);
            pantallaOct.Text = Convert.ToString(conversion2);

            // Conversion De Decimal A Hexadecimal
            int hexadecimal = Convert.ToInt32(pantalla.Text);
            String conversion3 = hex.hexadecimal(hexadecimal);
            pantallaHex.Text = conversion3;
            // Conversion De Decimal A Exeso
            int excesoTres = Convert.ToInt32(pantalla.Text);
            String conversion4 = exeso.excesoTres(excesoTres);
            pantallaExeso.Text = conversion4;
            // Conversion De Binario A Gray
            String binario2 = pantallaBin.Text;
            String conversion5 = gray.gray(binario2);
            pantallaGray.Text = conversion5;
            // Conversion peso a peso
            String peso = pantalla.Text;
        }

        private void label12_Click(object sender, EventArgs e)
        {}

        // Boton 9
        private void btnN9_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "9";
        }
    }
}
