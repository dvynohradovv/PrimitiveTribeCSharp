using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTribe1_0.ClassFolder
{
	class Tribe
	{
		private Dictionary<int, Human> dic_Human = new Dictionary<int, Human>();
		public bool HasHuman(int index)
		{
			return dic_Human.ContainsKey(index);
		}
		public void MakeNoClassHuman(string gender)
		{
			if (gender == "random")
			{
				gender = MyFunction.RandomValue(new List<string>() { "man", "woman" });
			}
			dic_Human.Add(Human.GetNewIndex, new NoClassHuman(gender));
		}
		public string GetGender(int index)
		{
			return dic_Human[index].GetGender;
		}
		public void AppointTo(int index, string appointment)
		{
			Human human = dic_Human[index];
			dic_Human.Remove(index);
			switch (appointment)
			{
				case "Warrior":
					{
						dic_Human.Add(index, new Warrior(human));
						break;
					}
				case "Hunter":
					{
						dic_Human.Add(index, new Hunter(human));
						break;
					}
				case "Collector":
					{
						dic_Human.Add(index, new Collector(human));
						break;
					}
				case "Lumberjack":
					{
						dic_Human.Add(index, new Lumberjack(human));
						break;
					}
				case "Fisherman":
					{
						dic_Human.Add(index, new Fisherman(human));
						break;
					}
				default: break;
			}
		}
	}
}
