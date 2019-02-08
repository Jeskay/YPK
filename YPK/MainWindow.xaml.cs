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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string Input = TextBox_Input.Text.Trim(' ');
            Int32 a, b, c;
            for (Int32 i = 0; i < Input.Length; i++)
            {
                if(Input[i] != 'x' && Input[i + 1] == '^' && Input[i + 2] == '2') a = Input.Split
            }
           if()
        }
    }
}
