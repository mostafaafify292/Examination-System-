using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02_TRUESolution
{
    public class MCQQuestion : Question ,ICloneable
    {
        public MCQQuestion() : base("MCQ-Question")
        {
            Console.WriteLine("The Choices of Question");
            Answers = new Answer[3];
            string _Answer;
            for (int i = 0; i < 3; i++)
            {
                do
                {
                    Console.WriteLine($"Please Enter The Choise Number {i + 1}:");
                    _Answer = Console.ReadLine();
                } while (string.IsNullOrWhiteSpace(_Answer) || string.IsNullOrEmpty(_Answer));
                Answers[i] = new Answer(i+1 , _Answer);
            }
                int RightIndex;

                do
                {
                    Console.WriteLine("Please Enter The Index of Right Question");
                } while (!int.TryParse(Console.ReadLine(), out RightIndex) || RightIndex <1 || RightIndex >3 );
                RightAnswerIndex = RightIndex - 1;
        }

        public MCQQuestion(string _Header , string _Body , int _Mark , Answer[] _Answers , int _RightIndex):base(_Header , _Body , _Mark)
        {
            Answers = (Answer[]) _Answers.Clone() ;
            RightAnswerIndex = _RightIndex;
        }

        public override object Clone()
        {
            return new MCQQuestion(Header , Body ,Mark , Answers , RightAnswerIndex);
        }

        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < 3; i++)
            {
                s += $"\n {i + 1} . {Answers[i].AnswerText}";
            }
            return base.ToString() +$"{s}";
        }
    }
}
