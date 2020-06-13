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
		public int CurrIndex { get => _currIndex; }
		public int Strength { get => dic_HumanCharacteristics[CharacteristicsEnum.Strength]; private set => dic_HumanCharacteristics[CharacteristicsEnum.Strength] = value; }
		public int Agility { get => dic_HumanCharacteristics[CharacteristicsEnum.Agility]; private set => dic_HumanCharacteristics[CharacteristicsEnum.Agility] = value; }
		public int Intelligence { get => dic_HumanCharacteristics[CharacteristicsEnum.Intelligence]; private set => dic_HumanCharacteristics[CharacteristicsEnum.Intelligence] = value; }
		public int Luck { get => dic_HumanCharacteristics[CharacteristicsEnum.Luck]; private set => dic_HumanCharacteristics[CharacteristicsEnum.Luck] = value; }

		//конструкторы
		public HumanCharacteristics()
		{
			dic_HumanCharacteristics = new Dictionary<CharacteristicsEnum, int>
			{
				{CharacteristicsEnum.Strength, 0 },
				{CharacteristicsEnum.Agility, 0 },
				{CharacteristicsEnum.Intelligence, 0 },
				{CharacteristicsEnum.Luck, 0 }
			};
		}
		public HumanCharacteristics(int str, int aglt, int intel, int luck)
		{
			dic_HumanCharacteristics = new Dictionary<CharacteristicsEnum, int>
			{
				{CharacteristicsEnum.Strength, str },
				{CharacteristicsEnum.Agility, aglt },
				{CharacteristicsEnum.Intelligence, intel },
				{CharacteristicsEnum.Luck, luck }
			};
		}
		public HumanCharacteristics(string gender, int humansIndex)
		{
			_gender = gender;
			_currIndex = humansIndex;

			int from = 0, to = 10;
			Agility = MyFunction.RandomValue(to);
			Luck = MyFunction.RandomValue(to);
			if (gender == "man")
			{
				Intelligence = MyFunction.RandomValue(to);
				Strength = MyFunction.RandomValue(from, to, 3);
			}
			else if (gender == "woman")
			{
				Strength = MyFunction.RandomValue(to);
				Intelligence = MyFunction.RandomValue(from, to, 3);
			}
		}

		//методы
		public int CalculateEfficiency(HumanCharacteristics leader, double coefStr, double coefAg, double coefInt, double coefLuc)
		{
			double strength = (Strength + leader.Strength / 2) * coefStr;
			double agility = (Agility + leader.Agility / 2) * coefAg;
			double intelligence = (Intelligence + leader.Intelligence / 2) * coefInt;
			double luck = (Luck + leader.Luck / 2) * coefLuc;

			return Convert.ToInt32(Math.Round(strength + agility + intelligence + luck));
		}
		public void IncreaseToAll(int value)
		{
			Strength += value;
			Agility += value;
			Intelligence += value;
			Luck += value;
			//dic_HumanCharacteristics[CharacteristicsEnum.Strength] += value;
			//dic_HumanCharacteristics[CharacteristicsEnum.Agility] += value;
			//dic_HumanCharacteristics[CharacteristicsEnum.Intelligence] += value;
			//dic_HumanCharacteristics[CharacteristicsEnum.Luck] += value;
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
		public void JobsLevelUpdate(JobsEnum job, int daysOnJob)
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
		private Dictionary<CharacteristicsEnum, int> dic_HumanCharacteristics = new Dictionary<CharacteristicsEnum, int>();
		private string _gender;
		private int _currIndex;
		private HumanJobsExp humanJobsExp = new HumanJobsExp();
		private HumanSpecialSkills humanSpecialSkills = new HumanSpecialSkills();

		//геттеры-сеттеры других объектов
		public HumanJobsExp GetHumanJobsExp { get => humanJobsExp; }
		public HumanSpecialSkills GetHumanSpecialSkills { get => humanSpecialSkills; }
	}
	class HumanJobsExp
	{
		public HumanJobsExp()
		{
			dic_jobsExp = new Dictionary<JobsEnum, int>
			{
				{JobsEnum.Leader, 0 }, 
				{JobsEnum.Shaman, 0 },
				{JobsEnum.Fisherman, 0 },
				{JobsEnum.Collector, 0 },
				{JobsEnum.Lumberjack, 0 },
				{JobsEnum.Warrior, 0 },
				{JobsEnum.Hunter, 0 }
			};
		}

		//геттеры-сеттеры выполненные методом ENUM
		public int GetJobsExp(JobsEnum jobs)
		{
			return dic_jobsExp[jobs];
		}

		//поля класса
		public void AddToJobsExp(JobsEnum jobs, int value)
		{
			dic_jobsExp[jobs] += value;
		}
		private Dictionary<JobsEnum, int> dic_jobsExp;
	}

	class HumanSpecialSkills
	{

	}

	class HumansNeeds
	{

	}
}
