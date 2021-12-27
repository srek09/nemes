using System;
using System.Collections.Generic;
namespace birtok
{
    class Feladat
    {
        static void Main(string[] args)
        {
            try
            {
                int birtok_db = Int32.Parse(Console.ReadLine());
                string[] birtokok_temp = Console.ReadLine().Split(' ');
                int[] birtokok = new int[birtokok_temp.Length];
                for (int i = 0; i < birtokok_temp.Length; i++)
                {
                    birtokok[i] = Int32.Parse(birtokok_temp[i]);
                }
                int[] finished = Output(birtokok);
                if (finished.Length > 1)
                {
                    System.Console.WriteLine(finished[0].ToString() + ' ' + finished[1].ToString());
                    System.Console.WriteLine(finished[2].ToString() + ' ' + finished[3].ToString());
                }
                else
                {
                    System.Console.WriteLine(finished[0]);
                }
                return;
            }
            finally
            {
            }
        }
        static int[] Output(int[] birtokok)
        {
            try
            {
                for (int i = birtokok.Length - 2; i >= 0; i--)
                {
                    for (int j = 0; j < birtokok.Length; j++)
                    {
                        if (j != i)
                        {
                            int temp2 = birtokok[i] + birtokok[j];
                            int temp3 = Array.IndexOf(birtokok, temp2);
                            if (temp3 != -1)
                            {
                                return new int[] { temp3 + 1, birtokok[temp3], 1 + i, 1 + j };
                            }
                        }
                    }
                }
            }
            finally { }
            return new int[] { -1 };

        }
    }
}
