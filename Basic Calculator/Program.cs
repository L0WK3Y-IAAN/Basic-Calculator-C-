using System;

namespace Basic_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Select your calculation mode: \n1. Addition\n2. Subtraction\n3. Multiplication\n4. Division \n\nYour selection: ");
            string calMode = Console.ReadLine();

            if (calMode == "1") {
                Console.Clear();
                Console.Write("First Number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Second Number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("\nThe answer is: ");
                Console.WriteLine(num1 + num2);

                Console.Read();
         
            }
            if (calMode == "2")
            {
                Console.Clear();
                Console.Write("First Number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Second Number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("\nThe answer is: ");
                Console.WriteLine(num1 - num2);

                Console.Read();

            }
            if (calMode == "3")
            {
                Console.Clear();
                Console.Write("First Number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Second Number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("\nThe answer is: ");
                Console.WriteLine(num1 * num2);

                Console.Read();

            }
            if (calMode == "4")
            {
                Console.Clear();
                Console.Write("First Number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Second Number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("\nThe answer is: ");
                Console.WriteLine(num1 / num2);

                Console.Read();

            }
            else
            {
                Console.Write("Error. Press any key to continue...");
                Console.ReadLine();
            }





        }
    }
}
