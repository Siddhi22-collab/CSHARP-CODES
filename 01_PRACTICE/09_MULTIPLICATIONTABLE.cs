using System;  

public class Exercise6  
{  
    public static void Main()  
    {
        int j, n;  

        Console.Write("\n\n");  // Displaying new lines
        Console.Write("Display the multiplication table:\n");  // Displaying the purpose of the program
        Console.Write("-----------------------------------");  // Displaying a separator
        Console.Write("\n\n");   

        Console.Write("Input the number (Table to be calculated) : ");  // Prompting the user to input a number for the multiplication table
        n = Convert.ToInt32(Console.ReadLine());  // Reading the number entered by the user

        Console.Write("\n");  // Displaying a new line

        for (j = 1; j <= 10; j++)  // Loop to calculate and display the multiplication table of the entered number up to 10
        {
            Console.Write("{0} X {1} = {2} \n", n, j, n * j);  // Displaying the multiplication table entry
        }
    }
}
