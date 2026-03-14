using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapTrenLop_BT_Random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Bài tập trên lớp - List sinh viên -> init random sv | SV: Lê Hoàng Hải - 2415053122213 - 225LTC#01");
            Random rand = new Random();
            List<Student> students = new List<Student>();
            string[] faculties = { "Công nghệ số", "Cơ điện tử", "Kinh tế", "Ngoại ngữ" };

            
            int totalStudents = 15;

            for (int i = 1; i <= totalStudents; i++)
            {
                students.Add(new Student
                {
                    Id = "MSSV_" + i.ToString("D3"),
                    Name = "Học viên thứ " + i,
                    Age = rand.Next(18, 25),
                    Faculty = faculties[rand.Next(faculties.Length)],
                    GPA = Math.Round(rand.NextDouble() * 5 + 5, 2),
                    IsFinalYear = rand.Next(0, 2) == 1
                });
            }

            // IN TOÀN BỘ DANH SÁCH ĐỂ KIỂM TRA
            Console.WriteLine($"--- DANH SÁCH KHỞI TẠO: {totalStudents} SINH VIÊN ---");
            foreach (var sv in students)
            {
                string isFinalStr = sv.IsFinalYear ? "Đúng" : "Sai";
                Console.WriteLine($"[{sv.Id}] {sv.Name,-15} | Tuổi: {sv.Age} | Khoa: {sv.Faculty,-15} | ĐTB: {sv.GPA:F1} | Năm cuối: {isFinalStr}");
            }
            Console.WriteLine("------------------------------------------------------------\n");


            // Xử lý các yêu cầu
            int maxAge = students.Max(s => s.Age);
            int minAge = students.Min(s => s.Age);

            bool hasDigitalTechStudent = students.Any(s => s.Faculty == "Công nghệ số");

            var top10DigitalTechGPA = students
                .Where(s => s.Faculty == "Công nghệ số")
                .OrderByDescending(s => s.GPA)
                .Take(10)
                .ToList();

            var notFinalYearStudents = students.Where(s => !s.IsFinalYear).ToList();

            // In kết quả
            Console.WriteLine($"[1]. Độ tuổi cao nhất: {maxAge}  |  Độ tuổi thấp nhất: {minAge}\n");

            string checkDigitalTech = hasDigitalTechStudent ? "Có" : "Không";
            Console.WriteLine($"[2]. Tìm thấy sinh viên khoa Công nghệ số trong list không? => {checkDigitalTech}\n");

            Console.WriteLine("[3]. Danh sách Top 10 sinh viên xuất sắc nhất khoa Công nghệ số:");
            if (top10DigitalTechGPA.Count > 0)
            {
                foreach (var sv in top10DigitalTechGPA)
                {
                    Console.WriteLine($"   + [{sv.Id}] {sv.Name} - ĐTB: {sv.GPA}");
                }
            }
            else
            {
                Console.WriteLine("   + (Không có sinh viên nào thuộc khoa này trong lần random này)");
            }
            Console.WriteLine();

            Console.WriteLine($"[4]. Tổng số sinh viên tiếp tục theo học (sau khi lọc bỏ năm cuối): {notFinalYearStudents.Count} người.");

            Console.ReadLine();
        }
    }
}

