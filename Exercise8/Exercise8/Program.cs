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
        }
    }
}