using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxof3num.Genric
{
    public class MaximumGenrics<T> where T:IComparable
    {
        public T[] value;
        // this value is neccessary because it will use to initialize value for our
        // constructor that we will made so that we can preinitialize the methods of our class
        public MaximumGenrics(T[] value)
        {
            value = this.value;
            //using this keyword we can call the class fields/varible which has same name as name of our varible
            // in that particular block.
        }
        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
            // sort method is use to sort the values of array .
            // and returns it . although we can directly use the sort method .
        }
        public T Maxvalue(params T[] values)
        {
            var sorted_values = Sort(values);
            return sorted_values[^1];
            // we use indexing for returning max value
            //[^1] it says that no other than value present at position 1 is accepted.

            //In C#, params is a keyword which is used to specify a parameter that takes variable number of arguments.
            //It is useful when we don't know the number of arguments prior.
            //Only one params keyword is allowed and no additional parameter is permitted after params keyword in a function declaration.
        }
        public T Maxmethod()
        {
            var max = Maxvalue(this.value);
            // main purpose of creating value varible and make it public is that
            // that value will call by any method in it.
            // we return the actual value in this varible while we make constructor for this class.
            return max;
        }
        public void PrintMaxvalue()
        {
            var max = Maxvalue(this.value);
            Console.WriteLine("maximum value we have is " + max);
        }


    }
}
