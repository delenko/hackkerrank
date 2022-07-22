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

    public static void miniMaxSum(List<int> arr)
    {
        long z = 0, v = 0;
        long[] arr4 = new long[5];
        for(int k = 0; k < arr.Count; k++)
        {
            arr4[k] = Convert.ToInt64(arr.ElementAt(k));
        }
        Array.Sort(arr4);
        List<long> bigArray = arr4.ToList();
        bigArray.RemoveAt(0);
        List<long> smallArray = arr4.ToList();
        smallArray.RemoveAt(smallArray.Count-1);
        foreach(long p in bigArray)
        {
            z += p;
        }
        foreach(long t in smallArray)
        {
            v = v + t;
        }
        Console.WriteLine(v + " "+ z);
    }

}

class Solution
{
    public static void Main(string[] args)
    {

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            Result.miniMaxSum(arr);
        }
}
