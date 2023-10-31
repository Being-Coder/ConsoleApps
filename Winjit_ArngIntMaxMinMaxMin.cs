using System.Linq;
using System;
using System.Collections;
using System.Security.Cryptography.X509Certificates;
using System.Net.NetworkInformation;
using System.Text;

namespace MyProject;
class Program
{
    static void Main(string[] args)
    {
        //90, -20, 40, 75, -70, 60, 30, -10, -80, -50
        int[] arr = new int[] { 90, -20, 40, 75, -70, 60, 30, -10, -80, -50 };
        Solution s = new Solution();
        s.ArrangeArray(arr);
    }
}
public class Solution
{

    public void ArrangeArray(int[] arr)
    {
        List<int> list1 = new List<int>();
        List<int> list2 = new List<int>();

        foreach (int i in arr)
        {
            if (i > 0)
            {
                list1.Add(i);
            }
            else
            {
                list2.Add(i);
            }
        }

        list1.Sort();
        list2.Sort();

        list1.Reverse();

        int l1 = list1.Count;
        int l2 = list2.Count;

        int[] res = new int[l1 + l2];

        int j = 0;
        int k = 0;
        for (int i = 0; i < res.Length; i++)
        {
            if (i % 2 == 0)
            {
                res[i] = list1[j++];
            }
            else
            {
                res[i] = list2[k++];
            }
        }

        foreach (int i in res)
        {
            Console.WriteLine(i);
        }
    }
}
