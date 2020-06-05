using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimitiveTribe1_0.ClassFolder
{
	abstract class Human
	{
		public Human (string gender)//Конструктор в случае создания нового человека
		{
			_gender = gender;
			_characteristics = new HumanCharacteristics(gender);
		}
		public Human(int index, string gender, HumanCharacteristics characteristics)//Конструктор для переопределения класса
		{
			_currHumanIndex = index;
			_gender = gender;
			_characteristics = characteristics;
		}
		public string GetGender { get => _gender; }
		public int GetCurrIndex { get => _currHumanIndex; }
		public HumanCharacteristics GetHumanCharacteristics { get => _characteristics; }
		public static int GetNewIndex { get => _humansIndex; }


		protected string _gender;
		protected static int _humansIndex = 0;
		protected int _currHumanIndex = 0;
		private HumanCharacteristics _characteristics;
	}
	class NoClassHuman : Human
	{
		public NoClassHuman(string gender) : base (gender)
		{
			_currHumanIndex = _humansIndex;
			_humansIndex++;
		}
	}

	class HumanCharacteristics
	{
		public HumanCharacteristics() 
		{
			_strength = 0;
			_agility = 0;
			_intelligence = 0;
			_luck = 0;
		}
		public HumanCharacteristics(string gender)
		{
			int from = 0, to = 10;
			_strength = MyFunction.RandomValue(to);
			_agility = MyFunction.RandomValue(to);
			_intelligence = MyFunction.RandomValue(to);
			_luck = MyFunction.RandomValue(to);
			if (gender == "man")
			{
				_strength = MyFunction.RandomValue(from, to, 3);
			}
			else if (gender == "woman")
			{
				_agility = MyFunction.RandomValue(from, to, 3);
			}
		}
		private int _strength;
		private int _agility;
		private int _intelligence;
		private int _luck;
	}




}
