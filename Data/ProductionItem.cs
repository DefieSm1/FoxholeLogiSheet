namespace FoxholeLogiSheet.Data
{
	public class ProductionItem
	{
		public string Name { get; set; }

		public string Category { get; set; }

		public string Description { get; set; }

		public string DamageType { get; set; }

		public string AmmoUsed { get; set; }

		public Dictionary<string, List<string>> ItemSpecifics { get; set; }

		public int CrateSize { get; set; }

		public int BmatCost { get; set; }

		public int RmatCost { get; set; }

		public int EmatCost { get; set; }

		public int HematCost { get; set; }

		public int CmatCost { get; set; }

		public int PCmatCost { get; set; }

		public int SteelCost { get; set; }

        public int RareCost { get; set; }

        public int ShieldingCost { get; set; }

        public int SubstanceCost { get; set; }

        public List<int> AssmatCost { get; set; }

        public int HullSegments { get; set; }

        public int ShellPlating { get; set; }

        public int TurbineComponents { get; set; }

        public string BaseVehicle { get; set; }

		public int ProductionTime { get; set; }

		public string Faction { get; set; }

		public string ImportCategory { get; set; }

		public string BuildingType { get; set; }

		public List<string> BuildingUpgrades { get; set; }

		public List<FacilityRecipe> BuildingRecipes { get; set; }

		public ProductionItem()
		{
			Name = "";
			Category = "";
			Description = "";
			DamageType = "";
			ItemSpecifics = new();
			AmmoUsed = "";
			CrateSize = 0;
			BmatCost = 0;
			RmatCost = 0;
			EmatCost = 0;
			HematCost = 0;
			RareCost = 0;
			ShieldingCost = 0;
			SubstanceCost = 0;

			CmatCost = 0;
			PCmatCost = 0;
			SteelCost = 0;
			HullSegments = 0;
			ShellPlating = 0;
			TurbineComponents = 0;
			AssmatCost = new List<int> { 0, 0, 0, 0, 0 };

			BaseVehicle = "";

			ProductionTime = 0;

			Faction = string.Empty;

			ImportCategory = string.Empty;

			BuildingType = "";
			BuildingUpgrades = new();
			BuildingRecipes = new();
		}
	}
}
