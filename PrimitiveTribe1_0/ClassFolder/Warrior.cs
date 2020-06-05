using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTribe1_0.ClassFolder
{
	class Warrior : Human
	{
		public Warrior(Human human) : base(human.GetCurrIndex, human.GetGender, human.GetHumanCharacteristics)
		{

		}
	}
}
