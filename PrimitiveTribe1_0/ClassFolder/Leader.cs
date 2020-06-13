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
			_currJob = JobsEnum.Leader;
		}

		//методы класса
		public override void GoToWork(TribeResources tribeResources)
		{
			tribeResources.AddResource(new TribalPrestige(Efficiency()));
			Characteristics.IncreaseSomeRandom(1, 1);
			Characteristics.JobsLevelUpdate(JobsEnum.Leader, _daysOnJob);
		}
		protected override int Efficiency()
		{
			return Characteristics.CalculateEfficiency(LeaderCharacteristics, 0.3, 0.2, 0.4, 0.1);
		}
	}
}