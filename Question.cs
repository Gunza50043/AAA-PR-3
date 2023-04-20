using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA_PR_3
{
    internal class Question
    {
        private string _question;
        public string question 
        {
            get
            {
                return _question;
            }
            set
            {
                question = _question;
            }
        }

        private string _answer;
        public string answer 
        {
            get 
            {
                return _answer;
            }
            set 
            { 
                answer = _answer; 
            }
        }
        private int _score;
        public int Score
        {
            get
            {
                return _score;
            }
            set
            {
                Score = _score;
            }
        }
        // конструктор для списка
        public Question(string question, string answer, int score )
        {
            _question = question;
            _answer = answer;
            _score = score;
        }
    }
}
