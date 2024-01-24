namespace Bai3
{
    internal class Program
    {
        static void Main()
        {
            int luaChon;

            do
            {
                HienThiMenu();
                luaChon = LuaChon();

                switch (luaChon)
                {
                    case 1:
                        Console.WriteLine("1.Insert new student");
                        break;

                    case 2:
                        Console.WriteLine("2.DisPlay all student list");
                        break;

                    case 3:
                        Console.WriteLine("3.");
                        break;

                    case 4:
                        Console.WriteLine("4.Exit");
                        break;
                    default:
                        Console.WriteLine("change option");
                        break;
                }

            } while (luaChon != 4);
        }

        static void HienThiMenu()
        {
            Console.WriteLine("===== Please select an option =====");
            Console.WriteLine("1. Insert new student");
            Console.WriteLine("2. DisPlay all student list");
            Console.WriteLine("3. CaCulator average mark");
            Console.WriteLine("4. Exit");
            Console.WriteLine("=============================");

        }

        static int LuaChon()
        {
            Console.Write("option: ");
            int luaChon;
            while (!int.TryParse(Console.ReadLine(), out luaChon))
            {
                Console.WriteLine("Vui lòng nhập một số nguyên");
                Console.Write("Nhập lại lựa chọn: ");
            }
            return luaChon;
        }
    }
}
