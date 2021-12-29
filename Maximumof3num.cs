using System;
namespace maxof3num.Genric
{
    public class Maximumof3num
    {


        static void Main(string[] args)
        {
            Console.WriteLine("greater number at first position ----- ");
            int x= 100, y= 40, z= 46;
            int result = Maximumof3num.Maximum(x, y, z);
            Console.WriteLine(result);
            Console.WriteLine("greater number at second position  --- ");
            int x1 = 100, y1= 400, z1= 46;
            int result1=Maximumof3num.Maximum(x1, y1, z1);
            Console.WriteLine(result1);
            Console.WriteLine("greater number at third position  --- ");

            int x2 = 233, y2 = 646, z2 = 987;
            int result2=Maximumof3num.Maximum(x2, y2, z2);
            Console.WriteLine(result2);





        }
        public static int Maximum(int x, int y, int z)
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
