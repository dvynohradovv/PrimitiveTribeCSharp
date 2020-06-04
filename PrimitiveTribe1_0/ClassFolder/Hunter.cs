using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTribe1_0.ClassFolder
{
	class Hunter : Human
	{
		public Hunter(string new_gender, int new_currHumanIndex)
		{
			_gender = new_gender;
			_currHumanIndex = new_currHumanIndex;
		}
	}
}
