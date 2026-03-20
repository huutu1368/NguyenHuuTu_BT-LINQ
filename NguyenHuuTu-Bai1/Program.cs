using System;
using System.Linq;
using System.Collections.Generic;
class Bai1
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nguyen Huu Tu // 2415053122346 // 225LTC03");
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5};
        Console.WriteLine("Danh sach cac phan tu:");
        foreach (var pt in numbers)
        {
            Console.Write(pt + " ");
        }
        var ds = numbers.Where(p => p % 2 == 0);
        Console.WriteLine("\nDanh sach so chan la:");
        foreach (var sc in ds)
        {
            Console.Write(sc + " ");
        }
    }
}