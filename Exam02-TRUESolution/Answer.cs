using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02_TRUESolution
{
    public class Answer : ICloneable
    {
        public int AnswerID { get; set; }
        public string AnswerText { get; set; }

        public Answer(int _AnswerID , string _AnswerText)
        { 
            AnswerID = _AnswerID;
            AnswerText = _AnswerText;
        }
        public Answer(Answer answer)
        {
            answer.AnswerID = AnswerID;
            answer.AnswerText = AnswerText;
        }

        public object Clone()
        {
            return new Answer(this);
        }

        public override string ToString()
        {
            return $"Answer ID : {AnswerID} , AnswerText : {AnswerText}";
        }
    }
}
