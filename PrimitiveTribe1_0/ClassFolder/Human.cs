using System;
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
		public Human (string gender)//Конструктор в случае создания нового человека
		{
			_characteristics = new HumanCharacteristics(gender, _humansIndex);
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
		public HumanCharacteristics LeaderCharacteristics { get => _leaderCharacteristics; } 
		public JobsEnum CurrJob { get => _currJob; } 

		//методы взаимодействия 
		public abstract void GoToWork(TribeResources tribeResources); 

		//статические методы-поля класса
		public static int NewIndex { get => _humansIndex; } 
		private static int _humansIndex = 0;

		//поля класса, которые меняются при переопределении класса
		protected JobsEnum _currJob;
		protected int _daysOnJob = 0;

		//объекты класса
		private HumanCharacteristics _characteristics = new HumanCharacteristics();
		private HumanCharacteristics _leaderCharacteristics = Tribe.Leader == null ? new HumanCharacteristics() : Tribe.Leader.Characteristics;

		//private методы
		protected abstract int Efficiency();

		/*
		 * Я если честно, так и не понял для чего это всё. Запутался чуток, решил переписать. А.С.
		public Tribe Tribe { get => _tribe; }
		public Human Leader { get => Tribe == null ? null : Tribe.Leader; }
		public HumanCharacteristics LeaderCharacteristics { get => Leader == null ? new HumanCharacteristics() : Leader.Characteristics; }
		private Tribe _tribe = null; как мы это инициализируем??
		*/
	}
	class NoClassHuman : Human
	{
		public NoClassHuman(string gender) : base (gender) 
		{
			_currJob = JobsEnum.NoClassHuman;
		}
		protected override int Efficiency()
		{
			throw new NotImplementedException();
		}
		public override void GoToWork(TribeResources tribeResources) { }
		
	}
}
