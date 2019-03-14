using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"[A-Z]{2}[\d+\.\d+]+[a-zA-Z]+\|";
            var tempPattern = @"[\d+\.\d+]+";

            var typeDict = new Dictionary<string, string>();
            var tempDict = new Dictionary<string, double>();

            var input = Console.ReadLine();

            while(input != "end")
            {
                var city = string.Empty;
                var temp = 0.0;
                var weatherType = string.Empty;

                if(Regex.IsMatch(input, pattern))
                {
                    var match = Regex.Match(input, pattern).Value;

                    city = new string(match.Skip(0).Take(2).ToArray());

                    if(Regex.IsMatch(match, tempPattern))
                    {
                        var tempMatch = Regex.Match(match, tempPattern);
                        temp = double.Parse(tempMatch.Value);
                    }

                    var skip = city.Length + temp.ToString().Length;

                    weatherType = new string(match.Skip(skip).Take(match.Length - skip - 1).ToArray());
                }


                if (!typeDict.ContainsKey(city) && !tempDict.ContainsKey(city))
                {
                    typeDict.Add(city, weatherType);
                    tempDict.Add(city, temp);
                }
                else
                {
                    typeDict[city] = weatherType;
                    tempDict[city] = temp;
                }

                input = Console.ReadLine();
            }

            foreach (var temp in tempDict.OrderBy(x => x.Value))
            {
                if(temp.Key != string.Empty)
                     Console.WriteLine($"{temp.Key} => {temp.Value:f2} => {typeDict[temp.Key]}");
            }
        }
    }
}
