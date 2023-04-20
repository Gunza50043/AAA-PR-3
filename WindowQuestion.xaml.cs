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
        WindowPlay WinPlay;
        public WindowQuestion(WindowPlay winPlay)
        {
            InitializeComponent ();
            WinPlay = winPlay;
        }
        
        //Кнопка открывающая ответ на вопрос
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            textBlockAnswer_Copy2.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#000061FF");

        }
        //кнопка правильного ответа которая засчитывает балы в зависимости от текущего игрока
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (WinPlay.CurrentPlyer == 1)
            {
                WinPlay.Player1 += WinPlay.Score;
                WinPlay.score_player1.Content = WinPlay.Player1;
            }
            if (WinPlay.CurrentPlyer == 2)
            {
                WinPlay.Player2 += WinPlay.Score;
                WinPlay.score_player2.Content = WinPlay.Player2;
            }
            if (WinPlay.CurrentPlyer == 3)
            {
                WinPlay.Player3 += WinPlay.Score;
                WinPlay.score_player3.Content = WinPlay.Player3;
            }
            if (WinPlay.CurrentPlyer == 4)
            {
                WinPlay.Player4 += WinPlay.Score;
                WinPlay.score_player4.Content = WinPlay.Player4;
            }
            WinPlay.SkipPleyer();
            this.Close();
        }
        //кнопка неправильного ответа которая просто пропускает игрока
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            WinPlay.SkipPleyer();
            this.Close();
        }
    }
}
