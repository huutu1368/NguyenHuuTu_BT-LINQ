using System;
using System.Linq;
using System.Collections.Generic;
class Bai15
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nguyen Huu Tu // 2415053122346 // 225LTC03");
        List<int> numbers = new List<int> { 1, 2, 2, 3, 4, 4, 5 };
        Console.WriteLine("Danh sach cac phan tu:");
        foreach (var pt in numbers)
            Console.Write(pt + " ");
        var dsnew = numbers.Distinct();
        Console.WriteLine("\nDanh sach sau khi loai bo phan tu trung:");
        foreach (var pt in dsnew)
            Console.Write(pt + " ");

    }
}
