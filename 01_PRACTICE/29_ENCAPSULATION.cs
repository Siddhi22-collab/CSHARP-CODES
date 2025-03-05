using System;

public class DemoEncap 
{
    // private variables declared
    // can accessed by
    // public methods of class
    private String studentName;
    private int studentAge;

    public String Name
    {
        get { return studentName; }

        set { studentName = value; }
    }

    // using accessors to get and
    // set the value of studentAge
    public int Age
    {
        get { return studentAge; }

        set { studentAge = value; }
    }
}

class Geeks 
{
    static public void Main()
    {
        DemoEncap obj = new DemoEncap();

        // calls set accessor of the property Name,
        // and pass value
        obj.Name = "Ankita";

        // calls set accessor of the property Age,
        // and pass "21" as value of the
        // standard field 'value'
        obj.Age = 21;

        // Displaying values
        Console.WriteLine(" Name : " + obj.Name);
        Console.WriteLine(" Age : " + obj.Age);
    }
}
