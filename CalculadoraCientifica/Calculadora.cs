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
        public Double Numero1;
        public Double Numero2;
        public Char Operador;
        public Char BuscarOperador;
        public long Resultado = 0;
        public int Resultado2;

        public Calculadora()
        {
            InitializeComponent();

            //if (String.IsNullOrWhiteSpace(txt_Display.Text))
            //{
            //    txt_Display.Text = "0";
            //}
        }

        //Función que detecta a través del evemto click que botoón es el que se presiona esto ya configurandolo desde 
        //la sección de eventos en propiedades, sin necesidad de crear código, pero usando los parametros que estos reciben 
        public void DetectarNumero(object sender, EventArgs e)
        {
            //txt_Display.Selection = txt_Display.Text.Length;

            //variable local que obtendra la información del evento del botón presionado
            var boton = (Button)sender;            

            //condiciónal que valida si el contenedor coincide con la condición
            if (txt_Display.Text == "0")
            {
                //si es afirmativo se obtendra el valor que contiene el componente presionado
                txt_Display.Text = boton.Text;

                
                //txt_Display.Text = "0";
            }
            else
            {
                //si la condición no se cumple pasara a obtener el valor actual y concatenarle el valor del btn presionado
                txt_Display.Text += boton.Text;
            }
        }        

        public void DetectarOperacion(object sender, EventArgs e)
        {
            var boton = (Button)sender;
            Numero1 = 0;
            Numero1 = Convert.ToDouble(txt_Display.Text);
            Operador = Convert.ToChar(boton.Tag);

            //Al ingresar numero y operador borra lo que se encuentra dentro del
            //txt para permitir la entrada del siguiente numero
            //txt_Display.Text = "0";

            txt_Display.Text = Numero1.ToString() + Operador;

            if (Operador == '²')
            {
                txt_Display.Text = Math.Pow(Numero1, 2).ToString();
            }
            else if (Operador == '!')
            {
                //FORMULA DE FACTORIAL 
                //5! = 120 
                //5*4*3*2*1

                //obtener el numero a sacar factorial
                byte num = Convert.ToByte(Numero1);                

                //sacar factorial con for
                for (int i = 2; i <= num; i++)
                {
                    Resultado = Resultado * i;
                }

                //mostrar resultado de factorial
                txt_Display.Text = Resultado.ToString();                
            }
        }

        private void btn_Igual_Click(object sender, EventArgs e)
        {
            //Numero2 = Convert.ToDouble(txt_Display.Text);
            int indice = 0;

            switch (Operador)
            {
                case '+':
                    //obtener la posición de un caracter
                    indice = txt_Display.Text.IndexOf(Operador);

                    if(indice >= 0){
                        Numero2 = Convert.ToDouble(txt_Display.Text.Substring(indice));
                        txt_Display.Text = (Numero1 + Numero2).ToString();}
                    else{}

                        Numero2 = 0;
                    break;

                case '-':
                    indice = txt_Display.Text.IndexOf(Operador);

                    if (indice >= 0)
                    {
                        Numero2 = Convert.ToDouble(txt_Display.Text.Substring(indice).TrimStart(Operador));
                        txt_Display.Text = (Numero1 - Numero2).ToString();
                    }
                    else { }

                        Numero2 = 0;
                    break;

                case '*':
                    indice = txt_Display.Text.IndexOf(Operador);

                    if (indice >= 0)
                    {       
                        String valor = txt_Display.Text.Substring(indice);
                        Numero2 = Convert.ToDouble(txt_Display.Text.Substring(indice).TrimStart(Operador));
                        txt_Display.Text = (Numero1 * Numero2).ToString();
                    }
                    else { }

                        Numero2 = 0;
                    break;

                case '/':
                    indice = txt_Display.Text.IndexOf(Operador);

                    if (indice >= 0)
                    {
                        String valor = txt_Display.Text.Substring(indice);
                        Numero2 = Convert.ToDouble(txt_Display.Text.Substring(indice).TrimStart(Operador));
                        txt_Display.Text = (Numero1 / Numero2).ToString();
                    }
                    else { }

                    Numero2 = 0;
                    
                    break;

                default:
                    break;
            }
        }

        //private void btn_Mas_Click(object sender, EventArgs e)
        //{


        //    //if(String.IsNullOrWhiteSpace(txt_Display.Text) || txt_Display.Text == "0")
        //    //{

        //    //}
        //    //else
        //    //{
        //    //    if (valor1 == 0)
        //    //    {
        //    //        valor1 = Convert.ToDouble(txt_Display.Text);
        //    //        //txt_Display.Text = Convert.ToString(valor1 + " + " + valor2);

        //    //        //txt_Display.Text += "+";
        //    //        //temporal1 = valor1.ToString();
        //    //        //txt_Display.Text += " +";
        //    //    }
        //    //    else
        //    //    {
        //    //        valor2 = Convert.ToDouble(txt_Display.Text);
        //    //        txt_Display.Text += valor2.ToString();
        //    //        //txt_Display.Text = Convert.ToString(valor2 + " + " + valor1);
        //    //        //txt_Display.Text += "+";
        //    //    }
        //    //}



        //}


        //private void btn_Igual_Click(object sender, EventArgs e)
        //{
        //    if(valor1 == 0 && valor2 == 0)
        //    {

        //    }
        //    else
        //    {
        //        Resultado = Convert.ToString(valor1 + valor2);
        //        txt_Display.Text = Resultado;
        //    }

        //}

        //Obtiene el texto del texbox y a traves de algunas validaciones elimina el último elemento 

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            //si el txt esta vacio o contiene elementos en blanco se le asignara un texto definido
            if (String.IsNullOrWhiteSpace(txt_Display.Text))
            {
                //en caso de llegar a estar vacio se le asignara este texto
                txt_Display.Text = "0";

                //valor1 = 0;
                //valor2 = 0;
            }
            else
            {
                //si no esta vacío o contienen solo espacios se ara lo siguie

                if (txt_Display.TextLength == 1)
                {
                    Char letra;
                    letra = Convert.ToChar(txt_Display.Text);

                    txt_Display.Text = txt_Display.Text.Replace(letra, '0');

                }
                else
                {
                    txt_Display.Text = txt_Display.Text.Remove(txt_Display.TextLength - 1);
                }
            }
        }

        private void btn_ClearALL_Click(object sender, EventArgs e)
        {
            //Clear all cambia los valores del txt a "0"
            txt_Display.Text = "0";
            Numero1 = 0;
            Numero2 = 0;
        }
    }
}
