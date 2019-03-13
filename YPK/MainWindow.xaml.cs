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

namespace YPK
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Calculation calc = new Calculation();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calc_TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter)
            {
                Result_Label.Content = calc.Answer(Calc_TextBox.Text);
            }
        }

        private void Calc_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
