using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
			int[] dataInt = (new int[] 
			{ 
				tribeResources.GetResourceQuantity(ResourceEn.Food),
				tribeResources.GetResourceQuantity(ResourceEn.Wood),
				tribeResources.GetResourceQuantity(ResourceEn.Stone),
				tribeResources.GetResourceQuantity(ResourceEn.AnimalSkin),
				tribeResources.GetResourceQuantity(ResourceEn.Medicines)
			});
			string[] dataStr = (new string[]
			{
				Convert.ToString(dataInt[0]),
				Convert.ToString(dataInt[1]),
				Convert.ToString(dataInt[2]),
				Convert.ToString(dataInt[3]),
				Convert.ToString(dataInt[4])
			});
			return dataStr;
		}

		//методы класса для взаимодействия с классом Human\dic_Human
		public bool HasHuman(int index)
		{
			return dic_Human.ContainsKey(index);
		}
		public bool HasSomeClass(JobsEn job)
		{
			foreach(KeyValuePair <int, Human> it in dic_Human)
			{
				if (job == it.Value.CurrJob) return true;
			}
			return false;
		}
		public bool MakeNoClassHuman(string gender, out string message)
		{
			if (tribeResources.HaveEnoughResources(SubjectRecipes.MakeHumanRecipe, out message))
			{
				tribeResources.UseResources(SubjectRecipes.MakeHumanRecipe);
				if (gender == "random")
				{
					gender = MyFunction.RandomValue(new List<string>() { "man", "woman" });
				}
				int tmp_newIndex = Human.NewIndex;
				dic_Human.Add(tmp_newIndex, new NoClassHuman(gender));
				//dic_StarvedToDeathPriority.Add(0, tmp_newIndex);
				return true;
			}
			return false;
		}
		public string GetGender(int index)
		{
			return dic_Human[index].Gender;
		}
		public void AppointTo(int index, JobsEn job)
		{
			Human human = dic_Human[index];
			dic_Human.Remove(index);
			if (human.CurrJob == JobsEn.Leader) leader = null;
			switch (job)
			{
				case JobsEn.Warrior:
					{
						dic_Human.Add(index, new Warrior(human));
						break;
					}
				case JobsEn.Hunter:
					{
						dic_Human.Add(index, new Hunter(human));
						break;
					}
				case JobsEn.Collector:
					{
						dic_Human.Add(index, new Collector(human));
						break;
					}
				case JobsEn.Lumberjack:
					{
						dic_Human.Add(index, new Lumberjack(human));
						break;
					}
				case JobsEn.Fisherman:
					{
						dic_Human.Add(index, new Fisherman(human));

						break;
					}
				case JobsEn.Leader:
					{
						dic_Human.Add(index, new Leader(human));
						leader = (Leader)dic_Human[index];
						break;
					}
				case JobsEn.Shaman:
					{
						dic_Human.Add(index, new Shaman(human));
						break;
					}
				case JobsEn.DiedHuman:
					{
						dic_Human.Add(index, new DiedHuman(human));
						break;
					}
				default: break;
			}
		}
		public void StartNewDay(out string message)
		{
			if (dic_Human.Count == 0) 
			{
				message = "В поселении нету людей! Очень жаль!";
			}
			else
			{
				//int diedPeople = 0;
				List<int> tmp_diedPeople = new List<int>();
				foreach (KeyValuePair<int, Human> it in dic_Human)
				{
				 	it.Value.GoToWork(tribeResources);
				}
				foreach (KeyValuePair<int, Human> it in dic_Human)
				{
					if (tribeResources.HaveEnoughResources(SubjectRecipes.HumanNeedsRecipe, out string tmp_EnoughResourceMessage))
					{ 
						tribeResources.UseResources(SubjectRecipes.HumanNeedsRecipe);
					} 
					else 
					{
						//diedPeople++;
						tmp_diedPeople.Add(GoToDeadHumanByPriorityLevel());
					} 
				}
				if (tmp_diedPeople.Count != 0)  
				{    
					message = "Нам не хватает еды! Сегодня умерло от голода: " + tmp_diedPeople.Count.ToString() + " чел.\n";
					foreach (var it in tmp_diedPeople)
					{
						message += "Умер: " + dic_Human[it].Characteristics.Name.FullName + "\n";
						dic_Human.Remove(it);
					}
				} 
				else message = "Всё отлично, у Вас хватает еды!";
			}
			_GlobalDayCounter++;
		}

		//объекты класса
		private SortedDictionary<int, Human> dic_Human = new SortedDictionary<int, Human>();
		private SortedDictionary<int, Human> dic_DiedHuman = new SortedDictionary<int, Human>();
		private TribeResources tribeResources = new TribeResources();
		private static Leader leader = null;
		int _GlobalDayCounter = 0;

		//private методы
		private int GoToDeadHumanByPriorityLevel() 
		{
			int tmp_rankPriorityLevel = 0;
			//bool tmp_loop = true;
			while(tmp_rankPriorityLevel <= 4 /*&& tmp_loop*/) 
			{
				foreach (var it in dic_Human)
				{
					if(it.Value.RankPriorityLevel == tmp_rankPriorityLevel)
					{
						it.Value.RankPriorityLevel = -1;
						dic_DiedHuman.Add(it.Key, new DiedHuman(it.Value));
						//tmp_loop = false;
						//break;
						return it.Key;
					}
				}
				tmp_rankPriorityLevel++;
			}
			return -1;
		}
		
	}
	class TribeResources
	{
		//методы взаимодействия с ОДНИМ ресурсом
		public Resource GetDicResources(ResourceEn resourceEnum)
		{
			return dic_tribeResources[resourceEnum];
		}
		public int GetResourceQuantity(ResourceEn resourceEnum)
		{
			return dic_tribeResources[resourceEnum].Quantity;
		}
		public void AddResource(Resource resource)
		{
			dic_tribeResources[resource.ResourceType].AddTo(resource.Quantity);
		}
		public void UseResource(Resource resource)
		{
			dic_tribeResources[resource.ResourceType].UseHowMuch(resource.Quantity);
		}



		//методы взаимодействия с МНОЖЕСТВОМ ресурсами
		public void UseResources(Resource[] weNeedResources)
		{
			foreach (var it in weNeedResources)
			{
				dic_tribeResources[it.ResourceType].UseHowMuch(it.Quantity);
			}
		}
		public bool HaveEnoughResources(Resource[] weNeedResources, out string message)
		{
			bool enoughResource = true;
			string tmp_message = "";
			foreach (var it in weNeedResources) 
			{
				if(GetResourceQuantity(it.ResourceType) < it.Quantity)
				{
					tmp_message += " Вам не хватает ресурса: " + 
						it.ResourceType.ToString() + " " + 
						(GetResourceQuantity(it.ResourceType)- it.Quantity).ToString() + "\n"; 
					enoughResource = false; 
				} 
			} 
			if (tmp_message == "") message = "Успех!"; 
			message = tmp_message; 
			return enoughResource; 
		} 

		//поле класса
		private Dictionary<ResourceEn, Resource> dic_tribeResources = new Dictionary<ResourceEn, Resource>()
		{
			{ ResourceEn.Food, new Food(50) },
			{ ResourceEn.Wood, new Wood(350) },
			{ ResourceEn.Stone, new Stone(350) },
			{ ResourceEn.AnimalSkin, new AnimalSkin(350) },
			{ ResourceEn.Medicines, new Medicines(50) },
			{ ResourceEn.TribalStrength, new TribalStrength() },
			{ ResourceEn.TribalPrestige, new TribalPrestige() }
		};
		
	}
}
