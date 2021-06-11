using System;
using System.Windows.Forms;
using Calculatrice;

namespace WinFormCalculatrice
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var number1 = int.Parse(number.Text);
            var Number2 = int.Parse(number2.Text);

            result.Text= calculeBasic.Addition(number1,Number2).ToString();
        }

        private void number_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var number1 = int.Parse(number.Text);
            var Number2 = int.Parse(number2.Text);

            result.Text = calculeBasic.Substract(number1, Number2).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var number1 = int.Parse(number.Text);
            var Number2 = int.Parse(number2.Text);

            result.Text = calculeBasic.Multiply(number1, Number2).ToString();
        }
    }
}
