using System;
namespace FirstConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение радиуса конуса");
            double Radius = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение высоты конуса");
            double Height = int.Parse(Console.ReadLine());

            const double PI = Math.PI;
            double Square = PI * Radius * (Radius + Height);

            Console.WriteLine("Площадь конуса: " + Square);
            Console.ReadKey();
        }
    }
}