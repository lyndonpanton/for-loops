namespace Exercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int upperBoundary = 0;

            while (true)
            {
                Console.Write("Enter an integer greater than 0: ");
                upperBoundary = Convert.ToInt32(Console.ReadLine());

                if (upperBoundary > 0)
                {
                    break;
                }

                Console.WriteLine("Error: Integer must be greater than 0");
                Console.WriteLine();
            }

            for (int i = 0; i <= upperBoundary; i += 2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            Console.WriteLine("A row of asterisk is about to be printed...");

            int numberOfAsterisks;

            while (true)
            {
                Console.Write("How many asterisks would you like in the row: ");
                numberOfAsterisks= Convert.ToInt32(Console.ReadLine());

                if (numberOfAsterisks > 0)
                {
                    break;
                }

                Console.WriteLine("Error: Input must be greater than 0");
                Console.WriteLine();
            }

            for (int i = 1; i <= numberOfAsterisks; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Output complete");
            Console.WriteLine("Thank you for using this program");
            Console.WriteLine("See more at: https://github.com/lyndonpanton");
        }
    }
}