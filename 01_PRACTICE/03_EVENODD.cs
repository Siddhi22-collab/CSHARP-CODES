using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Text;  
using System.Threading.Tasks;  
namespace ConsoleApplication1  
{  
    class CalcAvgPerc  
    {  
        static void Main(string[] args)  
        {  
            int num1 = 100;  
            for (int i = 1; i <= num1; i++)  
            {  
                if (i % 2 == 0)  
                {  
                    Console.WriteLine("Number {0} is Even", i);  
                }  
                else  
                {  
                    Console.WriteLine("Number {0} is odd", i);  
                }  
            }  
            Console.ReadKey();  
        }  
    }  
}
