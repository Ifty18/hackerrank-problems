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
    public static void miniMaxSum(List<int> arr)
    {
        var minNr = arr[0];
        var maxNr = arr[0];
        long sum = 0;

        foreach (var nr in arr)
        {
            if (nr > maxNr)
            {
                maxNr = nr;
            }

            if (nr < minNr)
            {
                minNr = nr;
            }

            sum += nr;
        }

        Console.WriteLine($"{sum - maxNr} {sum - minNr}");
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
