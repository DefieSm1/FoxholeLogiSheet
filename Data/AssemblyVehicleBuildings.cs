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

        public Dictionary<string, ProductionItem> GetBuildingVehicles(string buildingName) => AssemblyNames.IndexOf(buildingName) switch
        {
            0 => AssemblyStation ?? throw new KeyNotFoundException("Couldn't fetch " + buildingName),
            1 => AssemblyStationMotorPool ?? throw new KeyNotFoundException("Couldn't fetch " + buildingName),
            2 => AssemblyStationRocket ?? throw new KeyNotFoundException("Couldn't fetch " + buildingName),
            3 => AssemblyStationField ?? throw new KeyNotFoundException("Couldn't fetch " + buildingName),
            4 => AssemblyStationTank ?? throw new KeyNotFoundException("Couldn't fetch " + buildingName),
            5 => AssemblyStationWeapons ?? throw new KeyNotFoundException("Couldn't fetch " + buildingName),
            6 => AssemblyLarge ?? throw new KeyNotFoundException("Couldn't fetch " + buildingName),
            7 => AssemblyLargeTrain ?? throw new KeyNotFoundException("Couldn't fetch " + buildingName),
            8 => AssemblyLargeHeavyTank ?? throw new KeyNotFoundException("Couldn't fetch " + buildingName),
            _ => AssemblyStation ?? throw new KeyNotFoundException("Couldn't fetch " + buildingName)
        };
    }
}
