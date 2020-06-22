using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTribe1_0.ClassFolder
{
	static class MyFunction
	{
		private static Random rnd = new Random();
		public static int RandomValue()
		{
			return rnd.Next();
		}
		public static int RandomValue(int to)//с нуля включительно
		{
			return rnd.Next(to+1);
		}
		public static int RandomValue(int from, int to)
		{
			return rnd.Next(from, to + 1);
		}
		public static int RandomValue(int from, int to, int repeat)
		{
			int[] Values = new int[repeat];
			for(int i = 0; i < repeat; i++)
			{
				Values[i] = MyFunction.RandomValue(from, to);
			}
			return Values.Max();
		}
		public static string RandomValue(List<string> str_list)
		{
			int list_size = str_list.Count() - 1;
			return str_list[RandomValue(list_size)];
		}
		public static JobsEn ParseStringToJobsEnum(string currClass)
		{
			switch (currClass)
			{
				case "NoClassHuman":
					{
						return JobsEn.NoClassHuman;
					}
				case "Leader":
					{
						return JobsEn.Leader;
					}
				case "Shaman":
					{
						return JobsEn.Shaman;
					}
				case "Fisherman":
					{
						return JobsEn.Fisherman;
					}
				case "Collector":
					{
						return JobsEn.Collector;
					}
				case "Lumberjack":
					{
						return JobsEn.Lumberjack;
					}
				case "Warrior":
					{
						return JobsEn.Warrior;
					}
				case "Hunter":
					{
						return JobsEn.Hunter;
					}
				default: return JobsEn.Leader;
			}
		}
	}
}
