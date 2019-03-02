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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Calc_TextBox_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void Calc_TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter)
            {
                String number = "";
                Int16 Coefficient = 1;
                String S = Calc_TextBox.Text;
                for (Int32 i = 0; i < S.Length - 2; i++)
                {

                    if (S[i] == 'x')
                    {
                        if (S[i + 1] == '^' && S[i + 2] == '2')
                        {
                            calc.Aparemeter = Convert.ToInt64(number) * Coefficient;
                            i += 2;
                            number = "";
                        }
                        else
                        {
                            calc.Bparemeter = Convert.ToInt64(number) * Coefficient;
                            i++;
                            number = "";
                        }
                    }
                    else if (S[i] == '-')
                    {
                        if (number != "") calc.Cparemeter = Convert.ToInt64(number) * Coefficient;
                        Coefficient = -1;
                        number = "";
                    }
                    else if (S[i] == '+' && number != "")
                    {
                        if (number != "") calc.Cparemeter = Convert.ToInt64(number) * Coefficient;
                        Coefficient = 1;
                        number = "";
                    }
                    else number += S[i];
                }
                Console.WriteLine("A= " + calc.Aparemeter);
                Console.WriteLine("B= " + calc.Bparemeter);
                Console.WriteLine("C= " + calc.Cparemeter);
                calc.Calculate();
                Result_Label.Content = "x1= " + calc.answer1 + '\n' + "x2= " + calc.answer2;
            }
        }
    }
}
