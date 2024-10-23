using System.Collections.Generic;

namespace ListArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListInt listInt = new ListInt();
            listInt.Add(1);
            listInt.Add(2);
            listInt.Add(3);
            listInt.Add(4);
            listInt.Add(11, 4, 12, 4, 13);
            Console.WriteLine("Array:" + "[" + listInt.ToString() + "]");
            Console.WriteLine("Contains:" + listInt.Contains(3));
            Console.WriteLine("Pop:" + listInt.Pop());
            Console.WriteLine("Sum:" + listInt.Sum());
            Console.WriteLine("IndexOf:" + listInt.IndexOf(11));
            Console.WriteLine("LastIndexOf:" + listInt.LastIndexOf(4));
            listInt.Insert(6,7);
            Console.WriteLine("Array:" + "[" + listInt.ToString() + "]");
            Console.WriteLine("Average:" + listInt.Average());
        }
        
    }
}
