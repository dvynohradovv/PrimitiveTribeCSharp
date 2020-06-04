using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTribe1_0.ClassFolder
{
	abstract class MyFunction
	{
		public static Random rnd = new Random();
		public static int RandomDigit()
		{
			return rnd.Next();
		}
		public static int RandomDigit(int to)
		{
			return rnd.Next(to+1);
		}
	}
}
