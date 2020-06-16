namespace PrimitiveTribe1_0.ClassFolder
{
	abstract class Resource
	{
		public Resource(ResourceEnum resourceType)//конструктор по умолчанию
		{
			_resourceType = resourceType;
		}

		public Resource(ResourceEnum resourceType, int quantity)
		{
			_resourceType = resourceType;
			_quantity = quantity;
		}
		public ResourceEnum ResourceType { get => _resourceType; }
		public int Quantity { get => _quantity; }
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

		public Food(int quantity) : base(ResourceEnum.Food, quantity) 	{ } 
	}
	class Wood : Resource
	{
		public Wood() : base(ResourceEnum.Wood) { }
		public Wood(int quantity) : base(ResourceEnum.Wood, quantity) { }
	}
	class Stone : Resource
	{
		public Stone() : base(ResourceEnum.Stone) { }
		public Stone(int quantity) : base(ResourceEnum.Stone, quantity) { }
	}
	class AnimalSkin : Resource
	{
		public AnimalSkin() : base(ResourceEnum.AnimalSkin) { }
		public AnimalSkin(int quantity) : base(ResourceEnum.AnimalSkin, quantity) { }
	}
	class TribalStrength : Resource
	{
		public TribalStrength() : base(ResourceEnum.TribalStrength) { }
		public TribalStrength(int quantity) : base(ResourceEnum.TribalStrength, quantity) { }
	}
	class TribalPrestige : Resource
	{
		public TribalPrestige() : base(ResourceEnum.TribalPrestige) { }
		public TribalPrestige(int quantity) : base(ResourceEnum.TribalPrestige, quantity) { }
	}
	class Medicines : Resource 
	{
		public Medicines() : base(ResourceEnum.Medicines) { }
		public Medicines(int quantity) : base(ResourceEnum.Medicines, quantity) { }
	}
}
