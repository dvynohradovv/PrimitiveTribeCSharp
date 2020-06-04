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
		public Human (string gender)
		{
			_gender = gender;
		}
		public Human(int index, string gender)
		{
			_currHumanIndex = index;
			_gender = gender;
		}
		public string GetGender { get => _gender; }
		public int GetCurrIndex { get => _currHumanIndex; }
		public static int GetNewIndex { get => _humansIndex; }

		protected string _gender;
		protected static int _humansIndex = 0;
		protected int _currHumanIndex = 0;
		//protected Characteristics characteristics;
	}
	class NoClassHuman : Human
	{
		public NoClassHuman(string gender) : base (gender)
		{
			_currHumanIndex = _humansIndex;
			_humansIndex++;
		}
	}

	class Characteristics
	{
		protected void SetCharacteristics(string gender)
		{

		}
		private byte _strength;
		private byte _agility;
		private byte _intelligence;
	}




}
