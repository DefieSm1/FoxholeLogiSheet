namespace FoxholeLogiSheet.Data
{
	public class AssemblyVehicleBuildings
	{
		public Dictionary<string, ProductionItem> AssemblyStation { get; set; }

        public Dictionary<string, ProductionItem> AssemblyStationMotorPool { get; set; }

        public Dictionary<string, ProductionItem> AssemblyStationRocket { get; set; }

        public Dictionary<string, ProductionItem> AssemblyStationField { get; set; }

        public Dictionary<string, ProductionItem> AssemblyStationTank { get; set; }

        public Dictionary<string, ProductionItem> AssemblyStationWeapons { get; set; }

        public Dictionary<string, ProductionItem> AssemblyLarge { get; set; }

        public Dictionary<string, ProductionItem> AssemblyLargeTrain { get; set; }

        public Dictionary<string, ProductionItem> AssemblyLargeHeavyTank { get; set; }

        public List<string> AssemblyNames { get; set; }

        public int AssmatAmount { get; set; }

        public AssemblyVehicleBuildings()
        {
            AssemblyStation = new();
            AssemblyStationMotorPool = new();
            AssemblyStationRocket = new();
            AssemblyStationField = new();
            AssemblyStationTank = new();
            AssemblyStationWeapons = new();
            AssemblyLarge = new();
            AssemblyLargeTrain = new();
            AssemblyLargeHeavyTank = new();

            AssemblyNames = new() { "AssemblyStation", "AssemblyStationMotorPool", "AssemblyStationRocket", "AssemblyStationField", "AssemblyStationTank", "AssemblyStationWeapons", "AssemblyLarge", "AssemblyLargeTrain", "AssemblyLargeHeavyTank" };
            AssmatAmount = 5;
        }

        public AssemblyVehicleBuildings(Dictionary<string, ProductionItem> assemblyStation, Dictionary<string, ProductionItem> assemblyStationMotorPool, Dictionary<string, ProductionItem> assemblyStationRocket, Dictionary<string, ProductionItem> assemblyStationField, Dictionary<string, ProductionItem> assemblyStationTank, Dictionary<string, ProductionItem> assemblyStationWeapons, Dictionary<string, ProductionItem> assemblyLarge, Dictionary<string, ProductionItem> assemblyLargeTrain, Dictionary<string, ProductionItem> assemblyLargeHeavyTank)
        {
            AssemblyStation = assemblyStation;
            AssemblyStationMotorPool = assemblyStationMotorPool;
            AssemblyStationRocket = assemblyStationRocket;
            AssemblyStationField = assemblyStationField;
            AssemblyStationTank = assemblyStationTank;
            AssemblyStationWeapons = assemblyStationWeapons;
            AssemblyLarge = assemblyLarge;
            AssemblyLargeTrain = assemblyLargeTrain;
            AssemblyLargeHeavyTank = assemblyLargeHeavyTank;

            AssemblyNames = new() { "AssemblyStation", "AssemblyStationMotorPool", "AssemblyStationRocket", "AssemblyStationField", "AssemblyStationTank", "AssemblyStationWeapons", "AssemblyLarge", "AssemblyLargeTrain", "AssemblyLargeHeavyTank" };
            AssmatAmount = 5;
        }

        public Dictionary<string, ProductionItem> GetBuildingVehicles(string buildingName)
        {
            int categoryIndex = AssemblyNames.IndexOf(buildingName);

            switch (categoryIndex)
            {
                default:
                case 0: return AssemblyStation ?? throw new KeyNotFoundException("Couldn't fetch " + buildingName);
                case 1: return AssemblyStationMotorPool ?? throw new KeyNotFoundException("Couldn't fetch " + buildingName);
                case 2: return AssemblyStationRocket ?? throw new KeyNotFoundException("Couldn't fetch " + buildingName);
                case 3: return AssemblyStationField ?? throw new KeyNotFoundException("Couldn't fetch " + buildingName);
                case 4: return AssemblyStationTank ?? throw new KeyNotFoundException("Couldn't fetch " + buildingName);
                case 5: return AssemblyStationWeapons ?? throw new KeyNotFoundException("Couldn't fetch " + buildingName);
                case 6: return AssemblyLarge ?? throw new KeyNotFoundException("Couldn't fetch " + buildingName);
                case 7: return AssemblyLargeTrain ?? throw new KeyNotFoundException("Couldn't fetch " + buildingName);
                case 8: return AssemblyLargeHeavyTank ?? throw new KeyNotFoundException("Couldn't fetch " + buildingName);
            }
        }
    }
}
