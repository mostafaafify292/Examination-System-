using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02_TRUESolution
{
    public class FinalExam : Exam
    {
        public Question[] Questions { get; set; }
        public int[] Answers { get; set; }

        public FinalExam() : base()
        {
            Questions = new Question[NumberOfQuestions];
            Answers = new int[NumberOfQuestions];
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                int QuesType;
                do
                {
                    Console.WriteLine($"Please Enter The Type Of The {i+1}th Question (1 For True | False Q || 2 For McqQuestion )");
                    int.TryParse( Console.ReadLine(), out QuesType );
                } while (QuesType != 1 && QuesType != 2  );
                if (QuesType == 1)
                {
                    Questions[i] = new TrueFalseQuestion();
                }
                else
                {
                    Questions[i] = new MCQQuestion();
                }
                TotalMarks += Questions[i].Mark;
            }
        }
        public FinalExam(int _TimeOfExam, int _NumberOfQuestions ,Question[] questions , int _TotalMark) 
            :base(_TimeOfExam, _NumberOfQuestions)
        {
            Questions = new Question[_NumberOfQuestions];
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                Questions[i] = (Question)questions[i].Clone();
            }
            TotalMarks = _TotalMark;
        }

        public override void ShowExam()
        {
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                Console.WriteLine(Questions[i]);
                Console.WriteLine("________________________________________________");
                int _Answer;
                do
                {
                    int.TryParse(Console.ReadLine(), out _Answer);
                } while (_Answer <= 0 || _Answer > Questions[i].Answers.Length);
                Answers[i] = _Answer - 1;
                if (Questions[i].RightAnswerIndex == Answers[i])
                {
                    Grade += Questions[i].Mark;
                }
            }
        }
        public override string ToString()
        {
          StringBuilder sb = new StringBuilder();
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                sb.AppendLine($"Q{i + 1}. {Questions[i].Body} : {Questions[i].Answers[Answers[i]].AnswerText}");
            }
            sb.AppendLine($" {Grade} / {TotalMarks} ");
            return sb.ToString();
        }
    }
}
