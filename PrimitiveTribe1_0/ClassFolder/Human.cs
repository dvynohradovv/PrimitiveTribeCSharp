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
		//public Human(string new_gender, int new_currHumanIndex)
		//{
		//	_gender = new_gender;
		//	_currHumanIndex = new_currHumanIndex;
		//}
		protected string _gender;
		protected int _currHumanIndex = 0;
	}

	class NoClassHuman
	{
		public NoClassHuman(string new_gender)
		{
			_gender = new_gender;
			_humanIndex++;
		}
		public string GetGender() { return _gender; }
		static public int GetIndex() { return _humanIndex; }
		private string _gender;
		static private int _humanIndex = 0;
	}
}
