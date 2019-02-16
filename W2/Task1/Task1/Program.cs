using System;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //создал переменную pool типа bool
            bool pool = true;

            //считываю данные из файла
            using (FileStream fs = new FileStream(@"/Users/magametovrahman/Desktop/PP2/W2/Task1/input.txt", FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    //создаю переменную text типа string и сохраняю все элементы файла в переменной. Эту переменную проверяю через функцию типа bool на палиндромность и записываю ответ в переменной типа bool
                    string text = sr.ReadLine();
                    pool = Polindrome(text);
                    if (pool == true)
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No");
                    }
                    Console.Write(text);
                }
            }

        }
        private static bool Polindrome(string text)
        {
            //создаю цикл чтобы пробежаться по элементам массива
            for (int i = 0; i <= (text.Length) / 2; i++)
            {
                //Если они одинаковы то переходим на следующий элемент. А если они не одинаковые то выводим false и выходим из функции
                if (text[i] != text[text.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}