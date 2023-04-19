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

namespace AAA_PR_3
{
    /// <summary>
    /// Логика взаимодействия для WindowQuestion.xaml
    /// </summary>
    public partial class WindowQuestion : Window
    {
        MainWindow MW = new MainWindow();
        public WindowQuestion()
        {
            InitializeComponent ();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            textBlockAnswer_Copy2.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#000061FF");

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //MW.
            this.Close();
        }
    }
}
