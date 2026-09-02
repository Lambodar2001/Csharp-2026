// 04. Nested for loop pattern print
internal class Program
{
    private static void Main(string[] args)
    {
       
        // Pattern 1:
        // *****
        // *****
        // *****
        // *****

        for (int i = 1; i <= 4; i++)
        {
            for (int j = 1; j <= 5; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }


        // Pattern 2:
        // *
        // **
        // ***
        // ****

        for (int i = 1; i <= 4; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}