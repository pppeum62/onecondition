using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onecondition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x값을 입력하세요 >> ");
            int x = int.Parse(Console.ReadLine());

            if (x > 10 && x < 20)
            {
                Console.WriteLine("조건에 맞습니다.");
            }
        }
    }
}
