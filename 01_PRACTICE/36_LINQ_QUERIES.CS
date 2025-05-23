using System;
using System.Linq;

class Program {
    static void Main() {
        int[] numbers = { 1, 2, 3, 4, 5 };
        var evens = numbers.Where(n => n % 2 == 0).ToList();
        evens.ForEach(Console.WriteLine);
    }
}
