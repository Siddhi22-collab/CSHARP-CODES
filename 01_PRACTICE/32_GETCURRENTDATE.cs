using System;
 
class GFG{
 
static public void Main()
{
     
    // Getting the string form of the current date in 
    // a format i.e, 12/04/2021   
    string currentDate1 = DateTime.Now.ToString("MM/dd/yyyy");
       
    // Displaying the current date
    Console.WriteLine("currentDate1 : " + currentDate1);
     
    // Getting the string form of the current date in
    // a format i.e, Saturday, 04 December 2021
    string currentDate2 = DateTime.Now.ToString("dddd, dd MMMM yyyy");
 
    // Displaying the current date
       Console.WriteLine("currentDate2 : " + currentDate2);
 
    // Getting the string form of the current date
    // in a format i.e, December 04                  
    string currentDate3 = DateTime.Now.ToString("MMMM dd");
 
    // Displaying current date      
    Console.WriteLine("currentDate3 : " + currentDate3);
 
    // Getting the string form of the current date 
    // in a format, Saturday, i.e, 04 December 2021 19:12:29          
    string currentDate4 = DateTime.Now.ToString(
        "dddd, dd MMMM yyyy HH:mm:ss");
 
    // Displaying current date      
    Console.WriteLine("currentDate4 : " + currentDate4);
     
    // Getting the string form of the current date 
    // in a format, i.e, 12/04/2021 19:12          
    string currentDate5 = DateTime.Now.ToString("MM/dd/yyyy HH:mm");
 
    // Displaying current date      
    Console.WriteLine("currentDate5 : " + currentDate5);
     
    // Getting the string form of the current date
    // in a format, i.e, 12/04/2021 07:12 PM          
    string currentDate6 = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");
 
    // Displaying current date      
    Console.WriteLine("currentDate6 : " + currentDate6);
     
    // Getting the string form of the current date in 
    // a format,i.e, 12/04/2021 19:12         
    string currentDate7 = DateTime.Now.ToString("MM/dd/yyyy H:mm");
 
    // Displaying current date      
    Console.WriteLine("currentDate7 : " + currentDate7);
     
    // Getting the string form of the current date in 
    // a format, 2021’-‘12’-‘04’T’19’:’12’:’29.6715830+00:00          
    string currentDate8 = DateTime.Now.ToString(
        "yyyy’-‘MM’-‘dd’T’HH’:’mm’:’ss.fffffffK");
 
    // Displaying current date
    Console.WriteLine("currentDate8 : " + currentDate8);
     
    // Getting the string form of the current date in
    // a format, Sat, 04 Dec 2021 19’:’12’:’29 ‘G12T          
    string currentDate9 = DateTime.Now.ToString(
        "ddd, dd MMM yyy HH’:’mm’:’ss ‘GMT");
 
    // Displaying current date      
    Console.WriteLine("currentDate9 : " + currentDate9);
     
    // Getting the string form of the current date in 
    // a format, 2021’-‘12’-‘04’T’19’:’12’:’29          
    string currentDate10 = DateTime.Now.ToString(
        "yyyy’-‘MM’-‘dd’T’HH’:’mm’:’ss");
 
    // Displaying current date      
    Console.WriteLine("currentDate10 : " + currentDate10);
}
}