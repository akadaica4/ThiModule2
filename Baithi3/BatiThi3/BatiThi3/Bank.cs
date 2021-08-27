using System;
using System.Collections.Generic;
using System.Text;

namespace BatiThi3
{
    class Bank
    {
        private const int exitCode = 4;
        private const int min = 1;
        private const int max = 4;
        public static List<Account> AccountList = new List<Account>();
        public  static Account accounts = new Account();
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
                Console.WriteLine("3. Show Customers data");
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
                            CreateAccount();
                            break;
                        }
                    case 2:
                        {
                            ShowData();
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
        public static void CreateAccount()
        {
                Account account = new Account();
                Console.Write(" Enter AccountID :");
                account.Accountid = int.Parse(Console.ReadLine());
                Console.Write(" Enter Fistname  :");
                account.Fistname = Console.ReadLine();
                Console.Write(" Enter LastName :");
                account.Lastname = Console.ReadLine();
                Console.Write(" Enter Gender :");
                account.Gender = Console.ReadLine();
                AccountList.Add(account);
                Console.WriteLine(" Create Post Success");
        }
        public static void ShowData()
        {
            foreach(Account account in AccountList)
            {
                Console.WriteLine("AccountID\t\tFistname\t\tLastname\t\tGender\t\tBalance");
                Console.WriteLine(account.Showinfo());
            }
        }
    }
}
