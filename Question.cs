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
        private string _answer;
        private int _bal;
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
        public int bal
        {
            get
            {
                return _bal;
            }
            set
            {
                bal = _bal;
            }
        }


        public Question(string question, string answer, int bal )
        {
            _question = question;
            _answer = answer;
            _bal = bal;
        }
    }
}
