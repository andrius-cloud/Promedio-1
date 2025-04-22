using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Promedio_1.Calculadora
{
    internal class Calculadora
    {
        static void Main(string[] args)
        {
            float a;
            float b;
            string operaciones;
            bool continueFlag = true;

            while (continueFlag)
            {
                Console.WriteLine("Introduce el primer número: ");
                a = float.Parse(Console.ReadLine());
                Console.WriteLine("Introduce el segundo número: ");
                b = float.Parse(Console.ReadLine());

                Console.WriteLine("Introduce la operacion (+, -, *, /): ");
                operaciones = Console.ReadLine();

                switch (operaciones)
                {
                    case "+":
                        Suma suma = new Suma(a, b);
                        Console.WriteLine($"El resultado de la operacion es {suma.Calculo()}");
                        break;

                    case "-":
                        Resta resta = new Resta(a, b);
                        Console.WriteLine($"El resultado de la operacion es {resta.Calculo()}");
                        break;

                    case "*":
                        Multiplicacion multiplicacion = new Multiplicacion(a, b);
                        Console.WriteLine($"El resultado de la operacion es {multiplicacion.Calculo()}");
                        break;

                    case "/":
                        Division division = new Division(a, b);
                        Console.WriteLine($"El resultado de la operacion es {division.Calculo()}");
                        break;

                    case "esc":
                        continueFlag = false;
                        break;
                }
            }
        }
    }
}
