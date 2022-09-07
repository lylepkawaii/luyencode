using System;
namespace VL12
{
    class program 
    {
        static void Main (string[] args)
        {
            string s = Console.ReadLine();
            long n = Convert.ToInt32(s);
            if (n==0) Console.Write("INF");
            else
            {
                 for (int i = (int)Math.Abs(n); i >0; i--)
                     if (n% i==0 )
                         Console.Write("{0} ",i);
            }
             Console.Write("");
            
        }
    }
}
