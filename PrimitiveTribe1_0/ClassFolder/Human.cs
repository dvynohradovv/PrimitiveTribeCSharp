﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;     
using System.Windows.Forms;

namespace PrimitiveTribe1_0.ClassFolder
{
	abstract class Human
	{
		//конструкторы
		public Human (string gender, Tribe currTribe)//Конструктор в случае создания нового человека
		{
			_characteristics = new HumanCharacteristics(gender, _humansIndex, currTribe);
			_humansIndex++;
		}
		public Human(HumanCharacteristics characteristics)//Конструктор для переопределения класса
		{
			_characteristics = characteristics;
		}

		//геттеры и сеттеры 
		public string Gender { get => _characteristics.Gender; } 
		public int CurrIndex { get => _characteristics.CurrIndex; } 
		public HumanCharacteristics Characteristics { get => _characteristics; } 

		public HumanCharacteristics LeaderCharacteristics { get => _characteristics.CurrTribe.Leader == null ? new HumanCharacteristics() : _characteristics.CurrTribe.Leader.Characteristics; }
		public JobsEn CurrJob { get => _currJob; } 
		public int efficiency { get => _efficiency; set => _efficiency = value; }
		public int RankPriorityLevel { get => _rankPriorityLevel; set => _rankPriorityLevel = value; }

		//методы взаимодействия 
		public abstract void GoToWork(TribeResources tribeResources); 

		//статические методы-поля класса
		public static int NewIndex { get => _humansIndex; } 
		private static int _humansIndex = 0;

		//поля класса, которые меняются при переопределении класса
		protected JobsEn _currJob; 
		protected int _daysOnJob = 1;   
		private int _efficiency = 0;  
		protected int _rankPriorityLevel;
		

		//объекты класса
		private HumanCharacteristics _characteristics = new HumanCharacteristics();

		//private методы
		protected abstract int Efficiency();
	}
	class NoClassHuman : Human 
	{
		public NoClassHuman(string gender, Tribe currTribe) : base (gender, currTribe) 
		{
			_rankPriorityLevel = 0; 
			_currJob = JobsEn.NoClassHuman;
		}
		protected override int Efficiency()
		{
			efficiency = 0;
			return 0;
		}
		public override void GoToWork(TribeResources tribeResources) { }
		
	}

	class DiedHuman : Human
	{
		public DiedHuman(Human human) : base(human.Characteristics)
		{
			_rankPriorityLevel = -1;
			_currJob = JobsEn.DiedHuman;
		}
		protected override int Efficiency()
		{
			efficiency = 0;
			return 0;
		}
		public override void GoToWork(TribeResources tribeResources) { }
	}
}
