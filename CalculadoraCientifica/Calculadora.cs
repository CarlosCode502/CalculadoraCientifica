using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraCientifica
{
    public partial class Calculadora : Form
    {
        public String temporal1;
        public String Resultado;

        public Double valor1;
        public Double valor2;

        public Calculadora()
        {
            InitializeComponent();

            if (String.IsNullOrWhiteSpace(txt_Display.Text))
            {
                txt_Display.Text = "0";
            }
        }

        //Función que detecta a través del evemto click que botoón es el que se presiona esto ya configurandolo desde 
        //la sección de eventos en propiedades, sin necesidad de crear código, pero usando los parametros que estos reciben 
        public void DetectarNumero(object sender, EventArgs e)
        {
            //variable local que obtendra la información del evento del botón presionado
            var boton = (Button)sender;            

            //condiciónal que valida si el contenedor coincide con la condición
            if (txt_Display.Text == "0")
            {
                //si es afirmativo se obtendra el valor que contiene el componente presionado
                txt_Display.Text += boton.Text;
                //txt_Display.Text = "0";
            }
            else
            {
                //si la condición no se cumple pasara a obtener el valor actual y concatenarle el valor
                //del botón presionado
                txt_Display.Text += boton.Text;
            }

            //string op = txt_Display.Text == "0" ? txt_Display.Text = boton.Text : txt_Display.Text += boton.Text;
        }        

        private void btn_Mas_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(txt_Display.Text) || txt_Display.Text == "0")
            {

            }
            else
            {
                if (valor1 == 0)
                {
                    valor1 = Convert.ToDouble(txt_Display.Text);
                    //txt_Display.Text = Convert.ToString(valor1 + " + " + valor2);
                    
                    txt_Display.Text += " + ";
                    //temporal1 = valor1.ToString();
                    //txt_Display.Text += " +";
                }
                else
                {
                    valor2 = Convert.ToDouble(txt_Display.Text);
                    //txt_Display.Text = Convert.ToString(valor2 + " + " + valor1);
                    txt_Display.Text += " + ";
                }
            }

            
            
        }

        private void btn_Menos_Click(object sender, EventArgs e)
        {
            txt_Display.Text += " -";

            
        }

        private void btn_Divi_Click(object sender, EventArgs e)
        {

        }

        private void btn_Multi_Click(object sender, EventArgs e)
        {

        }

        private void btn_Factorial_Click(object sender, EventArgs e)
        {

        }

        private void btn_potencia_Click(object sender, EventArgs e)
        {

        }

        private void btn_Igual_Click(object sender, EventArgs e)
        {
            if(valor1 == 0 && valor2 == 0)
            {

            }
            else
            {
                Resultado = Convert.ToString(valor1 + valor2);
                txt_Display.Text = Resultado;
            }

        }

        //Obtiene el texto del texbox y a traves de algunas validaciones elimina el último elemento 
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            //si el txt esta vacio o contiene elementos en blanco se le asignara un texto definido
            if (String.IsNullOrWhiteSpace(txt_Display.Text))
            {
                //en caso de llegar a estar vacio se le asignara este texto
                txt_Display.Text = "0";

                valor1 = 0;
                valor2 = 0;
            }
            else
            {
                //si no esta vacío o contienen solo espacios se ara lo siguie

                if (txt_Display.TextLength == 1)
                {
                    Char letra;
                    letra = Convert.ToChar(txt_Display.Text);

                    txt_Display.Text = txt_Display.Text.Replace(letra, '0');

                    valor1 = 0;
                    valor2 = 0;
                }
                else
                {
                    txt_Display.Text = txt_Display.Text.Remove(txt_Display.TextLength - 1);
                }
            }
        }

        private void btn_ClearALL_Click(object sender, EventArgs e)
        {
            //Clear all cabia los valores del txt a "0"
            txt_Display.Text = "0";
            valor1 = 0;
            valor2 = 0;
        }



        //METODO CLICK DE LOS BOTONES DESCARTADOS
        //private void btn_Cero_Click(object sender, EventArgs e)
        //{
        //    if(txt_Display.Text == "0")
        //    {
        //        txt_Display.Clear();
        //        txt_Display.Text = "0";
        //    }
        //    else
        //    {
        //        txt_Display.Text += "0";
        //    }
        //}

        //TODO ESTO HASTA N BOTÓN

    }
}
