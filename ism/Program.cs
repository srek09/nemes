using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
namespace ism
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch asdf = new Stopwatch();
            asdf.Start();
            string[] temp = "99999 999999 999999 999999 9999 999999".Split(' ');
            int[] data = new int[temp.Length];
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = Int32.Parse(temp[i]);
            }
            int X0 = data[0], a = data[1], b = data[2], m = data[3], k = data[4], n = data[5];
            List<int> X = new List<int>(), Y = new List<int>();
            X.Add((a * X0 + b) % m);
            for (int i = 0; i < n - 1; i++)
            {
                X.Add((a * X[i] + b) % m);
                Y.Add(X[i] % k);
            }
            Y.Add(X[9] % k);
            List<int[]> valid = new List<int[]>();
            for (int i = 0; i < Y.Count; i++)
            {
                int temp3 = Y.IndexOf(Y[i], i + 1);
                if (temp3 != -1)
                {
                    valid.Add(new int[] { Y[i], Math.Abs(i - temp3) });
                }
            }
            valid = valid.OrderByDescending(arr => arr[1]).ToList();
            Console.WriteLine(valid[0][0].ToString() + ' ' + valid[0][1]);
            asdf.Stop();
            System.Console.WriteLine("elapsed ms is {0}.", asdf.ElapsedMilliseconds);
        }
    }
}
