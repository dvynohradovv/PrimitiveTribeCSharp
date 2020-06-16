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

		//геттеры для обновления информации в винФорм
		public List<string[]> GetTribeListViewData()
		{
			List<string[]> dataList = new List<string[]>(); 
			foreach (var it in dic_Human)
			{
				dataList.Add (new string[] 
				{ 
					Convert.ToString(it.Key), 
					it.Value.Characteristics.Name.FullName, 
					it.Value.CurrJob.ToString(), 
					it.Value.Gender
				});
			}
			return dataList;
		}
		public string[] GetHumanCharacteristicListViewData(int index)
		{
			string[] dataStr = (new string[]
			{
				Convert.ToString(dic_Human[index].Characteristics.Strength),
				Convert.ToString(dic_Human[index].Characteristics.Agility),
				Convert.ToString(dic_Human[index].Characteristics.Intelligence),
				Convert.ToString(dic_Human[index].Characteristics.Luck),
				Convert.ToString(dic_Human[index].efficiency)
			});
			return dataStr;
		}
		public string[] GetTribeResourcesData()
		{
			string[] dataStr = (new string[]
			{
				Convert.ToString(tribeResources.GetResourceQuantity(ResourceEnum.Food)),
				Convert.ToString(tribeResources.GetResourceQuantity(ResourceEnum.Wood)),
				Convert.ToString(tribeResources.GetResourceQuantity(ResourceEnum.Stone)),
				Convert.ToString(tribeResources.GetResourceQuantity(ResourceEnum.AnimalSkin)),
				Convert.ToString(tribeResources.GetResourceQuantity(ResourceEnum.Medicines))
			});
			return dataStr;
		}

		//методы класса для взаимодействия с классом Human\dic_Human
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


		//методы для взаимодействия с ресурсами племени
		

		//объекты класса
		private SortedDictionary<int, Human> dic_Human = new SortedDictionary<int, Human>();
		private TribeResources tribeResources = new TribeResources();
		private static Leader leader = null;
	}
	class TribeResources 
	{
		public Resource GetResource(ResourceEnum resourceEnum)
		{
			return dic_tribeResources[resourceEnum];
		}
		public int GetResourceQuantity(ResourceEnum resourceEnum)
		{
			return dic_tribeResources[resourceEnum].Quantity;
		}

		private Dictionary<ResourceEnum, Resource> dic_tribeResources = new Dictionary<ResourceEnum, Resource>()
		{
			{ ResourceEnum.Food, new Food() },
			{ ResourceEnum.Wood, new Wood() },
			{ ResourceEnum.Stone, new Stone() },
			{ ResourceEnum.AnimalSkin, new AnimalSkin() },
			{ ResourceEnum.Medicines, new Medicines() },
			{ ResourceEnum.TribalStrength, new TribalStrength() },
			{ ResourceEnum.TribalPrestige, new TribalPrestige() }
		};
		public void AddResource(Resource resource)
		{
			dic_tribeResources[resource.ResourceType].AddTo(resource.Quantity);
		}
	}
}
