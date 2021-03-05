using System;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("________________________________________");
                Console.WriteLine("|     MENU DE OPERACIONES BASICAS!     |");
                Console.WriteLine("|______________________________________|");

                Console.WriteLine("Ingrese el primer numero: ");
                float number1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el segundo numero: ");
                float number2 = float.Parse(Console.ReadLine());
                
                Console.WriteLine("____________________________________________");

                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicacion");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Modulo");
                Console.WriteLine("6. Salir");
                Console.WriteLine();
                String op = Console.ReadLine();

                switch (op )
                {
                    case "1": 
                        float resultado1 = number1 + number2;
                        Console.WriteLine("El resultado es: " + resultado1);
                        break;
                    case "2":
                        float resultado1 = number1 - number2;
                        Console.WriteLine("El resultado es: " + resultado1);
                        break;
                    case "3":
                        float resultado1 = number1 * number2;
                        Console.WriteLine("El resultado es: " + resultado1);
                        break;
                    case "4":
                        float resultado1 = number1 / number2;
                        Console.WriteLine("El resultado es: " + resultado1);
                        break;
                    case "5":
                        float resultado1 = number1 % number2;
                        Console.WriteLine("El resultado es: " + resultado1);
                        break;
                    case "6":
                        salir = true; 
                        break;                                    
                    default:
                         Console.WriteLine("La opcion ingresada no es valida ");
                        break;
                    
                }
                
            }

        }
    }
}
