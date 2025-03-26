namespace FoxholeLogiSheet.Data
{
	public class FacilityRecipe
	{
		public List<string> InputNames { get; set; }

		public List<ProductionItem> InputItemData { get; set; }

		public List<float> InputAmounts { get; set; }

		public List<string> OutputNames { get; set; }

		public List<ProductionItem> OutputItemData { get; set; }

		public List<float> OutputAmounts { get; set; }

		public float PowerConsumption { get; set; }

		public int ProductionTime { get; set; }

		public string Faction { get; set; }

		public FacilityRecipe()
		{
			InputNames = new();
			InputItemData = new();
			InputAmounts = new();
			OutputNames = new();
			OutputItemData = new();
			OutputAmounts = new();
			PowerConsumption = 0;
			ProductionTime = 0;
			Faction = string.Empty;
		}
	}
}
