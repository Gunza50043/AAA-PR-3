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
    /// Логика взаимодействия для WindowPlay.xaml
    /// </summary>
    public partial class WindowPlay : Window
    {
        WindowQuestion WinQust = new WindowQuestion();
        MainWindow MWin = new MainWindow();
        QuestionDB QB = new QuestionDB();
        

        public WindowPlay()
        {
            InitializeComponent();
            QB.inizInitialize();
        }
        public void openQuest()
        {
            WinQust.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            WinQust.textBlockQuestion.Text = QB.QuestionList[0].question;
            WinQust.textBlockAnswer.Text = QB.QuestionList[0].answer.ToString();
            openQuest();
        }
    }
}
