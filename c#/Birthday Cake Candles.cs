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
using Internal;

class Result
{
    public static int birthdayCakeCandles(List<int> candles)
    {
        int biggestCandle = candles[0];
        int biggestCandleOccurrences = 0;

        foreach (var candle in candles)
        {
            if (candle > biggestCandle)
            {
                biggestCandle = candle;
                biggestCandleOccurrences = 1;
            }
            else if (candle == biggestCandle)
            {
                biggestCandleOccurrences += 1;
            }
        }

        return biggestCandleOccurrences;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();

        int result = Result.birthdayCakeCandles(candles);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
