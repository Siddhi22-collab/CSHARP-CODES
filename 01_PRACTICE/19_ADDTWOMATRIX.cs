using System;
public class Exercise19 {
   public static void Main() {
      int i, j, n;
      int[, ] arr1 = new int[20, 20];
      int[, ] arr2 = new int[20, 20];
      int[, ] arr3 = new int[20, 20];
      // setting matrix row and columns size
      n = 3;
      Console.Write("Enter elements in the first matrix:
");
      for (i = 0; i < n; i++) {
         for (j = 0; j < n; j++) {
            arr1[i, j] = Convert.ToInt32(Console.ReadLine());
         }
      }
      Console.Write("Enter elements in the second matrix:
");
      for (i = 0; i < n; i++) {
         for (j = 0; j < n; j++) {
            arr2[i, j] = Convert.ToInt32(Console.ReadLine());
         }
      }
      Console.Write("
First matrix is:
");
      for (i = 0; i < n; i++) {
         Console.Write("
");
         for (j = 0; j < n; j++)
         Console.Write("{0}\t", arr1[i, j]);
      }
      Console.Write("
Second matrix is:
");
      for (i = 0; i < n; i++) {
         Console.Write("
");
         for (j = 0; j < n; j++)
         Console.Write("{0}\t", arr2[i, j]);
      }
      for (i = 0; i < n; i++)
      for (j = 0; j < n; j++)
      arr3[i, j] = arr1[i, j] + arr2[i, j];
      Console.Write("
Adding two matrices: 
");
      for (i = 0; i < n; i++) {
         Console.Write("
");
         for (j = 0; j < n; j++)
         Console.Write("{0}\t", arr3[i, j]);
      }
      Console.Write("

");
   }
}