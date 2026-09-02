//02.While-loop 

using System.Diagnostics.Metrics;

internal class Program
{

    public static void Main(String[] args)
    {

        int i = -1;

        while(i != 0)
        {
            Console.WriteLine("Enter 0 to get exit");
            i= int.Parse(Console.ReadLine());

        }

        Console.WriteLine("code exited succefully ");

    }
}