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

        public static void printEnd()
        {
            Console.WriteLine("(------ Press Enter To Go Back To MENU ------)");
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
                Console.WriteLine("3. Temperature Converter ");
                Console.WriteLine("4. Simple Discount Calculator ");
                Console.WriteLine("5. Grading System ");
                Console.WriteLine("6. Swap Two Numbers ");
                Console.WriteLine("7. Days to Weeks and Days Converter  ");
                Console.WriteLine("8. Electricity Bill Calculator  ");
                Console.WriteLine("9. Simple Calculator  ");
                Console.WriteLine("10. Exit");
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
                            double result3 = GradingSystem(score);

                            printValue(score);
                            printEnd();

                            break;


                        case 6:
                            Console.Clear();
                            double num11, num22;

                            Console.WriteLine("Enter First Number");
                            num11 = double.Parse(Console.ReadLine());

                            Console.WriteLine("Enter Second Number");
                            num22 = double.Parse(Console.ReadLine());

                            string result4 = LargestOfThreeNumbers(num11, num22);

                            printValue(result4);
                            printEnd();
                            break;
                        case 7: DaysToWeeksAndDaysConverter(); break;
                        case 8: ElectricityBillCalculator(); break;
                        case 9: SimpleCalculator(); break;
                        case 10: return;
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
            

            
            if (100 >= score && score >= 90)
            {
               return 'A';
            }
            else if (89 <= score && score >= 80)
            {
                return 'B';
            }
            else if (79 <= score && score >= 70)
            {
                return 'C';
            }
            else if (69 <= score && score >= 60)
            {
                return 'D';
            }
            else
            {
                return 'F';
            }


        }

        /* ------------------------------- 6. Swap Two Numbers  --------------------------------*/
        public static string SwapTwoNumbers(double num1 , double num2)
        {
            double num33;

            num33 = num1;
            num1 = num2;
            num2 = num33;

            return "New First Number is " + num1 + " New Second Number is " + num2;

        }

        /* ------------------------------- 7. Days to Weeks and Days Converter  --------------------------------*/
        static void DaysToWeeksAndDaysConverter()
        {
            Console.Clear();
            int days;
            double weeks, RDays;

            Console.WriteLine("Enter number of days");
            days = int.Parse(Console.ReadLine());

            if (days > 0)
            {
                weeks = days / 7;
                RDays = days % 7;
                Console.WriteLine("Number of weeks: " + weeks + " Remaining days " + RDays);
            }
            else
            {
                Console.WriteLine("Enter correct number");
            }

            Console.WriteLine("(------ Press Enter To Go Back To MENU ------)");
            Console.ReadLine();
        }

        /* ------------------------------- 8. Electricity Bill Calculator  --------------------------------*/
        static void ElectricityBillCalculator()
        {
            Console.Clear();
            double NUnit, result;

            Console.WriteLine("Enter Number of Unit ");
            NUnit = double.Parse(Console.ReadLine());

            if (NUnit < 0)
            {
                Console.WriteLine("Enter Number of Unit correctly 1 or more");
            }
            else if (1 <= NUnit && NUnit <= 100)
            {
                result = NUnit * 0.5;
                Console.WriteLine("The price is: $" + result);
            }
            else if (101 <= NUnit && NUnit <= 300)
            {
                result = NUnit * 0.75;
                Console.WriteLine("The price is: $" + result);
            }
            else
            {
                result = NUnit * 1;
                Console.WriteLine("The price is: $" + result);
            }

            Console.WriteLine("(------ Press Enter To Go Back To MENU ------)");
            Console.ReadLine();
        }

        /* ------------------------------- 9. Simple Calculator  --------------------------------*/
        static void SimpleCalculator()
        {
            Console.Clear();
            double num1, num2, result;
            string operatorr;

            Console.WriteLine("Enter First Number");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter operator (+, -, *, /)");
            operatorr = Console.ReadLine();

            Console.WriteLine("Enter Second Number");
            num2 = double.Parse(Console.ReadLine());

            Console.WriteLine(num1 + operatorr + num2);

            if (operatorr == "+")
            {
                result = num1 + num2;
                Console.WriteLine("The Result: " + num1 + operatorr + num2 + " = " + result);
            }
            else if (operatorr == "-")
            {
                result = num1 - num2;
                Console.WriteLine("The Result: " + num1 + operatorr + num2 + " = " + result);
            }
            else if (operatorr == "*")
            {
                result = num1 * num2;
                Console.WriteLine("The Result: " + num1 + operatorr + num2 + " = " + result);
            }
            else if (operatorr == "/")
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    Console.WriteLine("The Result: " + num1 + " / " + num2 + " = " + result);
                }
                else
                {
                    Console.WriteLine("Cannot divide by 0");
                }
            }
            else
            {
                Console.WriteLine("Enter Correct Operator!!!!!!!");
            }

            Console.WriteLine("(------ Press Enter To Go Back To MENU ------)");
            Console.ReadLine();
        }
    }
}