using System;
using System.Linq;
using System.Collections.Generic;
class Bai3
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nguyen Huu Tu // 2415053122346 // 225LTC03");
        List<int> numbers = new List<int> { 8,7,6,5,4,3,2,1 };
        Console.WriteLine("Danh sach truoc khi sap xep la:");
        foreach (var sc in numbers)
        {
            Console.Write(sc + " ");
        }
        Console.WriteLine();
        var ds = numbers.OrderBy(p => p);
        Console.WriteLine("Danh sach sau khi sap xep tang dan la:");
        foreach (var sc in ds)
        {
            Console.Write(sc + " ");
        }
    }
}