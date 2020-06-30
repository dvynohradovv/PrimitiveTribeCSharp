namespace PrimitiveTribe1_0.ClassFolder
{
	static class SubjectRecipes 
	{
		public static Resource[] MakeHumanRecipe{ get => new Resource[] { new Food(10), new Wood(100), new Stone(100), new AnimalSkin(100), new Medicines(10) }; } 
		public static Resource[] HumanNeedsRecipe{ get => new Resource[] { new Food(5) }; }
	}
	abstract class Resource
	{
		//конструкторы
		public Resource(ResourceEn resourceType)//конструктор по умолчанию
		{
			_resourceType = resourceType;
		}

		public Resource(ResourceEn resourceType, int quantity)
		{
			_resourceType = resourceType;
			_quantity = quantity;
		}

		//геттеры
		public ResourceEn ResourceType { get => _resourceType; }
		public int Quantity { get => _quantity; }

		//методы
		public void AddTo(int add) { _quantity += add; }
		public void UseHowMuch(int use) { _quantity -= use; } 

		private int _quantity = 0;
		//private int _NotEnoughErrorCount = 0;
		private ResourceEn _resourceType;
	}

	class Food : Resource
	{
		public Food() : base(ResourceEn.Food) { } 

		public Food(int quantity) : base(ResourceEn.Food, quantity) 	{ } 
	}
	class Wood : Resource
	{
		public Wood() : base(ResourceEn.Wood) { }
		public Wood(int quantity) : base(ResourceEn.Wood, quantity) { }
	}
	class Stone : Resource
	{
		public Stone() : base(ResourceEn.Stone) { }
		public Stone(int quantity) : base(ResourceEn.Stone, quantity) { }
	}
	class AnimalSkin : Resource
	{
		public AnimalSkin() : base(ResourceEn.AnimalSkin) { }
		public AnimalSkin(int quantity) : base(ResourceEn.AnimalSkin, quantity) { }
	}
	class TribalStrength : Resource
	{
		public TribalStrength() : base(ResourceEn.TribalStrength) { }
		public TribalStrength(int quantity) : base(ResourceEn.TribalStrength, quantity) { }
	}
	class TribalPrestige : Resource
	{
		public TribalPrestige() : base(ResourceEn.TribalPrestige) { }
		public TribalPrestige(int quantity) : base(ResourceEn.TribalPrestige, quantity) { }
	}
	class Medicines : Resource 
	{
		public Medicines() : base(ResourceEn.Medicines) { }
		public Medicines(int quantity) : base(ResourceEn.Medicines, quantity) { }
	}
}
