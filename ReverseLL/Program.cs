using System;
using System.Collections.Generic;
public class Program
{
    static void Main(string[] args)
    {
        LinkedList<int> list = new LinkedList<int>();
        list.AddLast(1);
        list.AddLast(2);
        list.AddLast(3);
        var A = list.Reverse();
        foreach (int x in A)
        {
            Console.WriteLine(x);
        }
    }

}