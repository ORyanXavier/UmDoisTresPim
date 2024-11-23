using System;
 
class Program
{
    static void Main()
    {
        int i = 1; 
 
        while (i <= 40)
        {
            if (i % 4 == 0)
            {
                Console.Write("pim");
            }
            else
            {
                Console.Write(i);
            }
 
            if (i % 4 == 0) 
            {
                Console.WriteLine();
            }
            else
            {
                Console.Write(" ");
            }
 
            i++; 
        }
    }
}