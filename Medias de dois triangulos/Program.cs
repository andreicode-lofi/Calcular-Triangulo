using System;
using System.Globalization;

namespace Medias_de_dois_triangulos
{
    class Program
    {
        static void Main(string[] args)
        {
            string opc = "s";

            while (opc == "s" || opc == "S")
            {

                Console.WriteLine("Entre com as medidas do triángulo X ");

                Console.Write("Lado 1: ");
                double xa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Lado 2: ");
                double xb = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Lado 3: ");
                double xc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Triangulos X = new Triangulos(xa, xb, xc);

                Console.WriteLine();
                Console.WriteLine("Entre com as medidas do Triángulo Y ");
                Console.Write("Lado 1: ");
                double ya = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Lado 2: ");
                double yb = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Lado 3: ");
                double yc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Triangulos Y = new Triangulos(ya, yb, yc);

                double areaX = X.CalculoTriangulo();
                double areaY = Y.CalculoTriangulo();

                Console.WriteLine();
                Console.WriteLine("Área de X = " + X);
                Console.WriteLine("Área de y = " + Y);

                if (areaX > areaY)
                {
                    Console.WriteLine("Triángulo maior é = " + areaX.ToString("f4", CultureInfo.InvariantCulture));
                }
                else
                {
                    Console.WriteLine("Triángulo Y é o maior = " + areaY.ToString("f4", CultureInfo.InvariantCulture));
                }
                Console.WriteLine();
                Console.Write("Deseja calcular outros dois triangulos (s/n) ? ");
                opc = Console.ReadLine();

            }

            


            
        }
    }
}
