using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02_TRUESolution
{
    public abstract class Question :ICloneable
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark {  get; set; }
        public Answer[] Answers { get; set; }
        public int RightAnswerIndex { get; set; }

        public Question(string _Header )
        {
            Header = _Header;
            do
            {
                Console.WriteLine("Please Enter The Body Of The Question");
                Body = Console.ReadLine(); 
            } while (string.IsNullOrWhiteSpace(Body)|| string.IsNullOrEmpty(Body));
            int _Marks;
            do
            {
                Console.WriteLine("Please Enter The Marks Of Question");
            } while (!int.TryParse(Console.ReadLine(), out _Marks) || _Marks < 0);
            Mark = _Marks;

        }
        public Question(string _Header , string _Body , int _Mark)
        {
            Header = _Header;
            Body = _Body;
            Mark = _Mark;  
        }

        public override string ToString()
        {
            return $"{Header}    Mark({Mark})  \n {Body}";
        }

        public abstract object Clone();

    }
}
