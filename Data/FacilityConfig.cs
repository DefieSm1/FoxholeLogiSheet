namespace FoxholeLogiSheet.Data
{
	public class FacilityConfig
	{
		public List<string> LoadedCategories { get; set; }

        public string DefaultBuilding { get; set; }

		public string DefaultUpgrade { get; set; }

        public string DefaultBuildingSet { get; set; }

        public List<string> MaterialKeys { get; set; }

        public int FacilityItemCapacity { get; set; }

        public int FacilityLiquidCapacity { get; set; }

        public int HarvesterItemCapacity { get; set; }

        public FacilityConfig() {
			LoadedCategories = new List<string>();
			DefaultBuilding = string.Empty;
			DefaultUpgrade = string.Empty;
			DefaultBuildingSet = string.Empty;
			MaterialKeys = new List<string>();
			FacilityItemCapacity = 0;
			FacilityLiquidCapacity = 0;
			HarvesterItemCapacity = 0;
		}
	}
}
