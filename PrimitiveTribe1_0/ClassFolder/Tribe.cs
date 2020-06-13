using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTribe1_0.ClassFolder
{
	class Tribe
	{
		//статические геттеры-методы
		public static Leader Leader { get => leader; }
		public static Shaman Shaman { get => shaman; }

		//методы класса
		public bool HasHuman(int index)
		{
			return dic_Human.ContainsKey(index);
		}
		public bool HasSomeClass(JobsEnum job)
		{
			foreach(KeyValuePair <int, Human> it in dic_Human)
			{
				if (job == it.Value.CurrJob) return true;
			}
			return false;
		}
		public void MakeNoClassHuman(string gender)
		{
			if (gender == "random")
			{
				gender = MyFunction.RandomValue(new List<string>() { "man", "woman" });
			}
			dic_Human.Add(Human.NewIndex, new NoClassHuman(gender));
		}
		public string GetGender(int index)
		{
			return dic_Human[index].Gender;
		}
		public void AppointTo(int index, JobsEnum job)
		{
			Human human = dic_Human[index];
			dic_Human.Remove(index);
			if (human.CurrJob == JobsEnum.Leader) leader = null;
			if (human.CurrJob == JobsEnum.Shaman) shaman = null;
			switch (job)
			{
				case JobsEnum.Warrior:
					{
						dic_Human.Add(index, new Warrior(human));
						break;
					}
				case JobsEnum.Hunter:
					{
						dic_Human.Add(index, new Hunter(human));
						break;
					}
				case JobsEnum.Collector:
					{
						dic_Human.Add(index, new Collector(human));
						break;
					}
				case JobsEnum.Lumberjack:
					{
						dic_Human.Add(index, new Lumberjack(human));
						break;
					}
				case JobsEnum.Fisherman:
					{
						dic_Human.Add(index, new Fisherman(human));
						break;
					}
				case JobsEnum.Leader:
					{
						dic_Human.Add(index, new Leader(human));
						leader = (Leader)dic_Human[index];
						break;
					}
				case JobsEnum.Shaman:
					{
						dic_Human.Add(index, new Shaman(human));
						shaman = (Shaman)dic_Human[index];
						break;
					}
				default: break;
			}
		}
		public void GoToWork()
		{
			foreach(KeyValuePair<int, Human> it in dic_Human)
			{
				it.Value.GoToWork(tribeResources);
			}
		}

		//объекты класса
		private Dictionary<int, Human> dic_Human = new Dictionary<int, Human>();
		protected TribeResources tribeResources = new TribeResources();
		private static Leader leader = null;
		private static Shaman shaman = null;
	}
	class TribeResources
	{
		//конструктор по умолчанию
		public TribeResources()
		{
			food = new Food();
			wood = new Wood();
			stone = new Stone();
			animalSkin = new AnimalSkin();
			tribalStrength = new TribalStrength();
			tribalPrestige = new TribalPrestige();
			medicines = new Medicines();
		}

		//объекты класса
		private Food food;
		private Wood wood;
		private Stone stone;
		private AnimalSkin animalSkin;
		private TribalStrength tribalStrength;
		private TribalPrestige tribalPrestige;
		private Medicines medicines;

		//методы-адд по ресурсам
		private void AddFood(Food new_food)
		{
			food.AddTo(new_food.GetQuantity());
		}
		private void AddWood(Wood new_wood)
		{
			wood.AddTo(new_wood.GetQuantity());
		}
		private void AddStone(Stone new_stone)
		{
			stone.AddTo(new_stone.GetQuantity());
		}
		private void AddAnimalSkin(AnimalSkin new_animalSkin)
		{
			animalSkin.AddTo(new_animalSkin.GetQuantity());
		}
		private void AddTribalStrength(TribalStrength new_tribalStrength)
		{
			tribalStrength.AddTo(new_tribalStrength.GetQuantity());
		}
		private void AddTribalPrestige(TribalPrestige new_tribalPrestige)
		{
			tribalPrestige.AddTo(new_tribalPrestige.GetQuantity());
		}
		private void AddMedicines(Medicines new_medicines)
		{
			medicines.AddTo(new_medicines.GetQuantity());
		}

		//методы-адд общий ресурс
		public void AddResource(Resource resource)
		{
			if (resource is Food)
			{
				AddFood((Food)resource);
			}
			else if (resource is Wood)
			{
				AddWood((Wood)resource);
			}
			else if (resource is Stone)
			{
				AddStone((Stone)resource);
			}
			else if (resource is AnimalSkin)
			{
				AddAnimalSkin((AnimalSkin)resource);
			}
			else if (resource is TribalStrength)
			{
				AddTribalStrength((TribalStrength)resource);
			}
			else if (resource is TribalPrestige)
			{
				AddTribalPrestige((TribalPrestige)resource);
			}
			else if (resource is Medicines)
			{
				AddMedicines((Medicines)resource);
			}
		}
	}
}
