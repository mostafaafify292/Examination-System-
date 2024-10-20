using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02_TRUESolution
{
    public abstract class Exam
    {
        public int TimeOfExam { get; set; }
        public int NumberOfQuestions { get; set; }
        public int Grade { get; set; }
        public int TotalMarks { get; set; }

        public Exam()
        {
            int _Time;
            do
            {
                Console.WriteLine(" Please Enter Time Of Exam");
                int.TryParse(Console.ReadLine(), out _Time);
            } while (_Time <= 0);
            TimeOfExam = _Time;
            int _NumberOfQuestion;
            do
            {
                Console.WriteLine(" Please Enter The Number Of Question You Want To Create ");
                int.TryParse(Console.ReadLine(), out _NumberOfQuestion);
            } while (_NumberOfQuestion <= 0);
            NumberOfQuestions = _NumberOfQuestion;
            Grade = 0;
            TotalMarks = 0;
        }
        public Exam(int timeOfExam , int numberOfQuestions)
        {
            TimeOfExam = timeOfExam;
            NumberOfQuestions = numberOfQuestions;
            Grade = 0;
            TotalMarks = 0;  
        }
        public abstract void ShowExam();

        public override string ToString()
        {
            return $"TimeOfExam: {TimeOfExam} , NumberOfQuestions: {NumberOfQuestions}";
        }
    }
}
