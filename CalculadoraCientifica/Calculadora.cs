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
        public long Resultado = 1;

        public Calculadora()
        {
            InitializeComponent();

            //Calculadora.ActiveForm == false;

            //if (String.IsNullOrWhiteSpace(txt_Display.Text))
            //{
            //    txt_Display.Text = "0";
            //}
            //Focused(null);
        }

        private void pbox_On_Click(object sender, EventArgs e)
        {
            txt_Display.Enabled = true;
            panel1.Enabled = true;
            panel2.Enabled = true;
            panel3.Enabled = true;
            txt_Display.Text = "0";
            pbox_Off.Visible = true;
            pbox_On.Visible = false;
        }

        private void pbox_Off_Click(object sender, EventArgs e)
        {
            txt_Display.Clear();
            txt_Display.Text = "Bye";
            //System.Threading.Thread.Sleep(2000);
            //txt_Display.Text = "";                
            panel1.Enabled = false;
            panel2.Enabled = false;
            panel3.Enabled = false;
            txt_Display.Enabled = false;
            pbox_Off.Visible = false;
            pbox_On.Visible = true;
            
        }

        //Detecta a través del evemto click que botoón es el que se presiona esto ya configurandolo desde 
        //la sección de eventos en propiedades, sin necesidad de crear código, pero usando los parametros que estos reciben 
        public void DetectarNumero(object sender, EventArgs e)
        {
            //txt_Display.Selection = txt_Display.Text.Length;

            //variable local que obtendra la información del evento del botón presionado
            var boton = (Button)sender;
            boton.FlatAppearance.BorderSize = 3;

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
                txt_Display.Text = Math.Pow(Numero1, 2).ToString("0,0.00");
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

        //Detecta si el puntero pasa a través del botón y cambia el color de este
        private void RatonEnter(object sender, EventArgs e)
        {
            var myboton = (Button)sender;
            myboton.BackColor = Color.Red;
        }

        //Detecta cuando el puntero sale del botón y regresa a su color anterior
        private void RatonLeave(object sender, EventArgs e)
        {
            var myboton2 = (Button)sender;
            myboton2.BackColor = Color.DimGray;
        }


        //Operaciones
        //Detecta ecuando el puntero pasa sobre un cuadro que representa una operación
        private void RatonE_Op(object sender, EventArgs e)
        {
            var myboton2 = (Button)sender;
            myboton2.FlatAppearance.BorderColor = Color.Black;            
            myboton2.FlatAppearance.BorderSize = 2;
            myboton2.ForeColor = Color.Black;
        }

        //Detecta cuando el puntero sale del botón y regresa a su color anterior
        private void RatonL_Op(object sender, EventArgs e)
        {
            var myboton2 = (Button)sender;
            myboton2.FlatAppearance.BorderColor = Color.White;
            myboton2.FlatAppearance.BorderSize = 1;
            myboton2.ForeColor = Color.White;
        }


        ////Detecta si el puntero pasa a través del botón y cambia el color de este
        //private void RatonE_Num(object sender, EventArgs e)
        //{
        //    var myboton = (Button)sender;
        //    myboton.FlatAppearance.BorderSize = 3;
        //}

        //Detecta cuando el puntero sale del botón y regresa a su color anterior
        private void RatonL_Num(object sender, EventArgs e)
        {
            var myboton2 = (Button)sender;
            myboton2.FlatAppearance.BorderSize = 2;
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
                        txt_Display.Text = (Numero1 + Numero2).ToString("0,0.00");}
                    else{}

                        Numero2 = 0;
                    break;

                case '-':
                    indice = txt_Display.Text.IndexOf(Operador);

                    if (indice >= 0)
                    {
                        Numero2 = Convert.ToDouble(txt_Display.Text.Substring(indice).TrimStart(Operador));
                        txt_Display.Text = (Numero1 - Numero2).ToString("0,0.00");
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
                        txt_Display.Text = (Numero1 * Numero2).ToString("0,0.00");
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
                        txt_Display.Text = (Numero1 / Numero2).ToString("0,0.00");
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

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            //si el txt esta vacio o contiene elementos en blanco se le asignara un texto definido
            if (String.IsNullOrWhiteSpace(txt_Display.Text))
            {
                //en caso de llegar a estar vacio se le asignara este texto
                txt_Display.Text = "0";
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
            //Clear all cambia el valor del txt a "0" y rstablece el valor de las demas variables 
            txt_Display.Text = "0";
            //variables globales
            Numero1 = 0;
            Numero2 = 0;
            Resultado = 1;
        }
    }
}
