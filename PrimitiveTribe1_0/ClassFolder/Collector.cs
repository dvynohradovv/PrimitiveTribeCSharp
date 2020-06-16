using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTribe1_0.ClassFolder
{
	class Collector:Human
	{
		public Collector(Human human) : base(human.Characteristics)
		{
			_currJob = JobsEnum.Collector;
		}
		public override void GoToWork(TribeResources tribeResources)
		{
			efficiency = Efficiency();
			tribeResources.AddResource(new Stone(efficiency));
			Characteristics.JobsLevelUpdate(JobsEnum.Collector, _daysOnJob);
		}
		protected override int Efficiency()
		{
			return Characteristics.CalculateEfficiency(LeaderCharacteristics, JobsEnum.Collector, 0.3, 0.2, 0.1, 0.4);
		}
	}
}
