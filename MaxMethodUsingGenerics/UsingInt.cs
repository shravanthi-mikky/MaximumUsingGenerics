﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMethodUsingGenerics
{
    public class UsingInt
    {
        public int MaxValueInt(int firstValue, int secondValue, int thirdValue)
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
    }
}
