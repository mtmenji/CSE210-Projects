using System;

class Program
{
    static void Main(string[] args)
    {
        
        for(int i=0; i<100; i++) {
            Random random = new Random();
            int index  = random.Next(0,10);
            Console.WriteLine(index);
        }
    }
}