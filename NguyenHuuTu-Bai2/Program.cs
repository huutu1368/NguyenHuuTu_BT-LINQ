using System;
using System.Linq;
using System.Collections.Generic;
class Bai2
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nguyen Huu Tu // 2415053122346 // 225LTC03");
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
        Console.WriteLine("Danh sach cac phan tu:");
        foreach (var pt in numbers)
        {
            Console.Write(pt + " ");
        }
        var ds = numbers.Where(p => p > 5);
        Console.WriteLine("\nDanh sach cac so lon hon 5 la:");
        foreach (var sc in ds)
        {
            Console.Write(sc + " ");
        }
    }
}