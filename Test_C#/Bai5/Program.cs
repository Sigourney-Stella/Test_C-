using System.Collections;

namespace Bai5
{
    interface IStudent
    {
        void Print();
    }
    internal class Program
    {
        static void Main()
        {
            Hashtable studentHashtable = new Hashtable();

            // ... (phần nhập sinh viên giống như trong đoạn mã trước)

            Console.WriteLine("Nhập 2 để in thông tin của tất cả sinh viên:");
            string userInput = Console.ReadLine();

            if (userInput == "2")
            {
                // Bước 3: Lặp qua tất cả sinh viên trong Hashtable và gọi phương thức Print
                foreach (DictionaryEntry entry in studentHashtable)
                {
                    if (entry.Value is IStudent)
                    {
                        // Kiểm tra nếu đối tượng là một thực thể của IStudent interface
                        IStudent student = (IStudent)entry.Value;
                        student.Print();
                    }
                }
            }

            // Tiếp tục xử lý chương trình hoặc thoát
            // ...
        }
    }

    class Student : IStudent
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

        // Phương thức Print từ giao diện IStudent
        public void Print()
        {
            Console.WriteLine($"Student ID: {StudID}");
            Console.WriteLine($"Student Name: {StudName}");
            Console.WriteLine($"Student Gender: {StudGender}");
            Console.WriteLine($"Student Average: {StudAvg}");
            Console.WriteLine($"Student Class: {StudClass}");

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Mark {i}: {this[i]}");
            }

            Console.WriteLine();
        }
    }
}
