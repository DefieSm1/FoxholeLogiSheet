namespace FoxholeLogiSheet.Data
{
	public class FacilityRecipe
	{
		public List<string> InputNames { get; set; }

		public List<int> InputAmounts { get; set; }

		public List<string> OutputNames { get; set; }

		public List<int> OutputAmounts { get; set; }

		public float PowerConsumption { get; set; }

		public int ProductionTime { get; set; }

		public FacilityRecipe()
		{
			InputNames = new();
			InputAmounts = new();
			OutputNames = new();
			OutputAmounts = new();
			PowerConsumption = 0;
			ProductionTime = 0;
		}
	}
}
