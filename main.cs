using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Globalization;
// <link rel="apple-touch-icon" href="https://icons8.com">

namespace The_World
{
    class Calculator
    {
        static bool wanted_leave = false;
        static void Main()
        {
            while(wanted_leave != true){
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Метиз Сервис Консоль Калькулятор [МСКК]");
            Thread.Sleep(10000);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1. Сложение\n");
            Console.WriteLine("2. Уменьшение\n");
            Console.WriteLine("3. Умножение\n");
            Console.WriteLine("4. Деление\n");
            Console.WriteLine("5. Выход\n");
            int input = int.Parse(Console.ReadLine()!);
            switch(input)
            {
                case 1:
                
                Console.WriteLine("Введите два числа");
                float num1 = float.Parse(Console.ReadLine()!);
                float num2 = float.Parse(Console.ReadLine()!);
                Console.WriteLine(Sum(num1,num2));
                Thread.Sleep(5000);
                Console.ResetColor();
                break;
                case 2:
                Console.WriteLine("Введите два числа");
                Console.WriteLine("Введите два числа");
                float num_y1 = float.Parse(Console.ReadLine()!);
                float num_y2 = float.Parse(Console.ReadLine()!);
                Console.WriteLine(difference(num_y1,num_y2));
                Thread.Sleep(5000);
                Console.ResetColor();
                break;
                case 3:
                
                Console.WriteLine("Введите два числа");
                Console.WriteLine("Введите два числа");
                float num_u1 = float.Parse(Console.ReadLine()!);
                float num_u2 = float.Parse(Console.ReadLine()!);
                Console.WriteLine(Product(num_u1,num_u2));
                Thread.Sleep(5000);
                Console.ResetColor();
                break;
                case 4:
                Console.WriteLine("Введите два числа");
                Console.WriteLine("Введите два числа");
                float num_d1 = float.Parse(Console.ReadLine()!);
                float num_d2 = float.Parse(Console.ReadLine()!);
                Console.WriteLine(Quotient(num_d1,num_d2));
                Thread.Sleep(5000);
                Console.ResetColor();
                break;
                case 5:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Выход...");
                Thread.Sleep(3000);
                wanted_leave = true;
                Console.ResetColor();
                
                break;
                default:
                Console.ResetColor();
                Console.WriteLine("Code breaked");
                Console.ResetColor();
                break;
                

                        
                
               
            }
            }
        }
        static float Sum(float a,float b)
        {
            return a + b;
        }
        static float difference(float a,float b)
        {
            return a - b;
        }
        static float Product(float a,float b)
        {
            return a * b;
        }
        static float Quotient(float a,float b)
        {
            return a / b;
        }
    }
}