using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02_TRUESolution
{
    internal class Subject
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Exam Exam { get; set; }

        public Subject(int _ID , string _Name)
        {
            ID = _ID;
            Name = _Name;
        }
        public void CreateExam()
        {
            int ExamType;
            do
            {
                Console.WriteLine($"Please Enter Exam Type (1 For Pratical | 2 For Final )");
                int.TryParse(Console.ReadLine(),out ExamType);
            } while (ExamType != 1 && ExamType != 2);
            if (ExamType ==1)
            {
                Exam = new PracticalExam();
            }
            else
            {
                Exam = new FinalExam();
            }
        }
    }
}
