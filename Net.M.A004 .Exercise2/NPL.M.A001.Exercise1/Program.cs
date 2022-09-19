using System;

namespace NPL.M.A001.Exercise1
{
    class Program
    {
        // y = 2x3 – 6x2 + 2x -1
        static void Main(string[] args)
        {
            Console.WriteLine("Giai phuong trinh : y = 2x3 - 6x2 + 2x -1");            
            int x;
            do
            {
                Console.Write("nhap x = ");
            }
            while (!int.TryParse(Console.ReadLine(), out x));            
            Console.WriteLine(" => y = "+ (2*x*x*x - 6*x*x +2*x - 1).ToString());
            Console.ReadLine();
        }
    }
}
