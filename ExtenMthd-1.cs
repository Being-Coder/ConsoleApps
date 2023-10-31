//using System;

//namespace MyProject;

//public class CtrDtrClass
//{
//    static void Main(string[] args)
//    {
//        List<int> length = new List<int>() { 1, 2, 3, 4, 5 };
//        length.Print();

//        string str = "pragim";
//        str = str.ToFirstUpper();
//        Console.WriteLine(str);
//    }
//}

//public static class PrintExtension
//{ 
//    public static string ToFirstUpper(this string str)
//    {
//        char[] chars = str.ToCharArray();
//        chars[0] = char.ToUpper(chars[0]);
//        return str = new string(chars);
//    }
//    public static void Print(this List<int> list)
//    {
//        foreach (int i in list)
//        {
//            Console.WriteLine(i);
//        }
//    }
//}
