using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_big_number
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine().TrimStart('0');
            var multiplier = int.Parse(Console.ReadLine());
            var multiplied = string.Empty;
            number = new string(number.Reverse().ToArray());
            if(multiplier == 0)
            {
                Console.WriteLine(0);
                return;
            }
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                var carry = 0;
                var digit = int.Parse(number[i].ToString());
                sum += digit * multiplier;

                carry = sum % 10;
                sum = sum / 10;

                multiplied += carry.ToString();
            }
            var stringSum = string.Empty;
            if(sum != 0)
            {
                stringSum = new string(sum.ToString().Reverse().ToArray());
                multiplied += stringSum;
            }

            Console.WriteLine(new string(multiplied.Reverse().ToArray()));
        }
    }
}
