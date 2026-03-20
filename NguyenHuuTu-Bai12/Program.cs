using System;
using System.Linq;
using System.Collections.Generic;
class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Score { get; set; }
}

class Bai12
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nguyen Huu Tu // 2415053122346 // 225LTC03");
        List<Student> students = new List<Student>() {
            new Student { Id = 1, Name = "An", Score = 8 },
            new Student { Id = 2, Name = "Binh", Score = 6 },
            new Student { Id = 3, Name = "Chi", Score = 9 },
            new Student { Id = 4, Name = "Dung", Score = 7 } };
        Console.WriteLine("Danh sach sinh vien:");
        foreach (Student sv in students)
            Console.WriteLine($"ID={sv.Id,-5} || Name={sv.Name,-10} || Score={sv.Score,-5}");
        var svscore = students.Where(sv => sv.Score >= 7);
        Console.WriteLine($"Danh sach co {svscore.Count()} dat yeu cau (Score>=7):");
        foreach (Student sv in svscore)
            Console.WriteLine($"ID={sv.Id,-5} || Name={sv.Name,-10} || Score={sv.Score,-5}");
    }
}
