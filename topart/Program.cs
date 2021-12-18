using System;
using System.Collections.Generic;
using System.Linq;
namespace topart
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            List<int[]> foldek = new List<int[]>(n);
            List<int> haszon_per_fold = new List<int>();
            for (int i = 0; i < n; i++)
            {
                string[] temp = Console.ReadLine().Split(' ');
                foldek.Add(new int[] { int.Parse(temp[0]), int.Parse(temp[1]) });
            }
            for (int i = 0; i < foldek.Count; i++)
            {
                haszon_per_fold.Add(foldek[i][1] - foldek[i][0]);
            }
            List<int> vetendo = new List<int>();
            int haszon = 0;
            for (int i = 0; i < haszon_per_fold.Count - 1; i++)
            {
                int temp = haszon;
                haszon += haszon_per_fold[i];
                if (temp > haszon && haszon_per_fold[i + 1] < temp - haszon)
                {
                    haszon = temp;
                }
                else
                {
                    vetendo.Add(i + 1);
                }
            }
            haszon_per_fold.Sort();
            System.Console.WriteLine(haszon_per_fold.Last());
            System.Console.WriteLine(vetendo.Min().ToString() + " " + vetendo.Max());
        }
    }
}
