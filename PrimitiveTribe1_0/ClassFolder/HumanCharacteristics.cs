using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTribe1_0.ClassFolder
{
	class HumanCharacteristics
	{
		//геттеры-сеттеры для характеристик
		public string Gender { get => _gender; }
		public Tribe CurrTribe { get => _currTribe; }
		public int CurrIndex { get => _currIndex; }
		public int Strength { get => dic_HumanCharacteristics[CharacteristicsEn.Strength]; private set => dic_HumanCharacteristics[CharacteristicsEn.Strength] = value; }
		public int Agility { get => dic_HumanCharacteristics[CharacteristicsEn.Agility]; private set => dic_HumanCharacteristics[CharacteristicsEn.Agility] = value; } 
		public int Intelligence { get => dic_HumanCharacteristics[CharacteristicsEn.Intelligence]; private set => dic_HumanCharacteristics[CharacteristicsEn.Intelligence] = value; }   
		public int Luck { get => dic_HumanCharacteristics[CharacteristicsEn.Luck]; private set => dic_HumanCharacteristics[CharacteristicsEn.Luck] = value; }  

		//конструкторы
		public HumanCharacteristics()
		{
			dic_HumanCharacteristics = new Dictionary<CharacteristicsEn, int>
			{
				{CharacteristicsEn.Strength, 0 },
				{CharacteristicsEn.Agility, 0 },
				{CharacteristicsEn.Intelligence, 0 },
				{CharacteristicsEn.Luck, 0 }
			};
		}
		public HumanCharacteristics(int str, int aglt, int intel, int luck)
		{
			dic_HumanCharacteristics = new Dictionary<CharacteristicsEn, int>
			{
				{CharacteristicsEn.Strength, str },
				{CharacteristicsEn.Agility, aglt },
				{CharacteristicsEn.Intelligence, intel },
				{CharacteristicsEn.Luck, luck }
			};
		}
		public HumanCharacteristics(string gender, int humansIndex, Tribe currTribe)
		{
			_gender = gender;
			_currIndex = humansIndex;
			_currTribe = currTribe;

			int from = 0, to = 10; 
			Agility = MyFunction.RandomValue(to);
			Luck = MyFunction.RandomValue(to);
			fullName = new Name(gender);
			if (gender == "man")
			{
				Intelligence = MyFunction.RandomValue(to);
				Strength = MyFunction.RandomValue(from, to, 2);
			}
			else if (gender == "woman")
			{
				Strength = MyFunction.RandomValue(to);
				Intelligence = MyFunction.RandomValue(from, to, 2);
			}
		}

		//методы
		public int CalculateEfficiency(HumanCharacteristics leader, JobsEn job, double coefStr, double coefAg, double coefInt, double coefLuc)
		{
			double strength = (Strength + leader.Strength / 2) * coefStr;
			double agility = (Agility + leader.Agility / 2) * coefAg;
			double intelligence = (Intelligence + leader.Intelligence / 2) * coefInt;
			double luck = (Luck + leader.Luck / 2) * coefLuc; 

			return Convert.ToInt32(Math.Round(strength + agility + intelligence + luck + humanJobsExp.GetJobsExp(job)));
		}
		public void IncreaseToAll(int value)
		{
			Strength += value;
			Agility += value;
			Intelligence += value;
			Luck += value;
		}
		public void IncreaseSomeRandom(int howmuch, int value)
		{
			while (howmuch != 0)
			{
				int rnd = MyFunction.RandomValue(3);
				switch (rnd)
				{
					case 0:
						{
							Strength += value;
							break;
						}
					case 1:
						{
							Agility += value;
							break;
						}
					case 2:
						{
							Intelligence += value;
							break;
						}
					case 3:
						{
							Luck += value;
							break;
						}

				}
				howmuch--;
			}
		}
		public void JobsLevelUpdate(JobsEn job, ref int daysOnJob)
		{
			if (daysOnJob % 7 == 0 && humanJobsExp.GetJobsExp(job) <= 10)
			{
				humanJobsExp.AddToJobsExp(job, 1);
			}
			daysOnJob++;
		}
		public void SetToNull()
		{
			Strength = 0;
			Agility = 0;
			Intelligence = 0;
			Luck = 0;
		}

		//поля класса, которые формирутся один раз для человека и больше не изменяются непосредственным вмешательством 
		//до конца его сущеествования, только по средствам ивентов
		private Dictionary<CharacteristicsEn, int> dic_HumanCharacteristics = new Dictionary<CharacteristicsEn, int>();
		private string _gender;
		private int _currIndex;
		protected Tribe _currTribe = null;

		private HumanJobsExp humanJobsExp = new HumanJobsExp();
		private HumanSpecialSkills humanSpecialSkills = new HumanSpecialSkills();
		private Name fullName = new Name();

		//геттеры-сеттеры других объектов
		public HumanJobsExp HumanJobsExp { get => humanJobsExp; }
		public HumanSpecialSkills HumanSpecialSkills { get => humanSpecialSkills; }
		public Name Name { get => fullName; }
	}
	class Name
	{
		public Name() { }
		public Name(string gender)
		{
			if(gender == "man")
			{
				_name = MyFunction.RandomValue(manName);
				_nickName = MyFunction.RandomValue(manNickName);
			}
			else if (gender == "woman")
			{
				_name = MyFunction.RandomValue(womanName);
				_nickName = MyFunction.RandomValue(womanNickName);
			}
			
		}
		public string FullName { get => _name + " " + _nickName; }

		private string _name; 
		private string _nickName;  

		private static List<string> manName = new List<string> {"Агай", "Атой", "Астро", "Анхан", "Бедро", "Борк", "Бедго", "Варно", "Вер", "Вик", "Деми", "Дордо", "Дакар", "Жихер", "Жарко", "Жосан", "Зид", "Звун", "Имлин", "Корток", "Касти", "Кобро", "Кедо", "Леми", "Логра", "Мирт", "Мегри", "Мыкс", "Мхон", "Нага", "Нехно", "Нурн", "Одри", "Онтар", "Оги", "Ото", "Пакс", "Порто", "Пенди", "Пушту", "Ригви", "Рдана", "Регсо", "Ротк", "Сибр", "Содво", "Свен", "Скарт", "Старх", "Тетри", "Тард", "Тахин", "Тогин", "Тибр", "Уна", "Угло", "Фен", "Хогло", "Цачш", "Черк", "Чодно", "Шегри", "Шкарх", "Штуп", "Шинго", "Юдж", "Юрт", "Эг", "Этро", "Ярен", "Ярст", "Якш", "Якхи" };
		private static List<string> womanName = new List<string> { "Ата", "Арка", "Аста", "Абри", "Айма", "Аха", "Берда", "Борка", "Бискина", "Бугла", "Бола", "Вета", "Виста", "Вежка", "Выгра", "Гидра", "Геска", "Гола", "Дика", "Даста", "Добка", "Дила", "Еая", "Жиста", "Зита", "Зуга", "Йала", "Йоста", "Килха", "Ласта", "Мирта", "Нала", "Йола", "Хаца", "Раса", "Сатра", "Порти", "Скина", "Титра", "Тера", "Тобри", "Тенгри", "Ува", "Фуца", "Фишли", "Фихта", "Хуби", "Хала", "Хоги", "Худива", "Циа", "Цоба", "Цинка", "Цибри", "Чилва", "Чова", "Чхоша", "Шури", "Шисти", "Шуври", "Эая", "Йова", "Йинки", "Эн", "Юста", "Юви", "Юэн", "Югра", "Юхни", "Яста", "Янра", "Ядуга", "Яфеста", "Яшха" };
		private static List<string> manNickName = new List<string> { "Борец", "Великан", "Волелюб", "Высокий", "Гордый", "Грозный", "Гнойный", "Гадкий", "Дикий", "Добрый", "Дурной", "Дельный", "Жесткий", "Злой", "Красивый", "Красный", "Ленивый", "Мощный", "Монстр", "Медведь", "Низкий", "Носорог", "Огр", "Рослый", "Рёв", "Слон", "Скала", "Таурен", "Ханжа", "Храбрый", "Хороший", "Честный", "Чудной", "Широкий", "Шальной", "Юркий", "Яркий", "Бессмертный", "Каменный", "Горький" };
		private static List<string> womanNickName = new List<string> { "Борец", "Великанша", "Волелюбная", "Высокая", "Гордая", "Грозная", "Гнойная", "Гадкая", "Дикая", "Добрая", "Дурная", "Дельная", "Жесткая", "Жестокая", "Злая", "Красивая", "Красная", "Ленивая", "Мощная", "Монстр", "Медведица", "Низкая", "Огр", "Рослая", "Рёв", "Скала", "Ханжа", "Храбрая", "Хорошая", "Честная", "Чудная", "Широкая", "Шальная", "Юркая", "Яркая", "Прекрасная", "Красивая", "Улыбчивая", "Весна", "Хилая", "Стойкая" };
	}
	class HumanJobsExp 
	{
		public HumanJobsExp()
		{
			dic_jobsExp = new Dictionary<JobsEn, int>
			{
				{JobsEn.Leader, 0 }, 
				{JobsEn.Shaman, 0 },
				{JobsEn.Warrior, 0 },
				{JobsEn.Hunter, 0 },
				{JobsEn.Collector, 0 },
				{JobsEn.Lumberjack, 0 },
				{JobsEn.Fisherman, 0 }
			};
		}

		//геттеры-сеттеры выполненные методом ENUM
		public int GetJobsExp(JobsEn jobs)
		{
			if(jobs != JobsEn.NoClassHuman)
			{
				return dic_jobsExp[jobs];
			}
			else
			{
				return 0;
			}
			
		}

		//поля класса
		public void AddToJobsExp(JobsEn jobs, int value)
		{
			dic_jobsExp[jobs] += value;
		}
		private Dictionary<JobsEn, int> dic_jobsExp;
	}
	class HumanSpecialSkills
	{

	}
}
