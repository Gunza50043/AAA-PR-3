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
        public string question { get; set; }
        public string answer { get; set; }

        public Question(string question, string answer )
        {
            _question = question;
            _answer = answer;
        }
    }
}
