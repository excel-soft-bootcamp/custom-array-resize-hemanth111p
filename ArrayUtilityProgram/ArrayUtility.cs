﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayUtilityProgram
{
    public static class ArrayUtility
    {
        
        public static void Resize( ref int[] array, int newSize)
        {
            
            int[] newArray = array;
            array = new int[newSize];
           for(int i=0;i<newArray.Length;i++)
            {
                array[i] = newArray[i];
            }

            
        

        }
    }
}
    