using System;

namespace HelloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Write 2 Number lol.");
            float number1 = float.Parse(Console.ReadLine());
            float number2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Select an option\ n1.-Add\n2.-Subtract\n3.-Multiply\n4.-Divide");

            int option = int.Parse(Console.ReadLine());

            EvaluateOption(option, number1, number2);
        }
            public static float AddTwoNumbers(float n1, float n2)
        {
            float result = n1 + n2;
            return result;
    }
        public static void EvaluateOption(int option, float n1, float n2)
        {
            if (option == 1)
            {
                Console.WriteLine("Result of addicion: " + AddTwoNumbers(n1,n2));
            }
			else if (option == 2)
			{
				Console.WriteLine("Result of subtraction: " + AddTwoNumbers(n1, n2));
			}
			else if (option == 3)
			{
				Console.WriteLine("Result of multiplying: " + AddTwoNumbers(n1, n2));
			}
			else if (option == 4)
			{
				Console.WriteLine("Result of division: " + AddTwoNumbers(n1, n2));
			}
		}
    }
}
