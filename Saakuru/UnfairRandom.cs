using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Saakuru
{
    class UnfairRandom
    {
        private int k;
        private Random r;
        public UnfairRandom(int _k)
        {
            this.k = _k;
            this.r = new Random();
        }

        public int FairRandom()
        {
            return r.Next(1, this.k + 1);
        }

        public int UnfairRandom()
        {
            int k_tri = (k + 1) * k / 2;
            int n = r.Next(1, k_tri + 1);
            return (int)(Math.Sqrt(8 * n + 1) - 1 / 2);
        }
    }
}
