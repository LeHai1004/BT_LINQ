using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai16
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Bài 16 - Tính tổng | SV: Lê Hoàng Hải - 2415053122213 - 225LTC#01");

            List<int> numbers = new List<int> { 1, 2, 2, 3, 4, 4, 5 };

            Console.WriteLine("Danh sách ban đầu: " + string.Join(" ", numbers));

            var result = numbers.Sum();

            Console.WriteLine("\nTổng các số trong danh sách: " + result);
        }
    }
}
