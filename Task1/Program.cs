using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void FindSolutions(QuadraticEquation qe)
        {
            if (!qe.IsSolvable()) { Console.WriteLine("Розв'язків немає"); }
            else
            {
                Console.WriteLine("Виведення через метод(0) чи через індексатор(1): ");
                short choice = Convert.ToInt16(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        qe.PrintSolutions();
                        break;
                    case 1:
                        Console.WriteLine(qe[0] == null ? "Першого розв'язку немає" : "Перший розв'язок " + Convert.ToString(qe[0]));
                        Console.WriteLine(qe[1] == null ? "Другого розв'язку немає" : "Другий розв'язок " + Convert.ToString(qe[1]));
                        break;
                    default:
                        Console.WriteLine("Неправлильний ввід, вивід через метод");
                        qe.PrintSolutions();
                        break;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введіть коефіцієнти a, b, c: ");
            double[] coeff = Array.ConvertAll(Console.ReadLine().Split(), Convert.ToDouble);
            QuadraticEquation qe = new QuadraticEquation(coeff[0], coeff[1], coeff[2]);

            Console.Write("Квадратне рівняння: ");
            qe.PrintEquation();
            FindSolutions(qe);
            Console.ReadLine();
        }
    }
}
