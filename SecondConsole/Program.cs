using System;
namespace SecondConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 14;
            int y = 1;
            int z = 5;

            {
                x += y - x++ * z;
                Console.WriteLine("Результат выражения x += y - x++ * z: " + x);
            }

            {
                z = --x - y * 5;
                Console.WriteLine("Результат выражения z = --x – y * 5: " + z);
            }

            {
                y /= x + 5 % z;
                Console.WriteLine("Результат выражения y /= x + 5 % z: " + y);
            }

            {
                z = x++ + y * 5;
                Console.WriteLine("Результат выражения z = x++ + y * 5: " + z);
            }

            {
                x = y - x++ * z;
                Console.WriteLine("Результат выражения x = y - x++ * z: " + x);
            }

        }
    }
}