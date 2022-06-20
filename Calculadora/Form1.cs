using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {

        double Num1;
        double Num2;
        string operador;
        public Form1()
        {
            InitializeComponent();
        }
        Clases.ClsSuma obj = new Clases.ClsSuma();
        Clases.ClsResta obj2 = new Clases.ClsResta();
        Clases.ClsMult obj3 = new Clases.ClsMult();
        Clases.ClsDiv obj4 = new Clases.ClsDiv();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxbPantalla.Text = TxbPantalla.Text + "7";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            TxbPantalla.Text = TxbPantalla.Text + "9";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TxbPantalla.Text = TxbPantalla.Text + "5";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            TxbPantalla.Text = TxbPantalla.Text + "0";
        }

        private void BtnN1_Click(object sender, EventArgs e)
        {
            TxbPantalla.Text = TxbPantalla.Text + "1";
        }

        private void BtnN2_Click(object sender, EventArgs e)
        {
            TxbPantalla.Text = TxbPantalla.Text + "2";
        }

        private void BtnN3_Click(object sender, EventArgs e)
        {
            TxbPantalla.Text = TxbPantalla.Text + "3";
        }

        private void BtnN4_Click(object sender, EventArgs e)
        {
            TxbPantalla.Text = TxbPantalla.Text + "4";
        }

        private void BtnN6_Click(object sender, EventArgs e)
        {
            TxbPantalla.Text = TxbPantalla.Text + "6";
        }

        private void BtnN8_Click(object sender, EventArgs e)
        {
            TxbPantalla.Text = TxbPantalla.Text + "8";
        }

        private void BtnSuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            Num1 = double.Parse(TxbPantalla.Text);
            TxbPantalla.Clear();  
        }

        private void BtnResta_Click(object sender, EventArgs e)
        {
            operador = "-";
            Num1 = double.Parse(TxbPantalla.Text);
            TxbPantalla.Clear();
        }

        private void BtnMult_Click(object sender, EventArgs e)
        {
            operador = "*";
            Num1 = double.Parse(TxbPantalla.Text);
            TxbPantalla.Clear();
        }

        private void BtnDivision_Click(object sender, EventArgs e)
        {
            operador = "/";
            Num1 = double.Parse(TxbPantalla.Text);
            TxbPantalla.Clear();
        }

        private void BtnResultado_Click(object sender, EventArgs e)
        {
            Num2 = double.Parse(TxbPantalla.Text);
       
            double suma;
            double resta;
            double multi;
            double div;

            switch (operador)
            {
                case "+":
                    suma = obj.sumar((Num1) , (Num2));
                    TxbPantalla.Text = suma.ToString();
                    break;

                case "-":
                    resta = obj2.restar((Num1), (Num2));
                    TxbPantalla.Text = resta.ToString();
                    break;

                case "*":
                    multi = obj3.multiplicar((Num1), (Num2));
                    TxbPantalla.Text = multi.ToString();
                    break;
                case "/":
                    div = obj4.dividir((Num1), (Num2));
                    TxbPantalla.Text = div.ToString();
                    break;
            }

        }

        private void BtnPunto_Click(object sender, EventArgs e)
        {
            TxbPantalla.Text = TxbPantalla.Text + ",";
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            TxbPantalla.Clear();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            if (TxbPantalla.TextLength == 1)
            {
                TxbPantalla.Text = null;
            }
            else
            {
                if (TxbPantalla.TextLength == 0)
                {
                    TxbPantalla.Text = "";
                }
                else
                {
                    TxbPantalla.Text = TxbPantalla.Text.Substring(0, TxbPantalla.TextLength - 1);
                }
            }
        }
    }
}
