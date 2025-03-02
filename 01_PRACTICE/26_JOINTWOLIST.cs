using System.Collections.Generic;
using System;

namespace Demo {
   public static class Program {
      public static void Main() {
         var list1 = new List < string > ();
         list1.Add("Keyboard");
         list1.Add("Mouse");

         Console.WriteLine("Our list1....");
         foreach(var p in list1) {
            Console.WriteLine(p);
         }

         var list2 = new List < string > ();
         list2.Add("Hard Disk");
         list2.Add("Pen Drive");

         Console.WriteLine("Our list2....");
         foreach(var p in list2) {
            Console.WriteLine(p);
         }

         list1.AddRange(list2);

         Console.WriteLine("Concatenated list....");
         foreach(var p in list1) {
            Console.WriteLine(p);
         }
      }
   }
}