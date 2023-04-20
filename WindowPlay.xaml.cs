using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
    /// Логика взаимодействия для WindowPlay.xaml
    /// </summary>
    public partial class WindowPlay : Window
    {   
        //Объект класса
        QuestionDB QB = new QuestionDB();
 
        public WindowPlay()
        {
            WinQus = new WindowQuestion(this);
            InitializeComponent();
            QB.inizInitialize();
        }
        WindowQuestion WinQus;

        // Переменная и свойства количество игроков
        private int _colvoPlayer;
        public int ColvoPlayer
        {
            get { return _colvoPlayer; }
            set { _colvoPlayer = value; }
        }
        //Переменная и свойство текущегго игрока
        private int _currentPlyer = 1;
        public int CurrentPlyer
        {
            get { return _currentPlyer; }
            set { _currentPlyer = value; }
        }
        //переменная и свойство балов игроков
        
        private int _score;
        public int Score
        {   get { return _score; } 
            set { _score = value; } 
        }
        private int _player1;
        public int Player1
        {   get { return _player1; } 
            set { _player1 = value; } 
        }
        private int _player2;
        public int Player2
        {   get { return _player2; } 
            set { _player2 = value; } 
        }
        private int _player3;
        public int Player3 
        {
            get { return _player3; }
            set { _player3 = value; }
        }
        private int _player4;
        public int Player4
        {
            get { return _player4; }
            set { _player4 = value; }
        }

        //Метод вызывающий окно вопроса
        public void openQuest()
        {
            WindowQuestion WinQusLOCAL = new WindowQuestion(this);
            WinQusLOCAL.ShowDialog();

        }
        //Метод чередующий игроков
        public void SkipPleyer() 
        {
            if(CurrentPlyer<=ColvoPlayer)
            {
                CurrentPlyer++;
                if (CurrentPlyer>ColvoPlayer) 
                {
                    CurrentPlyer = 1;
                }
                current_player.Content = CurrentPlyer;
            }
        }
        public int namber;
        private void QuestionAAA()
        {
            WinQus.textBlockQuestion.Text = QB.QuestionList[namber].question.ToString();
            WinQus.textBlockAnswer.Text = QB.QuestionList[namber].answer.ToString();
            Score = QB.QuestionList[namber].Score;
        }
        
        //кнопки открывающие вопроос
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            namber = 0;
            b11.IsEnabled = false;
            QuestionAAA();
            openQuest();
        }

        private void b12_Click(object sender, RoutedEventArgs e)
        {
            namber = 1;
            b12.IsEnabled = false;
            QuestionAAA();
            openQuest();

        }

        private void b13_Click(object sender, RoutedEventArgs e)
        {
            namber = 2;
            b13.IsEnabled = false;
            QuestionAAA();
            openQuest();

        }

        private void b14_Click(object sender, RoutedEventArgs e)
        {
            namber = 3;
            b14.IsEnabled = false;
            QuestionAAA();
            openQuest();

        }

        private void b21_Click(object sender, RoutedEventArgs e)
        {
            namber = 4;
            b21.IsEnabled = false;
            QuestionAAA();
            openQuest();

        }

        private void b22_Click(object sender, RoutedEventArgs e)
        {
            namber = 5;
            b22.IsEnabled = false;
            QuestionAAA();
            openQuest();

        }

        private void b23_Click(object sender, RoutedEventArgs e)
        {
            namber = 6;
            b23.IsEnabled = false;
            QuestionAAA();
            openQuest();

        }

        private void b24_Click(object sender, RoutedEventArgs e)
        {
            namber = 7;
            b24.IsEnabled = false;
            QuestionAAA();
            openQuest();

        }

        private void b31_Click(object sender, RoutedEventArgs e)
        {
            namber = 8;
            b31.IsEnabled = false;
            QuestionAAA();
            openQuest();

        }

        private void b32_Click(object sender, RoutedEventArgs e)
        {
            namber = 9;
            b32.IsEnabled = false;
            QuestionAAA();
            openQuest();

        }

        private void b33_Click(object sender, RoutedEventArgs e)
        {
            namber = 10;
            b33.IsEnabled = false;
            QuestionAAA();
            openQuest();

        }

        private void b34_Click(object sender, RoutedEventArgs e)
        {
            namber =11;
            b34.IsEnabled = false;
            QuestionAAA();
            openQuest();

        }

        private void b41_Click(object sender, RoutedEventArgs e)
        {
            namber = 12;
            b41.IsEnabled = false;
            QuestionAAA();
            openQuest();

        }

        private void b42_Click(object sender, RoutedEventArgs e)
        {
            namber = 13;
            b42.IsEnabled = false;
            QuestionAAA();
            openQuest();

        }

        private void b43_Click(object sender, RoutedEventArgs e)
        {
            namber = 14;
            b43.IsEnabled = false;
            QuestionAAA();
            openQuest();

        }

        private void b44_Click(object sender, RoutedEventArgs e)
        {
            namber = 15;
            b44.IsEnabled = false;
            QuestionAAA();
            openQuest();

        }

        private void b51_Click(object sender, RoutedEventArgs e)
        {
            namber = 16;
            b51.IsEnabled = false;
            QuestionAAA();
            openQuest();

        }

        private void b52_Click(object sender, RoutedEventArgs e)
        {
            namber = 17;
            b52.IsEnabled = false;
            QuestionAAA();
            openQuest();

        }

        private void b53_Click(object sender, RoutedEventArgs e)
        {
            namber = 18;
            b53.IsEnabled = false;
            QuestionAAA();
            openQuest();

        }

        private void b54_Click(object sender, RoutedEventArgs e)
        {
            namber = 19;
            b54.IsEnabled = false;
            QuestionAAA();
            openQuest();

        }

        private void b61_Click(object sender, RoutedEventArgs e)
        {
            namber = 20;
            b61.IsEnabled = false;
            QuestionAAA();
            openQuest();

        }

        private void b62_Click(object sender, RoutedEventArgs e)
        {
            namber = 21;
            b62.IsEnabled = false;
            QuestionAAA();
            openQuest();

        }

        private void b63_Click(object sender, RoutedEventArgs e)
        {
            namber = 22;
            b63.IsEnabled = false;
            QuestionAAA();
            openQuest();

        }

        private void b64_Click(object sender, RoutedEventArgs e)
        {
            namber = 23;
            b64.IsEnabled = false;
            QuestionAAA();
            openQuest();

        }
    }
}
