// See https://aka.ms/new-console-template for more information
using System.Linq;
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

namespace MyProject;
public class CtrDtrClass
{
    static void Main(string[] args)
    {

        //[1:38 PM] Vishal Waman
        //Task: Word Frequency Counter

        //Create a C# console application that reads a text file and counts the
        //frequency of each word in the file. The application should display the
        //top N most frequent words.


        string str = "the quick brown fox jumps over the lazy dog and the cat";
        ABC aBC = new ABC();
        aBC.FreCounter(str);

    }
}

public class ABC
{
    public void FreCounter(string str)
    {
        Dictionary<char,int> dic = new Dictionary<char,int>();

        foreach (char c in str)
        {
            int freq = 1;

            if (dic.ContainsKey(c))
            {
                dic[c] = freq + 1;
            }
            else
            {
                dic.Add(c,freq);
            }
        }

        foreach(KeyValuePair<char,int> kvp in dic)
        {
            Console.WriteLine("Key : {0} & Value : {1}", kvp.Key, kvp.Value);
        }
    }
}



