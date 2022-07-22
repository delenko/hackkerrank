using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        double pos = 0, neg = 0, zero = 0;
        foreach(int x in arr)
        {
            if(x>0)
            {
                pos++;
            }
            else if(x<0)
            {
                neg++;
            }
            else
            {
                zero++;
            }
        }
        double posRation = pos / arr.Count;
        double negRation = neg / arr.Count;
        double zeroRation = zero / arr.Count;
        Console.WriteLine(posRation.ToString("0.######"));
        Console.WriteLine(negRation.ToString("0.######"));
        Console.WriteLine(zeroRation.ToString("0.######"));
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
