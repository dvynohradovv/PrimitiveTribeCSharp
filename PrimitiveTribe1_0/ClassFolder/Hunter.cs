using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTribe1_0.ClassFolder
{
	class Hunter : Human
	{
		public Hunter(Human human) : base(human.Characteristics)
		{
			_rankPriorityLevel = 2;
			_currJob = JobsEn.Hunter; 
		}
		public override void GoToWork(TribeResources tribeResources)
		{
			efficiency = Efficiency();
			tribeResources.AddResource(new Food(efficiency/2));
			tribeResources.AddResource(new AnimalSkin(efficiency/2));
			Characteristics.JobsLevelUpdate(JobsEn.Hunter, ref _daysOnJob);
		}
		protected override int Efficiency()
		{
			return Characteristics.CalculateEfficiency(LeaderCharacteristics, JobsEn.Hunter, 0.3, 0.3, 0.2, 0.2);
		}
	}
}
