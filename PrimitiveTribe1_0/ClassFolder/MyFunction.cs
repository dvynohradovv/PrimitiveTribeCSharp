using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTribe1_0.ClassFolder
{
	static class MyFunction
	{
		public static Random rnd = new Random();
		public static int RandomValue()
		{
			return rnd.Next();
		}
		public static int RandomValue(int to)
		{
			return rnd.Next(to+1);
		}
		public static int RandomValue(int from, int to)
		{
			return rnd.Next(from, to + 1);
		}
		public static string RandomValue(List<string> str_list)
		{
			int list_size = str_list.Count() - 1;
			return str_list[RandomValue(list_size)];
		}
	}
}
