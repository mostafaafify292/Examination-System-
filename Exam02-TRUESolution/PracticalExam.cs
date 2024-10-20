using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02_TRUESolution
{
    public class PracticalExam :Exam
    {
        public MCQQuestion[] MCQQuestions { get; set; }
        public int[] MCQAnswers { get; set; }

        public PracticalExam():base()
        {
            MCQQuestions = new MCQQuestion[NumberOfQuestions];
            MCQAnswers = new int[NumberOfQuestions];
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                MCQQuestions[i] = new MCQQuestion();
                TotalMarks += MCQQuestions[i].Mark;
            }
        }
        public PracticalExam(int _TimeOfExam , int _NumberOfQuestions , MCQQuestion[] _MCQQuestion , int _TotalMark)
            :base(_TimeOfExam , _NumberOfQuestions)
        {
            MCQQuestions = (MCQQuestion[]) _MCQQuestion.Clone() ;
            MCQAnswers = new int[_NumberOfQuestions];
            TotalMarks = _TotalMark;
        }

        public override void ShowExam()
        {
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                Console.WriteLine(MCQQuestions[i]);
                Console.WriteLine("________________________________________________");
                int _Answer;
                do
                {
                    int.TryParse(Console.ReadLine(), out _Answer);
                } while (_Answer <= 0 || _Answer > 3);
                MCQAnswers[i] = _Answer - 1;
                if (MCQQuestions[i].RightAnswerIndex == MCQAnswers[i])
                {
                    Grade += MCQQuestions[i].Mark; 
                }
            }
            Console.WriteLine(ToString());
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Right Answer: ");
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                sb.AppendLine($"Q {i+1},  {MCQQuestions[i].Answers[MCQQuestions[i].RightAnswerIndex].AnswerText}"); 
            }
            return sb.ToString();
        }
    }
}
