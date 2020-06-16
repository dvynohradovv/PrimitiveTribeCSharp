using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTribe1_0.ClassFolder
{
	class Warrior : Human
	{
		public Warrior(Human human) : base(human.Characteristics)
		{
			_currJob = JobsEnum.Warrior;
		}
		public override void GoToWork(TribeResources tribeResources)
		{
			efficiency = Efficiency();
			tribeResources.AddResource(new TribalStrength(efficiency));
			Characteristics.JobsLevelUpdate(JobsEnum.Warrior, _daysOnJob);
		}

		protected override int Efficiency()
		{
			return Characteristics.CalculateEfficiency(LeaderCharacteristics, JobsEnum.Warrior, 0.5, 0.2, 0.1, 0.2);
		}
	}
}
