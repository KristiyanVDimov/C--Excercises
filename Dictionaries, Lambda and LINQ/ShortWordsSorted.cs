using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Short_Words_Sorted
{
	class Program
	{
		static void Main(string[] args)
		{
			char[] separators = new char[] {'.',',',':',';','(',')','[',']','\\','\"','\'','/','!','?',' '};
			var words = Console.ReadLine().ToLower().Split(separators).ToList();

			var result = words.Where(w => w != "").Where(w => w.Length < 5).OrderBy(w => w).Distinct();

			Console.WriteLine(String.Join(", ", result));
		}
	}
}
