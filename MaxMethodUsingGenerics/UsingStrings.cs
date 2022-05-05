using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMethodUsingGenerics
{
    public class UsingStrings
    {
      

            public string MaxValueStrings(string a, string b, string c)
            {
                string max;
                max = a;
                if (b.Length.CompareTo(max.Length) > 0)
                    max = b;
                if (c.Length.CompareTo(max.Length) > 0)
                    max = c;
                return max;

            }
      
    }
}
