using System.Diagnostics.Metrics;

//01. For loop 
//02.while loop 
//03.do.. while  loop 
//04.for each loop 

internal class Program
{

    public static void Main(String[] args)
    {

        Console.WriteLine("Enter number to get table ");
        int num = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(num + "x" + i + "=" + num * i);

        }


        // =========================================================
        // EXAMPLE 1: Print numbers from 1 to 10
        // =========================================================

        /*
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
        */


        // =========================================================
        // EXAMPLE 2: Print even numbers from 1 to 20
        // =========================================================

        /*
        for (int i = 2; i <= 20; i = i + 2)
        {
            Console.WriteLine(i);
        }
        */


        // =========================================================
        // EXAMPLE 3: Calculate sum of numbers from 1 to 10
        // =========================================================

        /*
        int sum = 0;

        for (int i = 1; i <= 10; i++)
        {
            sum = sum + i;
        }

        Console.WriteLine("Sum = " + sum);
        */

    }
}