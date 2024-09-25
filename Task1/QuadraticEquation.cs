using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class QuadraticEquation
    {
        private double[] solutions;

        private double a, b, c;

        public QuadraticEquation(double a = 0, double b = 0, double c = 0)
        {
            if (a == 0) throw new Exception("a cant`t equal 0");
            this.a = a;
            this.b = b;
            this.c = c;
            FindSolutions();
        }

        private void FindSolutions()
        {
            double d = Math.Pow(b, 2) - 4 * a * c;
            if (d > 0)
            {
                solutions = new double[2];
                solutions[0] = (-b - Math.Sqrt(d)) / (2 * a);
                solutions[1] = (-b + Math.Sqrt(d)) / (2 * a);
            }
            else if (d == 0)
            {
                solutions = new double[1];
                solutions[0] = -b / (2 * a);
            }
            
        }

        private string GetNumWithSign(double num) {
            return num < 0 ? Convert.ToString(" - " + Math.Abs(num)) : Convert.ToString(" + " + num);
        }

        public void PrintEquation()
        {
            Console.WriteLine($"{a}x^2{(b == 0 ? "" : Convert.ToString(GetNumWithSign(b) + "x"))}" +
                              $"{(c == 0 ? "" : Convert.ToString(GetNumWithSign(c)))}");
        }

        public void PrintSolutions()
        {
            if (solutions == null) Console.WriteLine("Немає розв'язків");
            else
            {
                int length = solutions.Length;
                Console.WriteLine($"{length} розв'яз{(length == 1 ? "ок" : "ки")}");
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine($"Розв'язок {i+1}: {solutions[i]}");
                }
            }

        }
        public double? this[int i]
        {
            get
            {
                if (solutions == null || i > solutions.Length - 1 || i < 0)
                {
                    return null;
                    // throw new Exception("There are not solutions or index is out of array") ;
                }
                return solutions[i];
            }

        }

        public double A
        {
            set { a = value; }
            get { return a; }
        }
        public double B
        {
            set { b = value; }
            get { return b; }
        }
        public double C
        {
            set { c = value; }
            get { return c; }
        }

        public bool IsSolvable()
        {
            return solutions != null;
        }
        
        

    }
}
