using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Task2
{
    public class TSphere : TCircle
    {
        public TSphere(double radius = 1)
        {
            if (radius == 0)
            {
                Console.WriteLine("Радіус не може бути нульовий. Встановлено за замовчуванням");
                radius = 1;
            }
            this.radius = Math.Abs(radius);
        }
        public double GetVolume()
        {
            return (4 * Math.PI * Math.Pow(radius, 3)) / 3.0;
        }

        public new double GetArea()
        {
            return 4 * base.GetArea();
        }

        public new void Print()
        {
            Console.WriteLine($"Радіус: {radius}\n" +
                              $"Площа поверхні: {GetArea()}\n" +
                              $"Об'єм: {GetVolume()}");
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
