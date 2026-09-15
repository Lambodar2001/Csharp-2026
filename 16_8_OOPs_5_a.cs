//08.oops

//05. Memory management 

//a.Value type and refrance type  
using System;

struct Employee
{
    public string name;
    public int salary;
}

internal class Student
{

    string name;
    int age;


   


    public static void Main(string[] args)
    {

        //struct- value type 

        Employee employee1 = new Employee();

        employee1.name = "ram";
        employee1.salary = 25;

        Employee employee2 = employee1;
        employee1.name = "ram-changed";


        Console.WriteLine(employee1.name);




        Console.WriteLine("------------");


        Student s1 = new Student();
        s1.name = "Rahule";
        s1.age = 1;

        Student s2 = s1;

        s2.name = "Ram";

        Console.WriteLine(s1.name);
        Console.WriteLine(s2.name);
        





    }

}