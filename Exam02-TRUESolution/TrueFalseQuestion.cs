using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02_TRUESolution
{
    public class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion():base("True || False Question")
        {
            Answers = new Answer[]
            {
                new Answer(1 , "True" ),
                new Answer(2 , "False" )
            };
            int _Answer;
            do
            {
                Console.WriteLine("Please Enter The Right Answer Of Question (1 For True || 2 For False)");
                int.TryParse(Console.ReadLine(), out _Answer);
            } while (_Answer != 1 &&_Answer != 2 );
            RightAnswerIndex = _Answer - 1;
        }
        public TrueFalseQuestion(string _Header , string _Body , int _Mark , int _RightAnswer):base(_Header , _Body , _Mark)
        {
            Answers = new Answer[]
            {
                new Answer(1 , "True" ),
                new Answer(2 , "False" )
            };
            RightAnswerIndex = _RightAnswer - 1;
        }


        public override string ToString()
        {
            return base.ToString() + $"\n 1.True \n 2.False";
        }
        public override object Clone()
        {
           return new TrueFalseQuestion(Header , Body , Mark , RightAnswerIndex);
        }
    }
}
