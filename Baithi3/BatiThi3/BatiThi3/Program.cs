using System;
using System.Text;
namespace BatiThi3
{
    class Program
    {
        private const int exitCode = 4;
        private const int min = 1;
        private const int max = 4;
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Process();
        }

        private static void BuildMenu(out int selected)
        {
            do
            {
                Console.WriteLine("========== Menu ==========");
                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. Pay into");
                Console.WriteLine("3. Show Customers");
                Console.WriteLine("4. Exit");
                Console.WriteLine("================================");
                Console.Write($"Vui lòng chọn một số ({min},{max}):");
                int.TryParse(Console.ReadLine(), out selected);
            }
            while (selected < min || selected > max);
        }

        public static void Process()
        {
            int selected = 0;
            do
            {
                BuildMenu(out selected);
                Console.Clear();
                switch (selected)
                {
                    case 1:
                        {

                            break;
                        }
                    case 2:
                        {

                            break;
                        }
                    case 3:
                        {

                            break;
                        }
                    case exitCode:
                        {
                            Environment.Exit(0);
                            break;
                        }
                }
            }
            while (selected != exitCode);
        }
    }
}
