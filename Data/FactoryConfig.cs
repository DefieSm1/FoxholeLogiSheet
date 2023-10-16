namespace FoxholeLogiSheet.Data
{
	public class FactoryConfig
	{
		public List<string> LoadedCategories { get; set; }

		public List<string> FactoryCategories { get; set; }

		public List<string> MPFCategories { get; set; }

		public List<string> MaterialKeys { get; set; }

		public string DefaultMode { get; set; }

		public string DefaultCategory { get; set; }

		public FactoryConfig() {
			LoadedCategories = new List<string>();
			FactoryCategories = new List<string>();
			MPFCategories = new List<string>();
			MaterialKeys = new List<string>();

			DefaultMode = "";
			DefaultCategory = "";
		}
	}
}
