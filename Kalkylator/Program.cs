using System;
using System.Runtime.CompilerServices;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Y";
            List<string> lista = new List<string>();
            do
            {

                double num1 = 0;
                double num2 = 0;
                double result = 0;

                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("Välkommen till kalkylatorn");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~");


                Console.Write("Skriv nummer 1: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Skriv nummer 2: ");
                num2 = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("Välj räknesätt: ");
                Console.WriteLine("\t+ : Addition");
                Console.WriteLine("\t− : Subtraktion");
                Console.WriteLine("\t* : Multiplikation");
                Console.WriteLine("\t/ : Divition");
                Console.Write("----->: ");

                string operation = Console.ReadLine();

                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Resultat: {num1} + {num2} = " + result);
                        lista.Add($"Resultat: {num1} + {num2} = " + result);
                        break;

                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Resultat: {num1} - {num2} = " + result);
                        lista.Add($"Resultat: {num1} - {num2} = " + result);
                        break;

                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Resultat: {num1} * {num2} = " + result);
                        lista.Add($"Resultat: {num1} * {num2} = " + result);
                        break;

                    case "/":
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                            Console.WriteLine($"Resultat: {num1} / {num2} = {result}");
                            lista.Add($"Resultat: {num1} / {num2} = {result}");
                        }
                        else
                        {
                            Console.WriteLine("Ogiltig inmatning! Du kan inte dela med 0.");
                        }
                        break;
                }
                Console.WriteLine("Vill du fortsätta? (Y = Ja, N = Nej): ");

                Console.WriteLine("Skriv L för att visa historik");
                input = Console.ReadLine().ToUpper();
                if (input == "L")
                {
                    foreach (string uträkningar in lista)
                    {
                        Console.WriteLine(uträkningar);
                    }
                    Console.WriteLine("Vill du fortsätta? (Y = Ja, N = Nej): ");
                    input = Console.ReadLine().ToUpper();
                }

            }

            while (input == "Y");{
                
            }
                

            Console.WriteLine("Hej då! :)");
            Environment.Exit(0);

        }
    }
}



