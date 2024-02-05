namespace Lab1Charp
{

    public class Lab1Charp
    {
        public static double CalculateCircleRadius(double length)
        {
            //add check for negative length
            if (length < 0)
            {
                return 0;
            }
            try
            {
                double radius = length / (2 * Math.PI);

                Console.WriteLine("Radius of circle is: " + radius);
                return radius;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                return 0;
            }
        }

        static void task1()
        {
            Console.WriteLine("Input length of circle: ");

            try
            {
                // Ask user to input length of circle using parse from string to double
                double length = Convert.ToDouble(Console.ReadLine());

                // Call the separate function to calculate and display the radius
                double radius = CalculateCircleRadius(length);

                //display radius
                Console.WriteLine("Radius of circle is: " + radius);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }

        //task2
        public static string CheckDigits(int number)
        {
            if (IsThreeDigitNumber(number))
            {
                int first = GetFirstDigit(number);
                int last = GetLastDigit(number);

                if (first > last)
                {
                    return "First digit is bigger";
                }
                else if (first < last)
                {
                    return "Last digit is bigger";
                }
                else
                {
                    return "First and last digits are equal";
                }
            }
            else
            {
                return "Number is not three-digit";
            }
        }

        public static bool IsThreeDigitNumber(int number)
        {
            return (number > 99 && number < 1000);
        }

        public static int GetFirstDigit(int number)
        {
            return number / 100;
        }

        public static int GetLastDigit(int number)
        {
            return number % 10;
        }

        static void task2()
        {
            Console.WriteLine("Input three-digit number: ");
            try
            {
                int number = Convert.ToInt32(Console.ReadLine());
                string result = CheckDigits(number);
                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }

        //task3
        public static string CheckPointLocation(double x, double y)
        {
            // check if point is inside the shaded area
            if (x > 0 && x < 70 && y > 0 && y < 70 && y < x)
            {
                return "Yes";
            }
            // check if point is outside the shaded area
            else if (x < 0 || x > 70 || y < 0 || y > 70 || y > x)
            {
                return "No";
            }
            // check if point is on the border
            else
            {
                return "On the border";
            }
        }

        static void task3()
        {
            Console.WriteLine("Input x coordinate: ");
            try
            {
                double x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Input y coordinate: ");
                double y = Convert.ToDouble(Console.ReadLine());

                string result = CheckPointLocation(x, y);

                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }

        //task4
        public static string EvaluateTest(int points)
        {
            try
            {
                // Check number of points and return evaluation
                if (points >= 90 && points <= 100)
                {
                    return "Excellent";
                }
                else if (points >= 70 && points <= 89)
                {
                    return "Good";
                }
                else if (points >= 50 && points <= 69)
                {
                    return "Satisfactory";
                }
                else if (points < 50 && points >= 0)
                {
                    return "Unsatisfactory";
                }
            }
            catch (Exception e)
            {
                return "Error: " + e.Message;
            }

            // Default return in case of unexpected conditions
            return "Invalid Input";
        }

        static void task4()
        {
            /*
            Test is evaluated in integer points from 0 to 100. Print on the screen the evaluation of the test depending on the number of points:
             from 90 to 100 - "excellent", from 70 to 89 - "good", from 50 to 69 - "satisfactory", less than 50 - "unsatisfactory".
            */

            // Ask user to input number of points using parse from string to int
            Console.WriteLine("Input number of points: ");
            try
            {
                int points = Convert.ToInt32(Console.ReadLine());

                // Call the EvaluateTest function and print the result
                string evaluation = EvaluateTest(points);
                Console.WriteLine("Evaluation: " + evaluation);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }

        //task5
        public static double GetUserInput(string prompt)
        {
            Console.WriteLine(prompt);
            return Convert.ToDouble(Console.ReadLine());
        }

        public static double SquareOfSum(double a, double b)
        {
            //return Math.Pow(a + b, 2);
            return (a + b) * (a + b);
        }

        static void task5()
        {
            try
            {
                double a = GetUserInput("Input first number: ");
                double b = GetUserInput("Input second number: ");

                double result = SquareOfSum(a, b);

                Console.WriteLine("Square of sum of two numbers is: " + result);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }

        //task6
        public static double CalculateExpression(double x, double y)
        {
        
            double denominator = Math.Pow(x, 2) + 2 * x +5;
            if (denominator == 0)
            {
                throw new Exception("Error: Division by zero");
            }
            return (((Math.Pow(y, 2) + 4) / denominator + 1) * x);
            
        }

        static void task6()
        {
            while (true)
            {
                double x = GetUserInput("Input x: ");
                double y = GetUserInput("Input y: ");

                try
                {
                    double result = CalculateExpression(x, y);
                    Console.WriteLine("Value of the expression is: " + result);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }

                Console.WriteLine("Press 'q' to exit or any other key to continue");
                if (Console.ReadLine() == "q")
                {
                    break;
                }
            }
        }
        static void Main()
        {
            //menu for user to choose task
            //ask user to input number of task using parse from string to int 
            try
            {
                Console.WriteLine("Input number of task: ");
                int task = Convert.ToInt32(Console.ReadLine());
                switch (task)
                {
                    case 1:
                        task1();
                        break;
                    case 2:
                        task2();
                        break;
                    case 3:
                        task3();
                        break;
                    case 4:
                        task4();
                        break;
                    case 5:
                        task5();
                        break;
                    case 6:
                        task6();
                        break;
                    default:
                        Console.WriteLine("Task not found");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}