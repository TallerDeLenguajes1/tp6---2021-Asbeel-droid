using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP6
{
    public partial class FrmCalculadora : Form
    {
        Calculadora calculo = new Calculadora(0,0);
        char operador;
        int extraerDesdeAqui;

        public FrmCalculadora()
        {
            InitializeComponent();
        }
        // este metodo lo agrego en el evento de cada numero
        private void agregarNumero(object sender, EventArgs evento)
        {
            var btnNumero = (Button)sender;

            if(txtPantalla.Text == "0")
            {
                txtPantalla.Text = "";
            }
            txtPantalla.Text += btnNumero.Text;
        }

        private void agregarOperador(object sender, EventArgs e)
        {
            Regex controlOperador = new Regex(@"^-?\d+(\.\d+)?$");//no filtra para lo q se creo ;-;
            if (controlOperador.IsMatch(txtPantalla.Text))
            {
                extraerDesdeAqui = txtPantalla.Text.Length + 1 ;//Guardo hasta donde esta el primer numero

                var btnOperador = (Button)sender;
                calculo.Numero1 = Convert.ToSingle(txtPantalla.Text);//guardo el primer numero
                operador = Convert.ToChar(btnOperador.Text);
                txtPantalla.Text += btnOperador.Text;
            }


        }

        private void btnC_Click(object sender, EventArgs e)
        {
            calculo.Numero1 = 0;
            calculo.Numero2 = 0;
            operador = '\0';

            txtPantalla.Text = "0";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (!txtPantalla.Text.Contains(","))
            {
                txtPantalla.Text += ",";
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            String n2 = txtPantalla.Text;
            n2 = n2.Substring(extraerDesdeAqui); // Esta linea Extrae desde el primer numero 
            calculo.Numero2 = Convert.ToSingle(n2); // Luego tomamos el segundo mumero con el signo incluido  xq ToSingle se la re banca uwu
            MessageBox.Show("El numero 1 es:" + calculo.Numero1 + "EL numero 2 es:" + calculo.Numero2);
            switch (operador)
            {
                case '+':
                    txtPantalla.Text = calculo.Suma().ToString();
                    calculo.Numero1 = Convert.ToSingle(txtPantalla.Text);
                    break; 

                case '-':
                    calculo.Numero1 = calculo.Resta();
                    txtPantalla.Text = Convert.ToString(calculo.Numero1);
                    break;
                case '*':
                    calculo.Numero1 = calculo.Multiplicacion();
                    txtPantalla.Text = Convert.ToString(calculo.Numero1);
                    break;

                case '/':
                    if(calculo.Numero2 != 0)
                    {
                        calculo.Numero1 = calculo.Suma();
                        txtPantalla.Text = Convert.ToString(calculo.Numero1);
                    }
                    else
                    {
                        MessageBox.Show("No se puede dividir por cero!!");
                    }
            
                    break;
            }
        }
    }
}
