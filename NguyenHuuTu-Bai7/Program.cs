using System;
using System.Linq;
using System.Collections.Generic;
class Bai7
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
        var kt = numbers.Any(p => p > 10);
        if (kt)
            Console.WriteLine("Danh sach co so lon hon 10");
        else
            Console.WriteLine("Danh sach khong co so lon hon 10");
    }
}
