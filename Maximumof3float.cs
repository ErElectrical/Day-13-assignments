using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxof3num.Genric
{
    public  class Maximumof3float
    {
        public static float Maximum(float x, float y, float z)
        {
            if (x.CompareTo(y) > 0 && x.CompareTo(z) > 0 ||
                x.CompareTo(y) > 0 && x.CompareTo(z) >= 0 ||
                x.CompareTo(y) >= 0 && x.CompareTo(z) > 0)
            {
                return x;
            }
            if (y.CompareTo(x) > 0 && y.CompareTo(z) > 0 ||
                y.CompareTo(x) > 0 && y.CompareTo(z) >= 0 ||
                y.CompareTo(x) >= 0 && y.CompareTo(z) > 0)
            {
                return y;
            }
            if (z.CompareTo(x) > 0 && z.CompareTo(y) > 0 ||
                z.CompareTo(x) > 0 && z.CompareTo(y) >= 0 ||
                z.CompareTo(x) >= 0 && z.CompareTo(y) > 0)
            {
                return z;
            }
            return x;


        }
    }
}
