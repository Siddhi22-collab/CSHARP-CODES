class Program
{
    static void Main(string[] args)
    {        
    	for (int row = 8; row >= 1; --row)
        {
            for (int col = 1; col <= row; ++col)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
        Console.ReadLine();
    }
}        