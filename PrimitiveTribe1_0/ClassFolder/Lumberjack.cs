using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTribe1_0.ClassFolder
{
	class Lumberjack : Human
	{
		public Lumberjack(Human human) : base(human.Characteristics)
		{
			_currJob = JobsEnum.Lumberjack;
		}
		public override void GoToWork(TribeResources tribeResources)
		{
			tribeResources.AddResource(new Wood(Efficiency()));
			Characteristics.JobsLevelUpdate(JobsEnum.Lumberjack, _daysOnJob);
		}
		protected override int Efficiency()
		{
			return Characteristics.CalculateEfficiency(LeaderCharacteristics, 0.4, 0.3, 0.2, 0.1);
		}
	}
}
