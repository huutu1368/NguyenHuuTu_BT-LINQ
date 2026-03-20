using System;
using System.Linq;
using System.Collections.Generic;
class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Score { get; set; }
}
class Bai8
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nguyen Huu Tu // 2415053122346 // 225LTC03");
        List<Student> students = new List<Student>() {
            new Student { Id = 1, Name = "An", Score = 8 },
            new Student { Id = 2, Name = "Binh", Score = 6 },
            new Student { Id = 3, Name = "Chi", Score = 9 },
            new Student { Id = 4, Name = "Dung", Score = 7 } };
        var dssv = students.Where(p => p.Score >= 8);
        Console.WriteLine("Danh sach sinh vien co diem >=8 la:");
        foreach (var sv in dssv)
            Console.WriteLine($"ID={sv.Id,-3} || Name={sv.Name,-3} || Score={sv.Score,-3}");
    }
}
