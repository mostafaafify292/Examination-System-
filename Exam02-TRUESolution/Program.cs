namespace Exam02_TRUESolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject(2, ".Net Programming");
            subject.CreateExam();
            Console.WriteLine("Do You Want To Start The Exam (Y|N):");
            char ch;
            char.TryParse(Console.ReadLine(), out ch);
            if (ch == 'y' || ch == 'Y' )
            {
                subject.Exam.ShowExam();
            }
        }
    }
}
