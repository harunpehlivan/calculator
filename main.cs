using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to Calculator! This was made originally in Visual Studio 2019, .NET Framework. I have since then migrated my project to Repl.it. This can calculate Logarithms, Trigonometric Calculations, Fractions, Cube Root and Square Root!");
            
            Console.Write("Instructions: Press 1 on your keyboard for Trigonometry, 2 for Standard (Fractions, Roots), and press 3 for normal Addition, Subtraction. Once you go onto it, Type SQRT/CBRT For Root Calculations and type FRACTION for Fractional Calculations. Fractions will always return as decimal numbers however. LN does not work in this calculator, neither does Mixed Numbers. Any Math Error, Syntax Error or Stack Error will always come out as Math Error. Visit the README.MD for more! Press Enter to continue.");
            if(Console.ReadKey().Key == ConsoleKey.Enter)
            {
              Console.Clear();
              Calculator();
            }
        }

        public static void Calculator()
        {
            try {
                Console.Write("What type of calculation would you like to do? 1 for Trigonometric, 2 for Standard, 3 for Addition, Subtraction, Division and Multiplication: ");
                string calculationtype = Console.ReadLine().ToUpper();



                if (calculationtype == "1")
                {
                    Console.Write("Would you like to do Tan, Cos or Sin?: ");
                    string typeofTrigonometricCalculation = Console.ReadLine().ToUpper();
                    if (typeofTrigonometricCalculation == "TAN")
                    {
                        Console.Write("Enter a number: ");
                        int tanNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Math.Tan(tanNumber));
                    }
                    else if (typeofTrigonometricCalculation == "SIN")
                    {
                        Console.Write("Enter a number: ");
                        int sinNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Math.Sin(sinNumber));
                    }
                    else if (typeofTrigonometricCalculation == "COS")
                    {
                        Console.Write("Enter a number: ");
                        int cosNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Math.Cos(cosNumber));

                    }
                    else if (typeofTrigonometricCalculation == "TANH")
                    {
                        Console.Write("Enter a Number: ");
                        int tanhNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Math.Tanh(tanhNumber));
                    }
                    else if (typeofTrigonometricCalculation == "COSH")
                    {
                        Console.Write("Enter a number: ");
                        int coshNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Math.Cosh(coshNumber));
                    }
                    else if (typeofTrigonometricCalculation == "SINH")
                    {
                        Console.Write("Enter a Number: ");
                        int sinhNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Math.Sinh(sinhNumber));
                    }
                    else if (typeofTrigonometricCalculation == "LOG")
                    {
                        Console.Write("Enter a Base: ");
                        int BaseNumber = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter a Number: ");
                        int LogNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Math.Log(LogNumber, BaseNumber));
                    }
                    else if (typeofTrigonometricCalculation == "ABS")
                    {
                        Console.Write("You can only use Decimal Numbers for this. If you used integers, you wouldn't really need to be using this would you? Enter a Number: ");
                        double absNumber = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(Math.Abs(absNumber));
                    }
                    else
                    {
                        Console.WriteLine("Sorry, I don't know that Trigonometric Function. It may have not been added or it does not exist. Please try again.");
                    }


                }

                if (calculationtype == "2")
                {
                    Console.Write("What type of calculation would you like to do?: ");
                    string typeofNormalCalculation = Console.ReadLine().ToUpper();
                    if (typeofNormalCalculation == "SQRT")
                    {
                        Console.Write("Enter a Number: ");
                        int SQRT = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Math.Sqrt(SQRT));
                    } else if (typeofNormalCalculation == "CBRT")
                    {
                        int number = 0;
                        double cubeRoot = 0;

                        Console.Write("Enter the value of number: ");
                        number = Convert.ToInt32(Console.ReadLine());

                        cubeRoot = Math.Ceiling(Math.Pow(number, (double)1 / 3));
                        Console.WriteLine("Cube Root is : " + cubeRoot);
                    } else if (typeofNormalCalculation == "FRACTION")
                    {
                        Console.WriteLine("Mixed Numbers are not supported in this calculator. Sorry. However, you can multiply, add, subtract and divide fractions.");
                        Console.Write("Enter a Numerator: ");
                        double numerator = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter a Denominator: ");
                        double denonimator = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter an Operator: ");
                        char Operator = Convert.ToChar(Console.ReadLine());
                        Console.Write("Enter a Numerator: ");
                        double numerator1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter a Denominator: ");
                        double denonimator1 = Convert.ToDouble(Console.ReadLine());
                        if (Operator == '+')
                        {
                            Console.WriteLine(numerator / denonimator + numerator1 / denonimator1);
                        } else if (Operator == '-')
                        {
                            Console.WriteLine(numerator / denonimator - numerator1 / denonimator1);
                        } else if (Operator == '*' || Operator == 'X' || Operator == 'x')
                        {
                            Console.WriteLine(numerator / denonimator * numerator1 / denonimator1);
                        } else if (Operator == '/')
                        {
                            Console.WriteLine((numerator / denonimator) / (numerator1 / denonimator1));
                        } else
                        {
                            Console.WriteLine("Syntax Error");
                        }
                    } else if (typeofNormalCalculation == "POWER OF" || typeofNormalCalculation == "OF" || typeofNormalCalculation == "POWER")
                    {
                        Console.WriteLine("Enter the first number: ");
                        int ExponentNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the Exponent Method");
                        int ExponentNumber2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Math.Pow(ExponentNumber, ExponentNumber2));
                    }
                } else if (calculationtype == "3")
                {
                    Console.Write("Enter a Number: ");
                    int int1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter another Number: ");
                    int int2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter an operator: ");
                    string opr = Console.ReadLine();
                    if (opr == "+")
                    {
                        Console.WriteLine(int1 + int2);
                    } else if (opr == "-")
                    {
                        Console.WriteLine(int1 - int2);
                    }
                    else if (opr == "*")
                    {
                        Console.WriteLine(int1 * int2);
                    }
                    else if (opr == "/")
                    {
                        Console.WriteLine(int1 / int2);
                    }
                }
            } catch
            {
                Console.WriteLine("Math Error");
            }
        }

    }
}
