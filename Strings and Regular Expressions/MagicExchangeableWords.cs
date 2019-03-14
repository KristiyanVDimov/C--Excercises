using System;
using System.Collections.Generic;
using System.Linq;

namespace Magic_exchangeable_words
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            var str1 = input[0];
            var str2 = input[1];

            Console.WriteLine(AreExchangeable(str1, str2).ToString().ToLower());
        }

        static bool AreExchangeable(string str1, string str2)
        {
            var end = Math.Min(str1.Length, str2.Length);
            var exchangeableDict = new Dictionary<char, char>();
            bool areExchangeable = false;

            for (int i = 0; i < end; i++)
            {
                var letter1 = str1[i];
                var letter2 = str2[i];
                if (!exchangeableDict.ContainsKey(letter1) && !exchangeableDict.ContainsValue(letter2))
                {
                    exchangeableDict.Add(letter1, letter2);
                }
                else
                {
                    if (exchangeableDict.Keys.Contains(letter1) && exchangeableDict.Values.Contains(letter2))
                    {
                        areExchangeable = true;
                    }
                    else
                    {
                        return false;
                    }
                }

                //if(exchangeableDict.Count == end)
                //{
                //    areExchangeable = true;
                //}
            }

            if (str1.Length < str2.Length)
            {
                for (int i = end; i < str2.Length; i++)
                {
                    var letter2 = str2[i];
                    if (exchangeableDict.ContainsValue(letter2))
                    {
                        areExchangeable = true;
                    }
                    else
                    {
                        areExchangeable = false;
                        break;
                    }
                }
            }
            else
            {
                for (int i = end; i < str1.Length; i++)
                {
                    var letter1 = str1[i];
                    if (exchangeableDict.ContainsKey(letter1))
                    {
                        areExchangeable = true;
                    }
                    else
                    {
                        areExchangeable = false;
                        break;
                    }
                }
            }

            return areExchangeable;
        }
    }


}
