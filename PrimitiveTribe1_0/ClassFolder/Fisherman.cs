using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTribe1_0.ClassFolder
{
	class Fisherman : Human
	{
		public Fisherman(Human human) : base (human.GetCurrIndex, human.GetGender)
		{

		}
	}
}
