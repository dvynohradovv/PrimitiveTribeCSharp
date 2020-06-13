﻿using System;
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
			_currJob = JobsEnum.Shaman;
		}
		public override void GoToWork(TribeResources tribeResources)
		{
			tribeResources.AddResource(new Medicines(Efficiency()));
			Characteristics.JobsLevelUpdate(JobsEnum.Shaman, _daysOnJob);
		}
		protected override int Efficiency()
		{
			return Characteristics.CalculateEfficiency(LeaderCharacteristics, 0.1, 0.1, 0.7, 0.1);
		}
	}
}
