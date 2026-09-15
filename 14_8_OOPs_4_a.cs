//08.oops

//04. Constructor 
//a.Parameterised 
//seter used to update value 
internal class Student
{

    string name;
    int age;

    public Student(string name, int age )

    {

        this.name = name;
        this.age = age; 
    }
  
    public void setName(string name) { 
        this.name = name; 
    }


    public static void Main(string[] args)
    {

        Student s1 = new Student("Ram", 20);
        Console.WriteLine("Value injiyilaized by param. constructor----"+ s1.name);

        s1.setName("Ramaa");
        Console.WriteLine("value updated by setter----"+ s1.name);






    }

}