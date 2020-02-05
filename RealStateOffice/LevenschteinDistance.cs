using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealStateOffice
{
    static class LevenschteinDistance
    {
        public static int GetDistance(string s1, string s2)
        {
            int diff;
            int[,] m = new int[s1.Length + 1, s2.Length + 1];

            for (int i = 0; i <= s1.Length; i++) { m[i, 0] = i; }
            for (int j = 0; j <= s2.Length; j++) { m[0, j] = j; }

            for (int i = 1; i <= s1.Length; i++)
            {
                for (int j = 1; j <= s2.Length; j++)
                {
                    diff = (s1[i - 1] == s2[j - 1]) ? 0 : 1;

                    m[i, j] = Math.Min(Math.Min(m[i - 1, j] + 1,
                                             m[i, j - 1] + 1),
                                             m[i - 1, j - 1] + diff);
                }
            }
            return m[s1.Length, s2.Length];
        }
    }
}
