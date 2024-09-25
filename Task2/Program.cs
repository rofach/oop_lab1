using System;
using System.Text;

namespace Task2
{
    internal class Program
    {
        static TCircle CreateCircle()
        {
            Console.WriteLine("Введіть радіус");
            double r = Convert.ToDouble(Console.ReadLine());
            return new TCircle(r);
        }

        static TSphere CreateSphere()
        {
            Console.WriteLine("Введіть радіус");
            double r = Convert.ToDouble(Console.ReadLine());
            return new TSphere(r);
        }

        static void Compare(TCircle obj1, TCircle obj2)
        {
            if (obj1.CompareTo(obj2) == 0) Console.WriteLine("Рівні");
            else if (obj1.CompareTo(obj2) == 1) Console.WriteLine("Перший об'єкт більший");
            else Console.WriteLine("Другий об'єкт більший");
        }

        static double GetSectorArea(TCircle circle)
        {
            Console.WriteLine("Введіть кут сектора");
            double angle = Convert.ToDouble(Console.ReadLine());
            return circle.GetSectorArea(angle);
        }
        static void PrintOperators(TCircle obj1, TCircle obj2)
        {
            Console.Write("На яке число домножити радіус: ");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"+: {obj1 + obj2}\n" +
                              $"-: {obj1 - obj2}\n" +
                              $"* для об'єкта 1: {obj1 * num}\n" +
                              $"* для об'єкта 2: {num * obj2}");

        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;
            while (true)
            {
                Console.WriteLine("Стоврити коло(0), сферу(1) чи вийти(інше значення)");
                short choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        {
                            Console.WriteLine("Радіус 1 та 2 кола");
                            TCircle circle1 = CreateCircle();
                            TCircle circle2 = CreateCircle();
                            Compare(circle1, circle2);
                            Console.WriteLine("Параметри першого кола");
                            circle1.Print();
                            Console.WriteLine($"Площа сектора {GetSectorArea(circle1)}");
                            Console.WriteLine("Параметри другого кола");
                            circle2.Print();
                            Console.WriteLine($"Площа сектора {GetSectorArea(circle2)}");
                            PrintOperators(circle1, circle2);
                            Console.WriteLine("Використання конструктора з копіюванням другого кола:");
                            TCircle circle3 = new(circle2);
                            circle3.Print();
                            break;
                        }
                    case 1:
                        {
                            Console.WriteLine("Радіус 1 та 2 сфери");
                            TSphere sphere1 = CreateSphere();
                            TSphere sphere2 = CreateSphere();
                            Compare(sphere1, sphere2);
                            Console.WriteLine("Параметри першої сфери");
                            sphere1.Print();
                            Console.WriteLine("Параметри другої сфери");
                            sphere2.Print();
                            PrintOperators(sphere1, sphere2);
                            break;
                            
                        }
                    default:
                        Console.WriteLine("Завершення");
                        return;

                }
            
               
            }

        }
    }
}