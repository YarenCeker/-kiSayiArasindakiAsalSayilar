using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İkiSayiArasindakiAsalSayilar
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 2; i <= 10000; i++)
            {
                bool SayiasalMi = true;
                for (int bolen = 2; bolen < i; bolen++)
                {
                    if (i % bolen == 0)
                    {
                        SayiasalMi = false;
                        break;
                    }
                }
                if (SayiasalMi)
                {
                    Console.WriteLine(i);
                }
                Console.ReadLine();
            }
        }
    }
