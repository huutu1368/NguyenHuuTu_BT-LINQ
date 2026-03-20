using System;
using System.Linq;
using System.Collections.Generic;
class Bai16
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nguyen Huu Tu // 2415053122346 // 225LTC03");
        List<int> numbers = new List<int> { 1, 2, 2, 3, 4, 4, 5 };
        Console.WriteLine("Danh sach cac phan tu:");
        foreach (var pt in numbers)
            Console.Write(pt + " ");
        var tong = numbers.Sum();
        Console.WriteLine($"\nTong cac phan tu trong danh sach la:{tong}");

    }
}
