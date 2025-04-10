using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Functions
{
    internal class Program
    {


        public static void printValue(string input)
        {
            Console.WriteLine("the result of this operation is: " + input + "\n");
        }
        public static void printValue(double input)
        {
            Console.WriteLine("the result of this operation is: " + input + "\n");
        }
        public static void printValue(char input)
        {
            Console.WriteLine("the result of this operation is: " + input + "\n");
        }

        public static void printEnd()
        {
            Console.WriteLine("(------ Press Enter Twice To Go Back To MENU ------)");
            Console.ReadLine();
        }




        static void Main(string[] args)
        {


            // Main menu loop
            while (true)
            {
                Console.Clear();
                // Display menu options
                Console.WriteLine("\nChoose an Array Exercise:");
                Console.WriteLine("1. Even or Odd ");
                Console.WriteLine("2. Largest of Three Numbers ");
                Console.WriteLine("3. Temperature Conventor  ");
                Console.WriteLine("4. Simple Discount Calculator ");
                Console.WriteLine("5. Grading System ");
                Console.WriteLine("6. Swap Two Numbers ");
                Console.WriteLine("7. Days to Weeks and Days Converter  ");
                Console.WriteLine("8. Electricity Bill Calculator  ");
                Console.WriteLine("9. Simple Calculator  ");
                Console.WriteLine("10. Simple Calculator (Switch-Case)");
                Console.WriteLine("11. Basic ATM System");
                Console.WriteLine("12. Geometry Calculator");
                Console.WriteLine("13. Factorial of a Number");
                Console.WriteLine("14. Sum of Even and Odd Numbers");
                Console.WriteLine("15. Scientific Calculator");
                Console.WriteLine("16. Print Triangle Pattern");
                Console.WriteLine("17. Print Pyramid Pattern");
                Console.WriteLine("18. Print Diamond Pattern");
                Console.WriteLine("19. Guess the Number Game");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");

                try
                {
                    // Get user choice
                    int choice = int.Parse(Console.ReadLine());

                    // Handle user choice
                    switch (choice)
                    {
                        case 1:
                            Console.Clear();


                            Console.WriteLine("Enter a number");
                            int num = int.Parse(Console.ReadLine());

                            string result = EvenOrOdd(num);
                            printValue(result);

                            printEnd();

                            break;


                        case 2:

                            Console.Clear();
                            double num1, num2, num3;

                            Console.WriteLine("Enter First Number");
                            num1 = int.Parse(Console.ReadLine());

                            Console.WriteLine("Enter Second Number");
                            num2 = int.Parse(Console.ReadLine());

                            Console.WriteLine("Enter Third Number");
                            num3 = int.Parse(Console.ReadLine());

                            double result1 = LargestOfThreeNumbers(num1, num2, num3);

                            printValue(result1);

                            printEnd();

                            break;


                        case 3:

                            Console.Clear();
                            double temp;

                            Console.WriteLine("Enter temperature");
                            temp = double.Parse(Console.ReadLine());
                            
                            double result2 = TemperatureConverter(temp);

                            printValue(result2);

                            printEnd();

                            break;



                        case 4:

                            Console.Clear();
                            double itmP, AfterDiscount;

                            Console.WriteLine("Enter item price");
                            itmP = double.Parse(Console.ReadLine());

                            AfterDiscount = SimpleDiscountCalculator(itmP);

                            printValue(AfterDiscount);
                            printEnd();

                            break;

                        case 5:

                            Console.Clear();
                            double score;

                            Console.WriteLine("Enter Student Score");
                            score = double.Parse(Console.ReadLine());

                            while (score > 100 && score < 0)
                            {
                                Console.WriteLine("Enter Student Score Correctly: ");
                                score = double.Parse(Console.ReadLine());
                            }

                            char result3 = GradingSystem(score);

                            printValue(result3);
                            printEnd();

                            break;


                        case 6:
                            Console.Clear();
                            double num11, num22;

                            Console.WriteLine("Enter First Number");
                            num11 = double.Parse(Console.ReadLine());

                            Console.WriteLine("Enter Second Number");
                            num22 = double.Parse(Console.ReadLine());

                            string result4 = SwapTwoNumbers(num11, num22);

                            printValue(result4);
                            printEnd();
                            break;


                        case 7:

                            Console.Clear();
                            int days;

                            Console.WriteLine("Enter number of days");
                            days = int.Parse(Console.ReadLine());

                            string result5 = DaysToWeeksAndDaysConverter(days);

                            printValue(result5);
                            printEnd();

                            break;

                        case 8:

                            Console.Clear();
                            double NUnit;
                            Console.WriteLine("Enter Number of Unit ");
                            NUnit = double.Parse(Console.ReadLine());

                            while (NUnit < 0)
                            {
                                Console.WriteLine("Enter Number of Unit correctly 1 or more: ");
                                NUnit = double.Parse(Console.ReadLine());
                            }

                            double result6 = ElectricityBillCalculator(NUnit);
                            printValue(result6);

                            printEnd();
                            break;


                        case 9:

                            Console.Clear();
                            double num111, num222;
                            char operatorr;

                            Console.WriteLine("Enter First Number");
                            num111 = double.Parse(Console.ReadLine());

                            Console.WriteLine("Enter operator (+, -, *, /)");
                            operatorr = Console.ReadKey().KeyChar;

                            Console.WriteLine("Enter Second Number");
                            num222 = double.Parse(Console.ReadLine());

                            double result7 = SimpleCalculator(num111, operatorr, num222);
                            printValue(result7);
                            printEnd();




                            break;


                        case 10:

                            Console.WriteLine("Enter number of operator \n" +
                            "1: + \n" +
                            "2: - \n" +
                            "3: * \n" +
                            "4: / \n");
                            int op = int.Parse(Console.ReadLine());

                            do
                            {
                            Console.WriteLine("Enter First Number");
                            double num1S = double.Parse(Console.ReadLine());


                            Console.WriteLine("Enter Secound Number");
                            double num2S = double.Parse(Console.ReadLine());

                            while (num2S == 0)
                            {
                                
                                Console.WriteLine("Cannot divide by 0. Enter another number: ");
                                 num2S = double.Parse(Console.ReadLine());

                            }
                           
                            double result8 = SimpleCalculatorSwitch(num1S, op , num2S); 
                            

                            printValue(result8); 
                            printEnd();
                            }
                            while (op != 4);

                            break;

                        case 11:
                            Console.Clear();
                            double balance = 1000;
                            int atmChoice;

                            do
                            {
                                Console.WriteLine("\nATM Menu:");
                                Console.WriteLine("1. Check Balance");
                                Console.WriteLine("2. Deposit Money");
                                Console.WriteLine("3. Withdraw Money");
                                Console.WriteLine("4. Exit");
                                Console.Write("Enter your choice: ");
                                atmChoice = int.Parse(Console.ReadLine());

                                switch (atmChoice)
                                {
                                    case 1: // Check Balance
                                        printValue(balance);
                                        printEnd();
                                        break;

                                    case 2: // Deposit
                                        Console.Write("Enter deposit amount: ");
                                        double deposit = double.Parse(Console.ReadLine());
                                        balance = BasicATM(balance, atmChoice, deposit);
                                        printValue(balance);
                                        printEnd();
                                        break;

                                    case 3: // Withdraw
                                        Console.Write("Enter withdrawal amount: ");
                                        double withdraw = double.Parse(Console.ReadLine());
                                        balance = BasicATM(balance, atmChoice, withdraw);
                                        printValue(balance);
                                        printEnd();
                                        break;

                                    case 4: // Exit
                                        Console.WriteLine("Thank you for using the ATM!");
                                        printEnd();
                                        break;

                                    default:
                                        Console.WriteLine("Invalid choice!");
                                        break;
                                }
                            } while (atmChoice != 4);
                            break;



                        case 12:
                            Console.Clear();
                            int geoOption;
                            do
                            {
                                Console.WriteLine("1: Circle\n2: Square\n3: Triangle\n4: Exit");
                                geoOption = int.Parse(Console.ReadLine());

                                if (geoOption == 1)
                                {
                                    Console.Write("Enter radius: ");
                                    double r = double.Parse(Console.ReadLine());
                                    GeometryCircle(r);
                                }
                                else if (geoOption == 2)
                                {
                                    Console.Write("Enter side: ");
                                    double s = double.Parse(Console.ReadLine());
                                    GeometrySquare(s);
                                }
                                else if (geoOption == 3)
                                {
                                    Console.Write("Enter base: ");
                                    double b = double.Parse(Console.ReadLine());
                                    Console.Write("Enter height: ");
                                    double h = double.Parse(Console.ReadLine());
                                    GeometryTriangle(b, h);
                                }

                            } while (geoOption != 4);

                            printEnd();
                            
                            break;

                        case 13:
                            Console.Clear();
                            Console.Write("Enter a number: ");
                            int factorialNum = int.Parse(Console.ReadLine());
                            double result13 = Factorial(factorialNum);
                            printValue(result13);
                            printEnd();
                            break;


                        case 14:
                            Console.Clear();
                            Console.Write("Enter a number: ");
                            int limit = int.Parse(Console.ReadLine());
                            SumEvenOdd(limit);
                            printEnd();
                            break;

                        case 15:
                            Console.Clear();
                            string again;
                            do
                            {
                                Console.WriteLine("1: sin\n2: cos\n3: tan\n4: sqrt\n5: log\n6: pow");
                                int sciOp = int.Parse(Console.ReadLine());

                                Console.Write("Enter number: ");
                                double num1111 = double.Parse(Console.ReadLine());
                                double num2222 = 0;

                                if (sciOp == 6)
                                {
                                    Console.Write("Enter power: ");
                                    num2 = double.Parse(Console.ReadLine());
                                }

                                double result15 = CalculateScientific(sciOp, num1111, num2222);
                                printValue(result15);

                                Console.Write("Use again? (y/n): ");
                                again = Console.ReadLine();
                                Console.Clear();
                            } while (again == "y");
                            printEnd();

                            break;

                        case 16:
                            Console.Clear();
                            Console.Write("Enter number of rows: ");
                            int rowsP = int.Parse(Console.ReadLine());
                            PrintPyramid(rowsP);
                            printEnd();

                            break;

                        case 17:  
                            Console.Clear();
                            Console.Write("Enter number of rows: ");
                            int rows = int.Parse(Console.ReadLine());
                            PrintTriangle(rows);
                            printEnd();
                            break;

                        case 18:
                            Console.Clear();
                            Console.Write("Enter number of rows: ");
                            int rowsD = int.Parse(Console.ReadLine());
                            PrintDiamond(rowsD);
                            printEnd();
                            break;


                        case 19:

                            Console.Clear();
                            Console.WriteLine("Guess a number between 1 and 100:");
                            int userGuess;
                            int target = new Random().Next(1, 101);
                            do
                            {
                                Console.Write("Enter guess: ");
                                userGuess = int.Parse(Console.ReadLine());
                                CheckGuess(userGuess, target);
                            } while (userGuess != target);
                            printEnd();
                            break;

                        case 0: return;
                        default: Console.WriteLine("Invalid choice! Try again."); break;
                    }
                }
                catch (FormatException)
                {
                    // Handle invalid input
                    Console.WriteLine("Invalid input format. Please enter a number.");
                }
                catch (Exception ex)
                {
                    // Handle unexpected errors
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }

                Console.ReadLine();
            }
        }

        /* ------------------------------- 1. Even or Odd --------------------------------*/
        public static string EvenOrOdd(int number)
        {

            if (number % 2 == 0)
                return "Even";
            else
                return "Odd";

        }


        /* ------------------------------- 2. Largest of Three Numbers --------------------------------*/
        public static double LargestOfThreeNumbers(double num1, double num2 , double num3)
        {


            if (num1 >= num2 && num1 >= num3)
            {
                return num1;
            }
            else if (num1 <= num2 && num2 >= num3)
            {
                return num2;
            }
            else if (num2 <= num3 && num3 >= num1)
            {
                return num3;
            }
            return 0;

        }


        /* ------------------------------- 3. Temperature Converter  --------------------------------*/
        public static double TemperatureConverter(double temp)
        {

            double Result;
            Result = (temp * 9 / 5) + 32;
            return Result;
            

           
        }


        /* ------------------------------- 4. Simple Discount Calculator  --------------------------------*/
        public static double SimpleDiscountCalculator(double itmP)
        {
           

            if (itmP > 100)
            {
                double B4Discount = (itmP * 10) / 100;
                double AfterDiscount = itmP - B4Discount;
                return AfterDiscount;
            }
            else
            {
                return itmP;           
            }


        }


        /* ------------------------------- 5. Grading System  --------------------------------*/
        public static char GradingSystem(double score)
        {

            char grade;
            
            if (100 >= score && score >= 90)
            {
                grade = 'A';
                
            }
            else if (89 <= score && score >= 80)
            {
                grade = 'B';
            }
            else if (79 <= score && score >= 70)
            {
                grade = 'C';
            }
            else if (69 <= score && score >= 60)
            {
                grade = 'D';
            }
            else
            {
                grade = 'F';
            }
            return grade;


        }


        /* ------------------------------- 6. Swap Two Numbers  --------------------------------*/
        public static string SwapTwoNumbers(double num1 , double num2)
        {
            double num33;

            num33 = num1;
            num1 = num2;
            num2 = num33;

            return "New First Number is: " + num1 + "\n New Second Number is: " + num2;

        }


        /* ------------------------------- 7. Days to Weeks and Days Converter  --------------------------------*/
        public static string DaysToWeeksAndDaysConverter(int days)
        {
            double weeks, RDays;

            if (days > 0)
            {
                weeks = days / 7;
                RDays = days % 7;
                return "Number of weeks: " + weeks + " Remaining days " + RDays;
            }
            else
            {
                return "Enter correct number";
            }


        }


        /* ------------------------------- 8. Electricity Bill Calculator  --------------------------------*/
        public static double ElectricityBillCalculator(double NUnit)
        {
           


            if (1 <= NUnit && NUnit <= 100)
            {
                return NUnit * 0.5;
            }
            else if (101 <= NUnit && NUnit <= 300)
            {
                return NUnit * 0.75;
            }
            else
            {
                return NUnit * 1;
                
            }


        }


        /* ------------------------------- 9. Simple Calculator  --------------------------------*/
        public static double SimpleCalculator(double num1 , char operatorr, double num2 )
        {


            if (operatorr == '+')
            {
                return num1 + num2;
            }
            else if (operatorr == '-')
            {
                return num1 - num2;
            }
            else if (operatorr == '*')
            {
                return num1 * num2;
            }
            else if (operatorr == '/')
            {
                if (num2 != 0)
                {
                    return num1 / num2;
                }
                else
                {
                    return 0;
                }
            }
            return 0;



        }


        /* ------------------------------- 10. Simple Calculator (Switch-Case)  --------------------------------*/
        public static double SimpleCalculatorSwitch(double num1, int op, double num2)
        {

            double result = 0;

            

                switch (op)
                {
                    case 1:
                        result = num1 + num2;
                        break;

                    case 2:
                        result = num1 - num2;
                        break;

                    case 3:
                        result = num1 * num2;
                        break;

                    case 4:
                        result = num1 / num2;
                        break;

                    default:
                        break;

                }

            return result;
        }


        /* ------------------------------- 11. Basic ATM System  --------------------------------*/
        public static double BasicATM(double balance, int operation, double amount)
        {
            switch (operation)
            {
                case 1: // Check Balance (handled in Main)
                    return balance;

                case 2: // Deposit
                    if (amount > 0)
                        return balance + amount;
                    else
                        return balance; // Invalid deposit

                case 3: // Withdraw
                    if (amount > 0 && amount <= balance)
                        return balance - amount;
                    else
                        return balance; // Invalid withdrawal

                default:
                    return balance; // No change for invalid operations
            }
        }


        /* ------------------------------- 12. Geometry Calculator  --------------------------------*/
        public static void GeometryCircle(double radius)
        {
            printValue($"Area: {Math.PI * radius * radius}, Circumference: {2 * Math.PI * radius}");
        }

        public static void GeometrySquare(double side)
        {
            printValue($"Area: {side * side}, Perimeter: {4 * side}");
        }

        public static void GeometryTriangle(double b, double h)
        {
            printValue($"Area: {0.5 * b * h}");
        }


        /* ------------------------------- 13. Factorial of a Number   --------------------------------*/
        public static double Factorial(int n)
        {
            double result = 1;
            for (int i = 1; i <= n; i++)
                result *= i;
            return result;
        }


        /* ------------------------------- 14. Sum of Even and Odd Numbers   --------------------------------*/
        public static void SumEvenOdd(int num)
        {
            double evenSum = 0, oddSum = 0;
            for (int i = 1; i <= num; i++)
            {
                if (i % 2 == 0)
                    evenSum += i;
                else
                    oddSum += i;
            }

            printValue($"Even Sum: {evenSum}, Odd Sum: {oddSum}");
        }


        /* ------------------------------- 15. Scientific Calculator (Switch-Case & Math Functions)  --------------------------------*/
        public static double CalculateScientific(int option, double num1, double num2 = 0)
        {
            switch (option)
            {
                case 1: return Math.Sin(num1);
                case 2: return Math.Cos(num1);
                case 3: return Math.Tan(num1);
                case 4: return Math.Sqrt(num1);
                case 5: return Math.Log(num1);
                case 6: return Math.Pow(num1, num2);
                default: return 0;
            }
        }



        /* ------------------------------- 16. Print Pattern (For Loop) --------------------------------*/
        public static void PrintTriangle(int rows)
        {
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }



        /* ------------------------------- 17. Print a Pyramid Pattern (For Loop) --------------------------------*/
        public static void PrintPyramid(int rows)
        {
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows - i; j++)
                    Console.Write(" ");
                for (int k = 1; k <= 2 * i - 1; k++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }



        /* ------------------------------- 18. Print a Diamond Pattern (For Loop) --------------------------------*/
        public static void PrintDiamond(int rows)
        {
            PrintPyramid(rows);
            for (int i = rows - 1; i >= 1; i--)
            {
                for (int j = 1; j <= rows - i; j++)
                    Console.Write(" ");
                for (int k = 1; k <= 2 * i - 1; k++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }



        /* ------------------------------- 19. Guess Game with helper  --------------------------------*/
        public static void CheckGuess(int guess, int target)
        {
            if (guess > target)
                Console.WriteLine("Too high!");
            else if (guess < target)
                Console.WriteLine("Too low!");
            else
                Console.WriteLine("Correct!");
        }

    }


}

