using System;
using System.Linq;
using System.Collections.Generic;
class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public double GPA4 { get; set; }
    public string Faculty { get; set; }
    public int Year { get; set; }
}

class Bai21
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nguyen Huu Tu // 2415053122346 // 225LTC03");
        List<Student> students = new List<Student>()
        {
            new Student { Id = 1, Name = "An", Age = 20, GPA4 = 3.2, Faculty = "Cong nghe so", Year = 2 },
            new Student { Id = 2, Name = "Binh", Age = 22, GPA4 = 2.5, Faculty = "Ke toan", Year = 4 },
            new Student { Id = 3, Name = "Chi", Age = 19, GPA4 = 3.8, Faculty = "Cong nghe so", Year = 1 },
            new Student { Id = 4, Name = "Dung", Age = 21, GPA4 = 3.0, Faculty = "Cong nghe so", Year = 3 },
            new Student { Id = 5, Name = "Huy", Age = 23, GPA4 = 3.6, Faculty = "Marketing", Year = 4 },
            new Student { Id = 6, Name = "Lan", Age = 20, GPA4 = 3.1, Faculty = "Cong nghe so", Year = 2 },
            new Student { Id = 7, Name = "Minh", Age = 21, GPA4 = 2.8, Faculty = "Ke toan", Year = 3 },
            new Student { Id = 8, Name = "Tuan", Age = 22, GPA4 = 3.5, Faculty = "Cong nghe so", Year = 4 },
            new Student { Id = 9, Name = "Hoa", Age = 19, GPA4 = 3.9, Faculty = "Marketing", Year = 1 },
            new Student { Id = 10, Name = "Nam", Age = 23, GPA4 = 2.6, Faculty = "Cong nghe so", Year = 4 },
            new Student { Id = 11, Name = "Vy", Age = 20, GPA4 = 3.7, Faculty = "Ke toan", Year = 2 },
            new Student { Id = 12, Name = "Khoa", Age = 21, GPA4 = 3.3, Faculty = "Cong nghe so", Year = 3 },
            new Student { Id = 13, Name = "Phuc", Age = 22, GPA4 = 2.9, Faculty = "Marketing", Year = 3 }
        };
        Console.WriteLine("Danh sach sinh vien:");
        foreach (Student sv in students)
            Console.WriteLine($"ID={sv.Id,-5} || Name={sv.Name,-5} || Age={sv.Age,-5}|| " +
                $"GPA4={sv.GPA4,-5} || Faculty={sv.Faculty,-15} || Year={sv.Year,-5}");
        Console.WriteLine("\n1. Max tuoi, Min tuoi");
        var MaxAgeS = students.Max(sv => sv.Age);
        var MinAgeS = students.Min(sv => sv.Age);
        Console.WriteLine($"Tuoi lon nhat la {MaxAgeS} || Tuoi nho nhat la {MinAgeS}");
        Console.WriteLine("\n2. Kiem tra co sinh vien thuoc khoa cong nghe so khong?");
        var checkS = students.Any(sv => sv.Faculty == "Cong nghe so");
        if (checkS)
            Console.WriteLine("Ket qua: Co sinh vien thuoc khoa cong nghe so.");
        else
            Console.WriteLine("Ket qua: Khong co sinh vien thuoc khoa cong nghe so.");
        Console.WriteLine("\n3. Lay 10 sinh vien co diem trung binh cao nhat khoa (CNS)");
        var ListSCNS = students.Where(sv => sv.Faculty == "Cong nghe so");
        var Top10S = ListSCNS.OrderByDescending(sv => sv.GPA4).Take(10);
        Console.WriteLine("Danh sach thong tin sinh vien co diem trung binh cao nhat khoa (CNS):");
        foreach (var sv in Top10S)
            Console.WriteLine($"ID={sv.Id,-5} || Name={sv.Name,-5} || Age={sv.Age,-5}|| " +
                $"GPA4={sv.GPA4,-5} || Faculty={sv.Faculty,-15} || Year={sv.Year,-5}");
        Console.WriteLine("\n4. Bo qua cac sinh vien nam cuoi, lay cac sinh vien con lai.");
        var ListYear123 = students.Where(sv => sv.Year != 4);
        Console.WriteLine("Danh sach thong tin sinh vien nam 1 2 3:");
        foreach (var sv in ListYear123)
            Console.WriteLine($"ID={sv.Id,-5} || Name={sv.Name,-5} || Age={sv.Age,-5}|| " +
                $"GPA4={sv.GPA4,-5} || Faculty={sv.Faculty,-15} || Year={sv.Year}");
    }
}
