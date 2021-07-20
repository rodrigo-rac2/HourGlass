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



class Program
{
    public static void Main(string[] args)
    {

        List<List<int>> arr = new List<List<int>>();
        int maxSum = 0;
        List<string> hourGlass = new List<string> { " ", " ", " " };

        for (int i = 0; i < 6; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        for (int x = 0; x < 6; x++)
        {
            for (int y = 0; y < 6; y++)
            {
                if (x + 2 < 6 && y + 2 < 6)
                {
                    int tmpSum = arr[x][y] + arr[x][y + 1] + arr[x][y + 2] + arr[x + 1][y + 1] + arr[x + 2][y] + arr[x + 2][y + 1] + arr[x + 2][y + 2];
                    if (tmpSum > maxSum)
                    {
                        maxSum = tmpSum;
                        hourGlass[0] = arr[x][y] + " " + arr[x][y + 1] + " " + arr[x][y + 2];
                        hourGlass[1] = " " + arr[x + 1][y + 1] + " ";
                        hourGlass[2] = arr[x + 2][y] + " " + arr[x + 2][y + 1] + " " + arr[x + 2][y + 2];
                    }
                }
            }
        }
        Console.WriteLine(maxSum);
        Console.WriteLine(hourGlass[0]);
        Console.WriteLine(hourGlass[1]);
        Console.WriteLine(hourGlass[2]);
    }
}
