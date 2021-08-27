using System;
using System.Text;
namespace BaiThi2
{
    class Program
    {
        private const int exitCode = 5;
        private const int min = 1;
        private const int max = 5;
        private static int[] arr;
        private static int n;
        static int BuildMenu()
        {
            int selected;
            Console.WriteLine("========== Menu ==========");
            Console.WriteLine("1. Tạo mảng");
            Console.WriteLine("2. Kiểm tra mảng đối xứng");
            Console.WriteLine("3. Sắp xếp mảng");
            Console.WriteLine("4. Tìm kiếm mảng");
            Console.WriteLine("5. Thoát");
            Console.Write($"Vui lòng chọn một số ({min},{max}):");
            selected = int.Parse(Console.ReadLine());
            return selected;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            int selected;
            do
            {
                selected = BuildMenu();
                switch (selected)
                {
                    case 1:
                        arr = CreateArray();
                        n = arr.Length;
                        break;
                    case 2:
                        bool check = IsSymmetryArray(arr, n);
                        if (check)
                        {
                            Console.WriteLine("Mảng đối xứng");
                        }
                        else
                        {
                            Console.WriteLine("Mảng không đối xứng");
                        }
                        break;
                    case 3:
                        BubbleSort(arr, n);
                        Console.WriteLine();
                        Display(arr, n);
                        Console.WriteLine("");
                        break;
                    case 4:
                        Console.Write("Nhập số cần tìm: ");
                        int x = int.Parse(Console.ReadLine());
                        int index = Find(arr, 0, n - 1, x);
                        if (index == -2)
                        {
                            Console.WriteLine("Không tìm thấy");
                        }
                        else if (index == -1)
                        {
                            Console.WriteLine("Mảng không tăng");
                        }
                        else
                        {
                            Console.WriteLine("Vị trí: " + index);
                        }
                        break;
                    case exitCode:
                        Environment.Exit(0);
                        return;
                    default:
                        Console.WriteLine("Chọn lại");
                        break;
                }
            } while (selected != 5);
            Console.ReadLine();
        }
        static int[] CreateArray()
        {
            int n;
            Console.Write("Số phần tử : ");
            n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write(" Nhập phần tử " + (i + 1).ToString() + " : ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            return arr;
        }
        static bool IsSymmetryArray(int[] arr, int n)
        {
            for (int i = 0; i < n / 2; i++)
            {
                if (arr[i] != arr[n - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
        static bool IsArray(int[] arr, int n)
        {
            for (int i = 1; i < n; i++)
            {
                if (arr[i] < arr[i - 1])
                {
                    return false;
                }
            }
            return true;
        }
        static void BubbleSort(int[] arr, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                int tmp = i;
                for (int j = i + 1; j < n; j++)
                    if (arr[j] < arr[tmp])
                    {
                        tmp = j;
                        int temp = arr[tmp];
                        arr[tmp] = arr[i];
                        arr[i] = temp;
                    }
            }
        }
        static int Find(int[] arr, int l, int r, int x)
        {
            if (IsArray(arr, arr.Length))
            {
                return -2;
            }
            if (r >= l)
            {
                int mid = l + (r - l) / 2;
                if (arr[mid] == x)
                    return mid;
                if (arr[mid] > x)
                    return Find(arr, l, mid - 1, x);
                return Find(arr, mid + 1, r, x);
            }
            return -1;
        }
        static void Display(int[] arr, int n)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"\n{arr[i]} ");
            }
        }
    }
}
