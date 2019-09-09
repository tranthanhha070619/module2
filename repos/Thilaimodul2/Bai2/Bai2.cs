using System;

namespace Thilaimodul2.Bai2
{
    public static class Bai2
    {
        public static int[] arr;

        public static void Main()
        {
            Menu();
            Console.ReadKey();
        }
        public static void Menu()
        {
            int option = 0;
            do
            {
                Console.WriteLine("<<<<<>>>>>");
                Console.WriteLine("1. Tao mang ");
                Console.WriteLine("2. Kiem tra mang ");
                Console.WriteLine("3. Sap xep mang ");
                Console.WriteLine("4. Tim kiem mang ");
                Console.WriteLine("5. Exit");

                Console.WriteLine("Vui long cho nhan xet");
                Console.WriteLine("option: ");
                if (int.TryParse(Console.ReadLine(), out var number))
                {
                    option = number;
                }
            } while (option >=6 || option <= 0);
            Process(option);
        }
        public static void Process(int selected)
        {
            switch (selected)
            {

                case 1:
                    {
                        Console.WriteLine(" Tao mang ");
                        int n = int.Parse(Console.ReadLine());
                        arr = new int[n];
                        CreateArray(arr, n);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("kiem tra mang doi xung:");

                        if (IsSymmetryArray(arr))
                        {
                            Console.WriteLine("Mang nay la mang doi xung");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Mang nay khong phai la mang doi xung");
                        }
                        break;
                    }

                case 3:
                    {
                        Console.WriteLine("Sap xep mang: ");
                        BubbleSort(arr);
                    }
                    break;
                case 4:
                    {
                        Console.WriteLine("Tim kiem mang: ");
                        Console.WriteLine("Nhap gia tri can tim: ");
                        int n = int.Parse(Console.ReadLine());
                        Console.WriteLine(Find(arr, n));
                    }
                    break;
                case 5:
                default:
                    {
                        Environment.Exit(Environment.ExitCode);
                    }
                    break;
                  
            }
            Menu();
        }
        public static void CreateArray(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap arr[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Mang da nhap: ");
            Console.WriteLine(string.Join(" ", arr));
        }


        public static bool IsSymmetryArray(int[] arr)
        {
            for (int i = 0; i < arr.Length / 2; i++)
            {
                if (arr[i] == arr[arr.Length - 1 - i]) return true;
            }
            return false;
        }

        public static void BubbleSort(int[] arr)
        {
            int length = arr.Length;
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = length - 1; j > i; j--)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = temp;
                    }
                }
            }
            Console.WriteLine("Sap xep mang tang dan bang thuat toan noi bot:\n");
            Console.WriteLine(string.Join(" ", arr));

        }
        public static int Find(int[] arr, int n)
        {
            int min = 0;
            int max = arr.Length - 1;
            int mid = 0;
            while (min <= max)
            {
                mid = (min + max) / 2;
                if (arr[mid] == n)
                {
                    return mid;
                }
                else if (arr[mid] < n)
                {
                    min = mid + 1;
                }
                else
                {
                    max = mid - 1;
                }
            }
            return mid;
        }

    }
}
