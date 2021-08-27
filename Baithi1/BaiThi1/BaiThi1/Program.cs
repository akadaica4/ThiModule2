using System;

namespace BaiThi1
{
    class Program
    {
        public static int[,] matrix;
        public static int row;
        public static int col;
        static void Main(string[] args)
        {
            Console.Write(" Nhập số dòng: ");
            row = int.Parse(Console.ReadLine());
            Console.Write("Nhập số cột: ");
            col = int.Parse(Console.ReadLine());
            matrix = CreateMatrix(row, col);
            Display(matrix, row, col);
            FindMax(matrix, row, col);
            Console.WriteLine($"Số lớn nhất: {FindMax(matrix, row, col)}");
            ShowMatrix(matrix, row, col);
        }
        static int[,] CreateMatrix(int row, int col)
        {
            Random rnd = new Random();
            int[,] matrix = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(" Nhập phần tử mảng : " + i + " - " + j + " : ");
                    int matrixs = int.Parse(Console.ReadLine());
                    matrix[i, j] = matrixs;
                }
            }
            return matrix;
        }
        static int FindMax(int[,] arr, int row, int col)
        {
            int max = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                    }
                }
            }
            return max;
        }
        static void ShowMatrix(int[,] arr, int row, int col)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (i >= j)
                    {
                        Console.Write($"{arr[i, j]}");
                    }
                    else
                    {
                        Console.Write("--");
                    }
                }
                Console.WriteLine(" ");
            }
        }
        static void Display(int[,] arr, int row, int col)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine("");
            }
        }
    }
}
