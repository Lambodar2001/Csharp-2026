//08.oops

//03. class, object , getter , setter , named arguments and paramters


internal class Student
{
    //instance variables
    string name;
    int RollNo;
    int age;
    int className;

    
    
    //setter 

    public void setStudent(string Name,int RollNo,int age , int className )
    {
        this.name = Name;
        this.RollNo = RollNo;
        this.age = age;
        this.className = className;

    }

    public void getStudent()
    {
        Console.WriteLine("name is : ");
        Console.WriteLine(this.name);

        Console.WriteLine("Roll No is : ");
        Console.WriteLine(this.RollNo);

        Console.WriteLine("Age is : ");
        Console.WriteLine(this.age);

        Console.WriteLine("ClassName is : ");
        Console.WriteLine(this.className);
    }

    private static void Main(string[] args)


    {

        Student s1 = new Student();

        Console.WriteLine("Enter name ");
        string name = Console.ReadLine();

        Console.WriteLine("Enter RollNo");
        int RollNo = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter age ");
        int age = int.Parse (Console.ReadLine());

        Console.WriteLine("Enter claaName ");
        int className = int.Parse (Console.ReadLine()); 


        s1.setStudent(Name:name,RollNo, age , className ); // named paramters 
        Console.WriteLine("----------------");
        s1.getStudent();

        




    }

}