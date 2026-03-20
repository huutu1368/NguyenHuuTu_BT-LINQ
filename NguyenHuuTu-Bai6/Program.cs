using System;
using System.Linq;
using System.Collections.Generic;
class Bai6
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nguyen Huu Tu // 2415053122346 // 225LTC03");
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
        Console.WriteLine("Danh sach la:");
        foreach (var sc in numbers)
        {
            Console.Write(sc + " ");
        }
        Console.WriteLine();
        var ds = numbers.Where(p => p % 2 == 0);
        var count = ds.Count();
        Console.WriteLine("Danh sach so chan:");
        foreach (var s in ds)
        {
            Console.Write(s + " ");
        }
        Console.WriteLine($"\nSo luong so chan trong danh sach la {count} so");
    }
}