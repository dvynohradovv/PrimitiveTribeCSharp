using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTribe1_0.ClassFolder
{
	class Shaman : Human
	{
		public Shaman(Human human) : base(human.Characteristics)
		{
			_rankPriorityLevel = 3;
			_currJob = JobsEn.Shaman;
		}
		public override void GoToWork(TribeResources tribeResources)
		{
			efficiency = Efficiency();
			tribeResources.AddResource(new Medicines(efficiency));
			Characteristics.JobsLevelUpdate(JobsEn.Shaman, ref _daysOnJob);
		}
		protected override int Efficiency()
		{
			return Characteristics.CalculateEfficiency(LeaderCharacteristics, JobsEn.Shaman, 0.1, 0.1, 0.7, 0.1);
		}
	}
}
