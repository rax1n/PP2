using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()); //создаю переменную типа инт, для первого числа. Число элементов в массиве
            int[] arr = new int[n]; //создаю массив, чтобы вбить в неё "n" чисел через
            for(int i=0;i<n;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            //--------------------------
            int counter = 0;
            int[] newarr = new int[n];
            //--------------------------
            for (int i = 0; i < n; i++)
            {
                int prime = 0;
                if (arr[i] > 1)
                {
                    for (int j = 2; j < arr[i]; j++)
                    {
                        if (arr[i] % j != 0)
                        {
                            continue;
                        } else { prime++; }
                    }
                    if (prime == 0)
                    {
                        newarr[counter] = arr[i];
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
            for(int i = 0;i<counter;i++)
            {
                Console.Write(newarr[i] + " ");
            }
        }
    }
}
