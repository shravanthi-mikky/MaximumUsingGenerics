using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMethodUsingGenerics
{
    public class Uc5GenericParams<T> where T : IComparable<T>
    {
        public T[] inputArray;
        public Uc5GenericParams(T[] inputArray)
        {
            this.inputArray = inputArray;
        }

        public static T MaxOfMultipleUsingGenerics<T>(params T[] inputArray)
        {
            Array.Sort(inputArray);
            return inputArray[inputArray.Length - 1];
            //return inputArray.Max();
        }
    }
} 
