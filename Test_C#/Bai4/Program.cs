using System.Collections;
using System.Text;

namespace Bai4
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;

            Hashtable StudHashtable = new Hashtable();
            Boolean ktra;
            string user;
            Console.WriteLine("Nhập 1 để thêm sinh viên mới:");

            do
            {
                user = Console.ReadLine();
                ktra = user == "1";
                if (!ktra)
                {
                    Console.WriteLine("Yêu cầu nhập lại");
                    Console.WriteLine("Nhập 1 để thêm sinh viên mới:");

                }

            } while (!ktra);
            if (user == "1")
            {
                Student newStudent = new Student();

                Console.Write("Nhập StudID: ");
                newStudent.StudID = Console.ReadLine();

                Console.Write("Nhập StudName: ");
                newStudent.StudName = Console.ReadLine();

                Console.Write("Nhập StudGender: ");
                newStudent.StudGender = Console.ReadLine();

                Console.Write("Nhập StudAvg: ");
                newStudent.StudAvg = Convert.ToDouble(Console.ReadLine());

                Console.Write("Nhập StudClass: ");
                newStudent.StudClass = Console.ReadLine();

                for (int i = 1; i <= 3; i++)
                {
                    Console.Write("Nhập điểm: ", i);
                    double mark = Convert.ToDouble(Console.ReadLine());
                    newStudent[i] = mark;
                }

                StudHashtable.Add(newStudent.StudID, newStudent);

                Console.WriteLine("Sinh viên đã được thêm vào Hashtable.");
            }


        }
        class Student
        {
            public string StudID { get; set; }
            public string StudName { get; set; }
            public string StudGender { get; set; }
            public double StudAvg { get; set; }
            public string StudClass { get; set; }

            private double[] marks = new double[3];

            // Indexer để thao tác với mảng marks
            public double this[int index]
            {
                get { return marks[index - 1]; }
                set { marks[index - 1] = value; }
            }
        }
    }
}
