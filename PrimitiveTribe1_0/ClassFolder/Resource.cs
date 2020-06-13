using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTribe1_0.ClassFolder
{
	abstract class Resource
	{
		public Resource(ResourceEnum resourceType)//конструктор по умолчанию
		{
			_resourceType = resourceType;
		}

		public Resource(ResourceEnum resourceType, int add)
		{
			_resourceType = resourceType;
			_quantity = add;
		}
		public ResourceEnum GetResourceType() { return _resourceType; }
		public int GetQuantity() { return _quantity; }
		public void AddTo(int add) { _quantity += add; }
		public bool UseFrom(int use)
		{
			if ((_quantity - use) < 0)
			{
				return false;
			}
			_quantity -= use;
			return true;
		}
		private int _quantity = 0;
		private ResourceEnum _resourceType;
	}

	class Food : Resource
	{
		public Food() : base(ResourceEnum.Food) { } 

		public Food(int add) : base(ResourceEnum.Food, add) 	{ } 
	}
	class Wood : Resource
	{
		public Wood() : base(ResourceEnum.Wood) { }
		public Wood(int add) : base(ResourceEnum.Wood, add) { }
	}
	class Stone : Resource
	{
		public Stone() : base(ResourceEnum.Stone) { }
		public Stone(int add) : base(ResourceEnum.Stone, add) { }
	}
	class AnimalSkin : Resource
	{
		public AnimalSkin() : base(ResourceEnum.AnimalSkin) { }
		public AnimalSkin(int add) : base(ResourceEnum.AnimalSkin, add) { }
	}
	class TribalStrength : Resource
	{
		public TribalStrength() : base(ResourceEnum.TribalStrength) { }
		public TribalStrength(int add) : base(ResourceEnum.TribalStrength, add) { }
	}
	class TribalPrestige : Resource
	{
		public TribalPrestige() : base(ResourceEnum.TribalPrestige) { }
		public TribalPrestige(int add) : base(ResourceEnum.TribalPrestige, add) { }
	}
	class Medicines : Resource 
	{
		public Medicines() : base(ResourceEnum.Medicines) { }
		public Medicines(int add) : base(ResourceEnum.Medicines, add) { }
	}
}
