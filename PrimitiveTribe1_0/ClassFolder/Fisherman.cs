using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTribe1_0.ClassFolder
{
	class Fisherman : Human
	{
		public Fisherman(Human human) : base (human.Characteristics)
		{
			_rankPriorityLevel = 2;
			_currJob = JobsEn.Fisherman;
		}
		public override void GoToWork(TribeResources tribeResources)
		{
			efficiency = Efficiency();
			tribeResources.AddResource(new Food(efficiency));
			Characteristics.JobsLevelUpdate(JobsEn.Fisherman, ref _daysOnJob);
		}

		protected override int Efficiency()
		{
			return Characteristics.CalculateEfficiency(LeaderCharacteristics, JobsEn.Fisherman, 0.2, 0.2, 0.1, 0.5);
		}
	}
}
