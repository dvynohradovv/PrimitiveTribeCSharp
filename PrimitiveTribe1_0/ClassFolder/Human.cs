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
		protected static int _humansIndex = 0;
		protected int _currHumanIndex = 0;
	}

	class NoClassHuman : Human
	{
		public NoClassHuman(string new_gender)
		{
			_gender = new_gender;
			_currHumanIndex = _humansIndex;
			_humansIndex++;
		}
		public string GetGender() { return _gender; }
		static public int GetNewIndex() { return _humansIndex; }
	}
}
