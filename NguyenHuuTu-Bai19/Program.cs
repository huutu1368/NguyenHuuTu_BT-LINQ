using System;
using System.Linq;
using System.Collections.Generic;
class Bai19
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nguyen Huu Tu // 2415053122346 // 225LTC03");
        List<int> numbers = new List<int> { 1, 2, 2, 3, 4, 4, 2, 5 };
        Console.WriteLine("Danh sach cac phan tu:");
        foreach (var pt in numbers)
            Console.Write(pt + " ");
        var group = numbers.GroupBy(pt => pt);
        var ptt = group.OrderByDescending(gr => gr.Count()).FirstOrDefault();
        if (ptt != null)
            Console.WriteLine($"\nPhan tu {ptt.Key} xuat hien nhieu nhat voi {ptt.Count()} lan.");
    }
}
