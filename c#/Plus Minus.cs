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
        var positiveNumbers = 0;
        var negativeNumbers = 0;
        var zeros = 0;

        foreach (int number in arr )
        {
            if ( number < 0 )
            {
                negativeNumbers++;
            } else if ( number > 0 ) { positiveNumbers++; }
            else { zeros++; }
        }

        Console.WriteLine( Convert.ToDouble(positiveNumbers)/ Convert.ToDouble(arr.Count) );
        Console.WriteLine( Convert.ToDouble(negativeNumbers) / Convert.ToDouble(arr.Count) );
        Console.WriteLine( Convert.ToDouble(zeros) / Convert.ToDouble(arr.Count) );
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
