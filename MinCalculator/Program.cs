using System;

namespace Calculator
{
    class Program
    {
        double Num1;
        double Num2;
        double svar;
        string ops;

        static void Main(string[] args)
        {
            double Num1;
            double Num2;
            double svar;
            string ops;
            bool strYN = true;

            Console.WriteLine("\t\t\tConsole Calculator Tutorial in C#\r");
            Console.WriteLine("\t\t\t-----------------------------\r");
            Console.WriteLine("hej");


            while (strYN)
            {
                Console.WriteLine("\t\t\tEnter Num1\n");
                Num1 = Double.Parse(Console.ReadLine());


                Console.WriteLine("\t\t\tSelect an operator: (+, -, *, /, %, ^)\n");
                ops = Console.ReadLine();
                Console.WriteLine("\t\t\tEnter andra nummer\n");
                Num2 = Double.Parse(Console.ReadLine());


                if (ops == "+")
                {
                    bool gånger = true;
                    while (gånger)
                    {
                        svar = Num1 + Num2;
                        Console.WriteLine(Num1 + " + " + Num2 + " = " + svar);
                        Console.WriteLine("You want add more Y");
                        string addMore = Console.ReadLine();
                        if (addMore == "Y" || addMore == "y")
                        {
                            gånger = true;
                            Num1 = svar;
                            Console.Write("Enter new number: ");
                            Num2 = Double.Parse(Console.ReadLine());

                        }
                        else
                        {
                            gånger = false;
                            Console.WriteLine("hejdå");
                        }




                        //Console.Write("\n" + "Do you want try agin Y/N\n");

                    }

                    //Console.Write("\n" + svar);
                }
                if (ops == "-")
                {
                    svar = Num1 - Num2;
                    Console.Write("\n" + svar);
                }

                if (ops == "*")
                {
                    svar = Num1 * Num2;
                    Console.Write("\n" + svar);
                }


                if (ops == "/")
                {
                    svar = Num1 / Num2;
                    Console.Write("\n" + svar);
                }


                if (ops == "%")
                {
                    svar = Num1 % Num2;
                    Console.Write("\n" + svar);
                }

                Console.Write("\n" + "Do you want try agin Y/N\n");

                string yesorno = Console.ReadLine();

                if (yesorno == "N" || yesorno == "n")
                {
                    strYN = false;
                    Console.WriteLine("hejdå");
                }
            }
        }
    }
}