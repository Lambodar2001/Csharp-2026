//08. OPPS
//instance vr static member of classs
internal class Student
{
    string name;
    string sirname;
    public static string schoolName = "abc";
    
    public void RetuenFullName()
    {
        Console.WriteLine( "this is instcace method");
        Console.WriteLine(this.name + " "+ this.sirname);
        Console.WriteLine(Student.schoolName);
    }

    public static void statMethod()
    {
        Console.WriteLine("this is static  method");


    }
    private static void Main(string[] args)


    {

        //Student s1 = new Student();
        //s1.name = "Test";
        //Console.WriteLine(s1.name);
        //s1.RetuenFullName();

        // Student s2 = new Student();
        // s2.name = "Test2";
        // Console.WriteLine(s1.name);
        // s1.RetuenFullName();

        statMethod();



    }

}
