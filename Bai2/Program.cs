using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Bài 2 - Lọc số lớn hơn 5 | SV: Lê Hoàng Hải - 2415053122213 - 225LTC#01");

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

            Console.WriteLine("Danh sách ban đầu: " + string.Join(", ", numbers));

            var result = numbers.Where(n => n > 5);

            Console.WriteLine("Kết quả lọc số > 5: " + string.Join(", ", result));
        }
    }
}
