using System;

internal class Program
{
    private static void Main(string[] args)
    {

        do {



            string name = Console.ReadLine();

            switch (name)
            {

                case "Ram":
                    Console.WriteLine("welcome ram ");
                    break;

                case "shame":
                    Console.WriteLine("welcome sham ");
                    break;

                case "Sk":
                    Console.WriteLine("welcome Sk ");
                    break;

                case "Pk":
                    Console.WriteLine("welcome pk ");
                    break;

                case "Lp":
                    Console.WriteLine("welcome LP ");
                    break;


                default:
                    Console.WriteLine("Invalid data");
                    break;
            }

        } while (true);


    }
}

