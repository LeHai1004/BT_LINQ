using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai15
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Bài 15 - Loại bỏ phần tử trùng | SV: Lê Hoàng Hải - 2415053122213 - 225LTC#01");

            List<int> numbers = new List<int> { 1, 2, 2, 3, 4, 4, 5 };

            Console.WriteLine("Danh sách ban đầu: " + string.Join(" ", numbers));

            var result = numbers.Distinct();

            Console.WriteLine("\nKết quả sau khi loại bỏ phần tử trùng: " + string.Join(" ", result));
        }
    }
}
