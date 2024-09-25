using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class TCircle : IComparable<TCircle>
    {
        protected double radius;

        public TCircle()
        {
            radius = 1;
        }

        public TCircle(double radius)
        {
            if (radius == 0)
            {
                Console.WriteLine("Радіус не може бути нульовий. Встановлено за замовчуванням");
                radius = 1;
            }
            this.radius = Math.Abs(radius);
        }

        public TCircle(TCircle circle)
        {
            radius = circle.radius;
        }

        public void SetRadius(double radius)
        {
            this.radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * radius * radius;
        }

        public double GetSectorArea(double angle)
        {
            return (GetArea() * angle) / 360;
        }
        public void Print()
        {
            Console.WriteLine($"Радіус: {radius}\n" +
                              $"Площа:  {GetArea()}");
            
        }

        public int CompareTo(TCircle? circle)
        {
            if(circle == null) return 1; 
            return radius.CompareTo(circle.radius);
        }
        public override string ToString()
        {
            return $"Радіус: {radius}";
        }
        public static TCircle operator +(TCircle circle1, TCircle circle2) { 
            return new TCircle(circle1.radius + circle2.radius);
        }

        public static TCircle operator -(TCircle circle1, TCircle circle2)
        {
            return new TCircle(Math.Abs(circle1.radius - circle2.radius));
        }

        public static TCircle operator *(TCircle circle, double number)
        {
            return new TCircle(circle.radius * number);
        }

        public static TCircle operator *(double number, TCircle circle)
        {
            return new TCircle(circle.radius * number);
        }   

      

        

    }
}
