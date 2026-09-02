//06. JUMP - Statement
internal class Program
{
    private static void Main(string[] args)
    {

        int[] arr = { 1, 2, 3, 4 };

        //for (int i = 0; i < arr.Length; i++) {

        //    Console.Write(arr[i]);
        
        //}

        foreach(int iteam in arr)
        {
            Console.WriteLine(iteam+1);
        } 
    }

}