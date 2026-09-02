//05. JUMP - Statement
internal class Program
{
    private static void Main(string[] args)
    {
        // BREAK
        for (int i = 1; i <= 5; i++)
        {
            if (i == 3)
            {
                break; // Stops the loop completely
            }

            Console.WriteLine(i);
        }


        // CONTINUE
        for (int i = 1; i <= 5; i++)
        {
            if (i == 3)
            {
                continue; // Skips the current iteration
            }

            Console.WriteLine(i);
        }


        // GOTO
        int x = 1;

        if (x == 1)
        {
            goto message; // Jumps to the message label
        }

        Console.WriteLine("This will be skipped");

    message:
        Console.WriteLine("Hello");


        // RETURN
        CheckNumber(5);
    }

    static void CheckNumber(int x)
    {
        if (x < 0)
        {
            return; // Exits the method
        }

        Console.WriteLine("Positive number");
    }
}