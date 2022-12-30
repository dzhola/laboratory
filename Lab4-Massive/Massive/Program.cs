using System;

namespace Massive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            Console.Write("Введіть кількість елементів масиву:\t");
            int elementsCount = Convert.ToInt32(Console.ReadLine());
            int[] myArray = new int[elementsCount];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"\nВведіть елемент масиву під індексом {i}:\t");
                myArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nВивід масиву:");

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + "  ");
            }
            Console.WriteLine();



            // int[] myArray = { 822, 45, 632, 14, 25, 89 };
            // for (int i = 0; i < myArray.Length; i++)
            // {
            //     Console.Write(myArray[i] + "  ");
            // }
            // Console.WriteLine();
            // Метод розвороту масива
            void ReversalMassiv(int[] Arr)
            {
                int length = Arr.Length;
                if (Arr.Length % 2 == 0)
                {
                    length = length / 2;
                }
                else
                    length = (length - 1) / 2;

                for (int i = 0; i < length; i++)
                {
                    int a = Arr[i];
                    Arr[i] = Arr[Arr.Length - 1 - i];
                    Arr[Arr.Length - 1 - i] = a;
                }
                Console.WriteLine("\nВивід розвернутого масиву:");

                for (int i = 0; i < Arr.Length; i++)
                {
                    Console.Write(Arr[i] + "  ");
                }
                Console.WriteLine();
            }
            ReversalMassiv(myArray);

            Console.WriteLine();

            // Метод знаходження суми не(парних) елементів масиву 

            void EvenFind(int[] Array)
            {
                int summa = 0;
                for (int i = 0; i < Array.Length; i++)
                {
                    if (Array[i] % 2 == 0)
                    {
                        summa = summa + Array[i];
                    }
                }
                Console.WriteLine($"Сума парних елементів: {summa}");
            }
            EvenFind(myArray);

            // Найбільший(найменший) елемент масиву

            void Less_moreMassiv(int[] Array)
            {
                int max = Array[0];
                for (int i = 1; i < Array.Length; i++)
                {
                    if (Array[i] > Array[0])
                    {
                        max = Array[i];
                    }

                }
                Console.WriteLine($"Найбільший елемент масиву: {max}");
            }
            Less_moreMassiv(myArray);

        }
    }
}
