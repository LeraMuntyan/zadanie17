using System;

namespace _17
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите натуральное число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[10];
            int i = 0;
            while (a > 0)
            {
                array[i] = a % 10;
                a /= 10;
                i++;
            }
            int[] arr = new int[i];
            for (int j = 0; j < i; j++)
                arr[j] = array[j];
            Array.Sort(arr);
            int b;
            for (int j = 0; j < i; j++)
            {
                if (arr[j] == 0)
                    continue;
                else
                {
                    b = arr[0];
                    arr[0] = arr[j];
                    arr[j] = b;
                    break;
                }
            }
            Console.Write("Минимальное число из цифр данного числа: ");
            for (int j = 0; j < i; j++)
                Console.Write(arr[j]);
            {
                Console.WriteLine("\nEsli hotite povtorit vvod, vvedite 1, inache lubuyu dr cifru");
                 a = Convert.ToInt32(Console.ReadLine());
                if (a == 1) Main();
                return;
            }
        }
    }
}