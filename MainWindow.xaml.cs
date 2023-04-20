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

namespace AAA_PR_3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //объект класса
        WindowPlay WinPlay = new WindowPlay();
        public MainWindow()
        {
            InitializeComponent();
        }
        //Метод который открывает одно и закрывает другое
        private void OpenCloseWindow()
        {
            WinPlay.Show();
            this.Close();
        }
        //События в которых: 1) Присваивается занчения перменным 2) Вызвается метод 3) Выключаются lable счета
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WinPlay.ColvoPlayer = 1;
            WinPlay.colvo_player.Content = 1;
            OpenCloseWindow();

            WinPlay.NameLable2.IsEnabled= false;
            WinPlay.NameLable3.IsEnabled = false;
            WinPlay.NameLable4.IsEnabled = false;

            WinPlay.score_player2.IsEnabled = false;
            WinPlay.score_player3.IsEnabled = false;
            WinPlay.score_player4.IsEnabled= false;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            WinPlay.ColvoPlayer = 2;
            WinPlay.colvo_player.Content = 2;
            OpenCloseWindow();

            WinPlay.NameLable3.IsEnabled = false;
            WinPlay.NameLable4.IsEnabled = false;

            WinPlay.score_player3.IsEnabled = false;
            WinPlay.score_player4.IsEnabled = false;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            WinPlay.ColvoPlayer = 3;
            WinPlay.colvo_player.Content = 3;
            OpenCloseWindow();

            WinPlay.NameLable4.IsEnabled = false;

            WinPlay.score_player4.IsEnabled = false;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            WinPlay.ColvoPlayer = 4;
            WinPlay.colvo_player.Content = 4;
            OpenCloseWindow();
        }
    }
}
