using System;
using System.Collections.Generic;
using System.Linq;
namespace lift
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] subs = Console.ReadLine().Split(' ');
            int emeletek = Convert.ToInt32(value: subs[0]);
            int emberek = Convert.ToInt32(value: subs[1]);
            List<int[]> utazas = new List<int[]>();
            for (int i = 0; i < emberek; i++)
            {
                string[] temp = Console.ReadLine().Split(' ');
                utazas.Add(new int[] { Int32.Parse(temp[0]), Int32.Parse(temp[1]) });
            }
            int[] osszesen = new int[emeletek];
            for (int i = 0; i < osszesen.Length; i++)
            {
                for (int j = 0; j < utazas.Count; j++)
                {
                    if (utazas[j][0] <= 1 + i && 1 + i < utazas[j][1])
                    {
                        osszesen[i]++;
                    }
                }
            }
            System.Console.WriteLine(osszesen.Max());
        }
    }
}