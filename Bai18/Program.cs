using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai18
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Bài 18 - Nhóm sinh viên theo xếp loại | SV: Lê Hoàng Hải - 2415053122213 - 225LTC#01");

            List<Student> students = new List<Student>()
        {
            new Student{Id=1, Name="An", Score=8},
            new Student{Id=2, Name="Binh", Score=6},
            new Student{Id=3, Name="Chi", Score=9},
            new Student{Id=4, Name="Dung", Score=7}
        };

            Console.WriteLine("Danh sách sinh viên ban đầu:");
            foreach (var s in students)
            {
                Console.WriteLine("- " + s.Name + " (Điểm: " + s.Score + ")");
            }

            var result = students.GroupBy(s => s.Score >= 8 ? "Giỏi" : s.Score >= 6 ? "Khá" : "Trung bình");

            Console.WriteLine("\nKết quả phân nhóm:");
            foreach (var group in result)
            {
                Console.WriteLine("Nhóm " + group.Key + ":");
                foreach (var s in group)
                {
                    Console.WriteLine("  - " + s.Name + " (Điểm: " + s.Score + ")");
                }
            }
        }
    }
}
