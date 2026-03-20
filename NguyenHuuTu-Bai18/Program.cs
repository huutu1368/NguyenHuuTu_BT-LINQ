using System;
using System.Linq;
using System.Collections.Generic;
class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Score { get; set; }
}

class Bai18
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
        var svgroup = students.GroupBy(sv =>
        {
            if (sv.Score >= 8)
                return "Gioi";
            else
                if (sv.Score >= 6)
                return "Kha";
            else
                return "Trung binh";
        });
        foreach (var svingroup in svgroup)
        {
            Console.WriteLine($"Xep loai {svingroup.Key} co {svingroup.Count()} sinh vien:");
            foreach (var sv in svingroup)
            {
                Console.WriteLine($"ID={sv.Id,-5} || Name={sv.Name,-10} || Score={sv.Score,-5}");
            }
        }
    }
}
