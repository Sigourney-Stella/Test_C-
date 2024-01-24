using System.Text;

namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            IStudent IStud = new IStudent();

            IStud.StudID = 123;
            IStud.StudName = "Hoa";
            IStud.StudGender = "Nữ";
            IStud.StudAge = 21;

            Console.WriteLine("Mã: "+ IStud.StudID);
            Console.WriteLine("Tên:"+IStud.StudName);
            Console.WriteLine("Giới tính:" + IStud.StudGender);
            Console.WriteLine("Tuổi:" + IStud.StudAge);
        }
    }
}
