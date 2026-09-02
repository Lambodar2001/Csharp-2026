//do-while loop

internal class Program
{
    public static void Main(string[] args)
    {
        int choice;

        do
        {
            Console.WriteLine("\n--- Pizza Menu ---");
            Console.WriteLine("1. Order Pizza");
            Console.WriteLine("2. View Menu");
            Console.WriteLine("3. Exit");

            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Pizza Ordered!");
                    break;

                case 2:
                    Console.WriteLine("Margherita - ₹200");
                    Console.WriteLine("Farmhouse - ₹300");
                    break;

                case 3:
                    Console.WriteLine("Thank you!");
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

        } while (choice != 3);
    }
}