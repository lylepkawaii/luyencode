using System;

namespace DEMTU
{
    class LYDEMTU
    {
        static void Main(string[] args)
        {
            string str; /* Khai bao mot chuoi */
            int bien_dem, l;
            Console.Write("");
            str = Console.ReadLine();
            l = 0;
            bien_dem = 1;
            /* lap toi phan cuoi cua chuoi */
            while (l <= str.Length - 1)
            {
                /* kiem tra xem ky tu hien tai co phai la khoang trang 
                 * hay la ky tu new line hay ky tu tab */
                if (str[l] == ' ' || str[l] == '	')
                {
                    bien_dem++;
                }

                l++;
            }

            Console.Write( bien_dem); 
            Console.ReadKey();
        }
    }
}
