using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai19
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Bài 19 - Tìm số xuất hiện nhiều nhất | SV: Lê Hoàng Hải - 2415053122213 - 225LTC#01");

            List<int> numbers = new List<int> { 1, 2, 3, 2, 2, 4, 5, 4 };

            Console.WriteLine("Danh sách ban đầu: " + string.Join(", ", numbers));

            var result = numbers.GroupBy(n => n).OrderByDescending(g => g.Count()).Select(g => g.Key).FirstOrDefault();

            Console.WriteLine("\nSố xuất hiện nhiều nhất là: " + result);
        }
    }
}
