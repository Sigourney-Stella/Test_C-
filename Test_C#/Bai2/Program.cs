using System.Text;

namespace Bai2
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Student student = new Student
            {
                StudID = 1,
                StudName = "Hoa",
                StudGender = "Nữ",
                StudAge = 22,
                StudClass = "10A",
                StudAvgMark = 0
            };

            // Set marks using the indexer
            student[0] = 1;
            student[1] = 2;
            student[2] = 4;

            // Calculate and set average mark
            student.CalAvg();

            // Display student information
            student.Print();
        }
    }
 }

