//07. Array 
//02. create and initialize array using user input
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter Size of array");
        int size = int.Parse(Console.ReadLine());

        int[] arr = new int[size];

        for(int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("Enter element at index"+ i);
            int index = int.Parse(Console.ReadLine());
            arr[i] = index; 

        }

        Console.WriteLine("Your array is ");

        foreach (int  item in arr)
        {
            Console.Write(item);
            
        }
    }

}