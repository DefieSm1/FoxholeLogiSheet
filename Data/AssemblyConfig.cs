namespace FoxholeLogiSheet.Data
{
	public class AssemblyConfig
	{
		public List<string> LoadedCategories { get; set; }

        public string DefaultBuilding { get; set; }

		public string DefaultUpgrade { get; set; }

		public List<string> MaterialKeys { get; set; }

		public List<List<string>> MaterialOutputRows { get; set; }

		public AssemblyConfig() {
			LoadedCategories = new List<string>();
			DefaultBuilding = string.Empty;
			DefaultUpgrade = string.Empty;
			MaterialKeys = new List<string>();
			MaterialOutputRows = new List<List<string>>();
		}
	}
}
