//Написать цикл, который принимает два числа А и В и возводит А в степень В

using System;

namespace Stepen_Cycle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int a = 1;
            int b = 1;
            while(a!=0)
            {
                Console.WriteLine("Введите показатель степени, отличный от 0");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите основание степени, отличное от 0 или 0 для окончания счета");
                a = Convert.ToInt32(Console.ReadLine());
                double stepen = Math.Pow(a, b);
                Console.WriteLine(stepen);
            }
            
        }
    }
}
