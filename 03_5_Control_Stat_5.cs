internal class Program
{
    static void Main(string[] args)
    {
        string again;

        do
        {
            bool validOrder = false;

            Console.WriteLine("\nSelect Pizza:");
            Console.WriteLine("1. Veg Pizza");
            Console.WriteLine("2. Non-Veg Pizza");

            int pizza = int.Parse(Console.ReadLine());

            switch (pizza)
            {
                case 1:
                    Console.WriteLine("Select Flavour:");
                    Console.WriteLine("1. Cheese");
                    Console.WriteLine("2. Corn");

                    int vegFlavour = int.Parse(Console.ReadLine());

                    switch (vegFlavour)
                    {
                        case 1:
                            Console.WriteLine("You selected Veg Cheese Pizza");
                            validOrder = true;
                            break;

                        case 2:
                            Console.WriteLine("You selected Veg Corn Pizza");
                            validOrder = true;
                            break;

                        default:
                            Console.WriteLine("Invalid flavour");
                            break;
                    }
                    break;

                case 2:
                    Console.WriteLine("Select Flavour:");
                    Console.WriteLine("1. Chicken");
                    Console.WriteLine("2. BBQ");

                    int nonVegFlavour = int.Parse(Console.ReadLine());

                    switch (nonVegFlavour)
                    {
                        case 1:
                            Console.WriteLine("You selected Chicken Pizza");
                            validOrder = true;
                            break;

                        case 2:
                            Console.WriteLine("You selected BBQ Pizza");
                            validOrder = true;
                            break;

                        default:
                            Console.WriteLine("Invalid flavour");
                            break;
                    }
                    break;

                default:
                    Console.WriteLine("Invalid pizza choice");
                    break;
            }

            // Cook only when pizza + flavour are valid
            if (validOrder)
            {
                Console.WriteLine("Your pizza is being cooked...");
            }

            Console.Write("Do you want to order again? (yes/no): ");
            again = Console.ReadLine();

        } while (again.ToLower() == "yes");

        Console.WriteLine("Thank you!");
    }
}


//concepts

//1. nested loop, proper break and default statemebt 
//2. do - while loop exit case 