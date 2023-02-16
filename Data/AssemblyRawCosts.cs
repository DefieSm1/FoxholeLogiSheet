namespace FoxholeLogiSheet.Data
{
	public class AssemblyRawCosts
	{
		public int SalvageCost { get; set; }

		public int ComponentCost { get; set; }

		public int SulfurCost { get; set; }

		public int CoalCost { get; set; }

		public int OilCost { get; set; }

		public int WaterCost { get; set; }

		public AssemblyRawCosts()
		{
			SalvageCost = 0;
			ComponentCost = 0;
			SulfurCost = 0;
			CoalCost = 0;
			OilCost = 0;
			WaterCost = 0;
		}
	}
}
