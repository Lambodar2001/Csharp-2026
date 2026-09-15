//08.oops

//02. Static member
internal class Student
{
    //instance variables
    string name;
    string sirname;

    //static variable
    public static string schoolName = "abc";
    
    //instance method
    public void RetuenFullNameAndSchoolName()
    {
        Console.WriteLine( "this is instcace method");
        Console.WriteLine(this.name + " "+ this.sirname);
        Console.WriteLine(Student.schoolName);
    }


    private static void Main(string[] args)


    {

        Student s1 = new Student();
        s1.name = "Test";
        Console.WriteLine(s1.name);
        s1.RetuenFullNameAndSchoolName();

        Student s2 = new Student();
        s2.name = "Test2";
        Console.WriteLine(s1.name);
        s1.RetuenFullNameAndSchoolName();





    }

}