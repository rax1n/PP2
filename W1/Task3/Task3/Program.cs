using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            //через цикл заполняю массив целыми числами
            for(int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            //Создаю новый массив в два раза длинее
            int[] arr2 = new int[2*n];

            for (int i = 0; i < n*2; i++)//циклом заполняю массив  
            {
                arr2[i] = arr[i/2];
            }
            //циклом вывожу массив на консоль
            for (int i = 0; i<2*n; i++)
            {
                Console.Write(arr2[i] + " ");
            }
        }

    }
}
