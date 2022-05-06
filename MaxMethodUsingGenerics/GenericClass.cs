using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMethodUsingGenerics
{
    public class GenericClass<T> where T : IComparable
    {
        public T firstValue, secondValue, thirdValue;
        public GenericClass(T firstValue, T secondValue, T thirdValue)
        {
            this.firstValue = firstValue;
            this.secondValue = secondValue;
            this.thirdValue = thirdValue;
        }
        public static T MaxValueGeneric<T>(T firstValue, T secondValue, T thirdValue) where T : IComparable<T>
        {
            if ((firstValue.CompareTo(secondValue) > 0 && (firstValue.CompareTo(thirdValue) > 0)) || (firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) > 0) || (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) >= 0))
            {
                return firstValue;
            }
            if ((secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0) || (secondValue.CompareTo(firstValue) >= 0 && secondValue.CompareTo(thirdValue) > 0) || (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) >= 0))
            {
                return secondValue;
            }
            else if ((thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0) || (thirdValue.CompareTo(firstValue) >= 0 && thirdValue.CompareTo(secondValue) > 0) || (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) >= 0))
            {
                return thirdValue;
            }

            return default;
        }
        /*
        public T MaxMethod()
        {
            T max = GenericClass<T>.MaxValueGeneric<T>(T firstValue,this.secondValue,this.thirdValue);
            return max;
        }
        */
    }
}
