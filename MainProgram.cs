using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxof3num.Genric
{
    public  class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("greater number at first position ----- ");
            int x = 100, y = 40, z = 46;
            int result = Maximumof3nu.Maximum(x, y, z);
            Console.WriteLine(result);
            Console.WriteLine("greater number at second position  --- ");
            int x1 = 100, y1 = 400, z1 = 46;
            int result1 = Maximumof3nu.Maximum(x1, y1, z1);
            Console.WriteLine(result1);
            Console.WriteLine("greater number at third position  --- ");

            int x2 = 233, y2 = 646, z2 = 987;
            int result2 = Maximumof3nu.Maximum(x2, y2, z2);
            Console.WriteLine(result2);
            Console.WriteLine("greater number of float among three number ");
            float x4 = 12.4f, y4 = 23.7f, z4 = 21.67f;
            float result3 = Maximumof3float.Maximum(x4, y4, z4);
            Console.WriteLine(result3);
            Console.WriteLine("greater string among three strings ");
            string x5 = "mohit", y5 = "jaishreeram", z5 = "Mohitamji";
            string result4 = Maximumof3string.Maximum(x5, y5, z5);
            Console.WriteLine(result4);
            Console.WriteLine("let us try fusion in one ");
            int result5 = fusioninone<int>.Maximum( x,y,z);
            Console.WriteLine(result5);
            Console.WriteLine("try fusion in one on float parameter");
            float result6 = fusioninone<float>.Maximum(x4, y4, z4);
            Console.Write(result6);
            Console.WriteLine();
            Console.WriteLine("try fusion in one on string parameter");
            string result7 = fusioninone<string>.Maximum(x5, y5, z5);
            Console.WriteLine(result7);
            Console.WriteLine("Testing the genric class which can take any number of parameter and they may have any datatype");
            int[] arr = { 123, 43,432,786,987 };
            MaximumGenrics<int> gen=new MaximumGenrics<int>(arr);
            gen.PrintMaxvalue();








        }
    }
}
