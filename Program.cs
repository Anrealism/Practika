using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSA_Pracrice
{
    class Program
    {
        static void Main(string[] args)
        {
             double NOD(double e, double fi)
            {
                if (e == fi)
                    return e;
                else
                    if (e > fi)
                    return NOD(e - fi, fi);
                else
                    return NOD(fi - e, e);
            }

            int simple(int n)
            {
                for (int i = 2; i <= n / 2; i++) if ((n % i) == 0) return 0;
                return 1;
            }

            {
                Console.WriteLine("Введите числа p q:");
                int p = int.Parse(Console.ReadLine());
                int q = int.Parse(Console.ReadLine());
                double n = p * q;
                Console.WriteLine("Значение n:" + n.ToString());
                double fi = (p - 1) * (q - 1);
                Console.WriteLine("Значение fi:" + fi.ToString());
                int g = 0;
                int e1 = 0;
                double e = 0;
                for (int i = 0; i < fi; i++)
                {
                    e1++;
                    if (simple(e1) == 1)
                        if (e1 < fi)
                            if (NOD(e1, fi) == 1)
                            { g++; e = e1; }
                }
                Console.WriteLine("Всего значений e:" + g);
                Console.WriteLine("Значение e = " + e);
                double d = 0;
                int h = 0;
                while (h < 5)
                {
                    if ((d * e) % n == 1)
                    {
                        h++;
                        Console.WriteLine("Одно из 5 значений d:" + d);
                        d++;
                    }

                    else d++;
                }

                Console.WriteLine("Пример открытого ключа: {" + e + "," + n + "}");
                Console.WriteLine("Пример закрытого ключа: {" + d + "," + n + "}");
                Console.ReadKey();

            }
        }
    }
}
    

