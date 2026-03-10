using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Bài 8 - Lọc sinh viên điểm >= 8 | SV: Lê Hoàng Hải - 2415053122213 - 225LTC#01");

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

            var result = students.Where(s => s.Score >= 8);

            Console.WriteLine("\nKết quả lọc sinh viên giỏi (Điểm >= 8):");
            foreach (var s in result)
            {
                Console.WriteLine("- " + s.Name + " (Điểm: " + s.Score + ")");
            }
        }
    }
}
