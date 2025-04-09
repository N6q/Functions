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
    }
}