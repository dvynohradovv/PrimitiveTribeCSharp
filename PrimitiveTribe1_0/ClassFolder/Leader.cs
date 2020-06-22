using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTribe1_0.ClassFolder
{
	class Leader : Human
	{
		//конструктор
		public Leader(Human human) : base(human.Characteristics)
		{
			_rankPriorityLevel = 4;
			_currJob = JobsEn.Leader;
		}

		//методы класса
		public override void GoToWork(TribeResources tribeResources)
		{
			efficiency = Efficiency();
			tribeResources.AddResource(new TribalPrestige(efficiency));
			Characteristics.IncreaseSomeRandom(1, 1);
			Characteristics.JobsLevelUpdate(JobsEn.Leader, ref _daysOnJob);
		}
		protected override int Efficiency()
		{
			return Characteristics.CalculateEfficiency(LeaderCharacteristics, JobsEn.Leader, 0.3, 0.2, 0.4, 0.1);
		}
	}
}