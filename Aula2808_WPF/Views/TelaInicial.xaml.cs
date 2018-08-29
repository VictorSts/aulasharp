using Aula2808_WPF.Views;
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
using System.Windows.Shapes;

namespace Aula2808_WPF.View
{
    /// <summary>
    /// Lógica interna para TelaInicial.xaml
    /// </summary>
    public partial class TelaInicial : Window
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void btnCarregarTelaA_Click(object sender, RoutedEventArgs e)
        {
            TelaA minhaTelaTelaA = new TelaA();
            minhaTelaTelaA.Show();
        }

        private void btnCarregarTelaB_Click(object sender, RoutedEventArgs e)
        {
            TelaB minhaTelaTelaB = new TelaB();
            minhaTelaTelaB.ShowDialog();
        }
    }
}
