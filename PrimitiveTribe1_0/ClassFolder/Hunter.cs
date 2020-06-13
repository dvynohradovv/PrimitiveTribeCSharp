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
			_currJob = JobsEnum.Hunter; 
		}
		public override void GoToWork(TribeResources tribeResources)
		{
			tribeResources.AddResource(new Food(Efficiency()/2));
			tribeResources.AddResource(new AnimalSkin(Efficiency()/2));
			Characteristics.JobsLevelUpdate(JobsEnum.Hunter, _daysOnJob);
		}
		protected override int Efficiency()
		{
			return Characteristics.CalculateEfficiency(LeaderCharacteristics, 0.3, 0.3, 0.2, 0.2);
		}
	}
}
