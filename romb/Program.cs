using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace romb
{
    class Program
    {
        static void Main()
        {
            int i1 = 8, i2 = 8;
            int i3 = 0, i4 = 16;
            for (int a = 0; a <= 8; a++)
            {
                for (int b = 0; b <= 16; b++)
                {
                    if (b == i1 || b == i2) Console.Write("*");
                    else Console.Write(" ");
                }
                Console.Write("\n");
                i1--;
                i2++;
            }
            for (int a = 0; a <= 8; a++)
            {
                for (int b = 0; b <= 16; b++)
                {
                    if (b == i3 || b == i4) Console.Write("*");
                    else Console.Write(" ");
                }
                Console.Write("\n");
                i3++;
                i4--;
            }
            Console.ReadKey();
        }
    }
}
