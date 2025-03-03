using System;
using System.IO;
 
public class GFG {
    // Using main() function
    public static void Main()
    {
        // Specifying a file
        String myfile = @"file.txt";
 
        // Calling the Delete() function to
        // delete the file file.txt
        File.Delete(myfile);
 
        // Printing a line
        Console.WriteLine("Specified file has been deleted");
    }
}