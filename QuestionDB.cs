using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA_PR_3
{
    internal class QuestionDB
    {

        internal List<Question> QuestionList { get; private set; }
        public void inizInitialize()
        {
            QuestionList = new List<Question>
            {
                new Question("Кто я "," я футбольный мячик",100),
                new Question("asd","вфыв",200),
                new Question("asd","вфыв",300),
                new Question("asd","вфыв",400),
                new Question("Кто я "," я футбольный мячик",100),
                new Question("asd","вфыв",200),
                new Question("asd","вфыв",300),
                new Question("asd","вфыв",400),
                new Question("Кто я "," я футбольный мячик",100),
                new Question("asd","вфыв",200),
                new Question("asd","вфыв",300),
                new Question("asd","вфыв",400),
                new Question("Кто я "," я футбольный мячик",100),
                new Question("asd","вфыв",200),
                new Question("asd","вфыв",300),
                new Question("asd","вфыв",400),
                new Question("Кто я "," я футбольный мячик",100),
                new Question("asd","вфыв",200),
                new Question("asd","вфыв",300),
                new Question("asd","вфыв",400),
                new Question("Кто я "," я футбольный мячик",100),
                new Question("asd","вфыв",200),
                new Question("asd","вфыв",300),
                new Question("asd","вфыв",400),
                new Question("Кто я "," я футбольный мячик",100),
                new Question("asd","вфыв",200),
                new Question("asd","вфыв",300),
                new Question("asd","вфыв",400),

            };
        }
        
        /*
        List<Question> QuestionList = new List<Question>()
        {
            new Question("Кто я "," я футбольный мячик"),
            new Question("asd","вфыв")
        };
        */

    }
}
