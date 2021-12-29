using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxof3num.Genric
{
    public class fusioninone<T> where T:IComparable
    {
        public T x, y, z;

        public fusioninone(T x, T y, T z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

         public static T Maximum( T x, T y, T z)
        {
            if (x.CompareTo(y) > 0 && x.CompareTo(z) > 0)   
            {
                return x;
            }
            if (y.CompareTo(x) > 0 && y.CompareTo(z) > 0)
            {
                return y;
            }
            if (z.CompareTo(y) >0 && z.CompareTo(x) > 0)
            {
                return z;
            }
            return x;




        }
        public T MaxMethod()
        {
            T max = fusioninone<T>.Maximum(this.x, this.y, this.z);
            return max;
        }

    }
}
