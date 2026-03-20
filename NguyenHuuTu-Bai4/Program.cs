using System;
using System.Linq;
using System.Collections.Generic;
class Bai4
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nguyen Huu Tu // 2415053122346 // 225LTC03");
        List<int> numbers = new List<int> { 1,2,3,4,5,6,7,8 };
        Console.WriteLine("Danh sach truoc khi sap xep la:");
        foreach (var sc in numbers)
        {
            Console.Write(sc + " ");
        }
        Console.WriteLine();
        var ds = numbers.OrderByDescending(p => p);
        Console.WriteLine("Danh sach sau khi sap xep giam dan la:");
        foreach (var sc in ds)
        {
            Console.Write(sc + " ");
        }
    }
}