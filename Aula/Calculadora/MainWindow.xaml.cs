using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculadora
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {

        double num1;
        double num2;
        double res;
        string op;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            txtCalculadora.Text = txtCalculadora.Text + "1";
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            txtCalculadora.Text = txtCalculadora.Text + "2";
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            txtCalculadora.Text = txtCalculadora.Text + "3";
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            txtCalculadora.Text = txtCalculadora.Text + "4";
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            txtCalculadora.Text = txtCalculadora.Text + "5";
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            txtCalculadora.Text = txtCalculadora.Text + "6";
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            txtCalculadora.Text = txtCalculadora.Text + "7";
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            txtCalculadora.Text = txtCalculadora.Text + "8";
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            txtCalculadora.Text = txtCalculadora.Text + "9";
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            txtCalculadora.Text = txtCalculadora.Text + "0";
        }

        private void btnvirgula_Click(object sender, RoutedEventArgs e)
        {
            txtCalculadora.Text = txtCalculadora.Text + ",";
        }

        private void btnCE_Click(object sender, RoutedEventArgs e)
        {
            txtCalculadora.Clear();
        }

        private void btnadicao_Click(object sender, RoutedEventArgs e)
        {
            op = "+";
            num1 = double.Parse(txtCalculadora.Text);
            txtCalculadora.Clear();
        }

        private void btnsubtracao_Click(object sender, RoutedEventArgs e)
        {
            op = "-";
            num1 = double.Parse(txtCalculadora.Text);
            txtCalculadora.Clear();
        }

        private void btnmultiplicacao_Click(object sender, RoutedEventArgs e)
        {
            op = "*";
            num1 = double.Parse(txtCalculadora.Text);
            txtCalculadora.Clear();
        }

        private void btndivisao_Click(object sender, RoutedEventArgs e)
        {
            op = "/";
            num1 = double.Parse(txtCalculadora.Text);
            txtCalculadora.Clear();
        }

        private void btnigual_Click(object sender, RoutedEventArgs e)
        {
            num2 = double.Parse(txtCalculadora.Text);

            switch (op)
            {
                case "+":
                    res = num1 + num2;
                    txtCalculadora.Text = res.ToString();
                    break;

                case "-":
                    res = num1 - num2;
                    txtCalculadora.Text = res.ToString();
                    break;

                case "*":
                    res = num1 * num2;
                    txtCalculadora.Text = res.ToString();
                    break;

                case "/":
                    res = num1 / num2;
                    txtCalculadora.Text = res.ToString();
                    break;
            }
        }

        private void btnRaiz_Click(object sender, RoutedEventArgs e)
        {
            op = "Raiz";
            num1 = double.Parse(txtCalculadora.Text);
            res = num1;
            txtCalculadora.Text = Math.Sqrt(num1).ToString();
        }
    }
}
