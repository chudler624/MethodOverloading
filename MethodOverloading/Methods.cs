using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class Methods
    {



        public static int Add(int x, int y) 
        {
            return x + y; 
        }

        public static decimal Add(decimal x, decimal y)
        {
            return x + y; 
        }

        public static string Add(int x, int y, bool yes)
        {
            

            var sum = x + y;

            if (yes && sum == 1)
                return $"{sum}+dollar";
            else if (yes && sum >= 2)
                return $"{sum}+dollars";
            else 
                return (x + y).ToString();
        }














    }
}
