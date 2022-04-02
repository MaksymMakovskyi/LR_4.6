using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter p = new StreamWriter(@"C:\Users\maksi\Desktop\Основи алгоритм. та програм. в електр\ІІ семестр\LR_4.6\rezult");
            float a, x, y;
            p.WriteLine(" РЕЗУЛЬТАТИ РОЗРАХУНКУ");
            for (a = 10; a >= 2; a -= 2f) // Заголовок зовнішнього циклу за а 
            {
                // Початок зовнішнього циклу за а
                p.WriteLine(" a=" + a);
                for (x = 0; x <= 2; x += 0.05f) //Заголовок внутрішнього циклу за х 
                {
                    // Початок внутрішнього циклу з х
                    y = (float)(Math.Pow(a,-x) - Math.Pow(a, -a*x));
                    p.WriteLine(" x= " + x + '\t' + " y= " + y);
                    /* Кінець внутрішнього циклу по х */
                }
                /* Кінець зовнішнього циклу по а */
            }
            p.Close();
            Console.WriteLine("Розрахунки виконано");
        }
    }
}
