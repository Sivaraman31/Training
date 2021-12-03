using System;

public class MainClass
{
    public static void Main()
    {
        // Create an object for employee class
        Employee emp = new Employee("ABC", 460, 25000);

        emp.WhoAmI();   // calling WhoAmI function
    }
}


public class User                               // Base class
{
    private string name;                        // Hiding name data with getter and setter

    public User(string name)                    // Constructor that get name as argument
    {
        SetName(name);
    }

    public string GetName()                     // Getter
    {
        return name;
    }

    public void SetName(string name)            // Setter
    {
        this.name = name;
    }
}


public class Education : User                                       // First class that inherits Base class
{
    private int mark;                                               // Hiding name data with getter and setter

    public Education(string name, int mark) : base(name)
    {
        SetMark(mark);                                              // Base => send argument to the base(User) class
    }

    public int GetMark()                                            // Getter
    {
        return mark;
    }

    public void SetMark(int mark)                                   // Setter
    {
        this.mark = mark;
    }
}


class Employee : Education                                                      // Class that Inherits Education class
{
    private int salary;                                                         // Hiding name data with getter and setter

    public Employee(string name, int mark, int salary) : base(name, mark)
    {
        SetSalary(salary);                                                      // Base => send argument to the base(Education) class
    }

    public int GetSalary()                                                      // Getter
    {
        return salary;
    }

    public void SetSalary(int salary)                                           // Setter
    {
        this.salary = salary;
    }

    public void WhoAmI()
    {
        Console.WriteLine($"Hello, {GetName()}! Your Mark is {GetMark()} and Now your salary is {GetSalary()}. ThankYou!");

        /*

            GetName()    => this function called from Base Class
            Getmark()    => this function called from Education class
            GetSalary()  => this function called from Employee class

        */
    }
}
