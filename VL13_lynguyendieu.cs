using System;

namespace VL13
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, sum = 0;
            Console.Write("");
            a = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= a/2; i++)
            {
                if(a % i == 0)
                {
                    sum += i;
                }
            }
            if(sum == a)
            {
                Console.WriteLine("YES", a);
            }
            else
            {
                Console.WriteLine("NO", a);
            }
        }
    }
}
