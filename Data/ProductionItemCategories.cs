namespace FoxholeLogiSheet.Data
{
    public class ProductionItemCategories
    {
        public Dictionary<string, ProductionItem>? SmallArms { get; set; }

        public Dictionary<string, ProductionItem>? HeavyArms { get; set; }

        public Dictionary<string, ProductionItem>? HeavyMunitions { get; set; }

        public Dictionary<string, ProductionItem>? Utility { get; set; }

        public Dictionary<string, ProductionItem>? Medical { get; set; }

        public Dictionary<string, ProductionItem>? Supplies { get; set; }

        public Dictionary<string, ProductionItem>? Uniforms { get; set; }

        public Dictionary<string, ProductionItem>? Vehicles { get; set; }

        public Dictionary<string, ProductionItem>? Shippables { get; set; }

        public List<string> CategoryNames { get; set; } = new();

        public List<string> CannotFactory { get; set; } = new();

        public List<string> CannotMPF { get; set; } = new();

        public ProductionItemCategories()
        {
            SmallArms = new();
            HeavyArms = new();
            HeavyMunitions = new();
            Utility = new();
            Medical = new();
            Supplies = new();
            Uniforms = new();
            Vehicles = new();
            Shippables = new();

            CategoryNames = new() { "SmallArms", "HeavyArms", "HeavyMunitions", "Utility", "Medical", "Supplies", "Uniforms", "Vehicles", "Shippables" };
            CannotFactory = new() { "Vehicles", "Shippables" };
            CannotMPF = new() { "Medical", "Utility", "Supplies" };
        }

        public ProductionItemCategories(Dictionary<string, ProductionItem>? smallArms, Dictionary<string, ProductionItem>? heavyArms, Dictionary<string, ProductionItem>? heavyMunitions, Dictionary<string, ProductionItem>? utility, Dictionary<string, ProductionItem>? medical, Dictionary<string, ProductionItem>? supplies, Dictionary<string, ProductionItem>? uniforms, Dictionary<string, ProductionItem>? vehicles, Dictionary<string, ProductionItem>? shippables, List<string> categoryNames)
        {
            SmallArms = smallArms;
            HeavyArms = heavyArms;
            HeavyMunitions = heavyMunitions;
            Utility = utility;
            Medical = medical;
            Supplies = supplies;
            Uniforms = uniforms;
            Vehicles = vehicles;
            Shippables = shippables;

            CategoryNames = new() { "SmallArms", "HeavyArms", "HeavyMunitions", "Utility", "Medical", "Supplies", "Uniforms", "Vehicles", "Shippables" };
            CannotFactory = new() { "Vehicles", "Shippables" };
            CannotMPF = new() { "Medical", "Utility", "Supplies" };
        }

        public Dictionary<string, ProductionItem> GetCategoryData(string categoryName)
        {
            int categoryIndex = CategoryNames.IndexOf(categoryName);

            switch (categoryIndex)
            {
                default:
                case 0: return SmallArms ?? throw new KeyNotFoundException("Couldn't fetch " + categoryName);
                case 1: return HeavyArms ?? throw new KeyNotFoundException("Couldn't fetch " + categoryName);
                case 2: return HeavyMunitions ?? throw new KeyNotFoundException("Couldn't fetch " + categoryName);
                case 3: return Utility ?? throw new KeyNotFoundException("Couldn't fetch " + categoryName) ;
                case 4: return Medical ?? throw new KeyNotFoundException("Couldn't fetch " + categoryName);
                case 5: return Supplies ?? throw new KeyNotFoundException("Couldn't fetch " + categoryName);
                case 6: return Uniforms ?? throw new KeyNotFoundException("Couldn't fetch " + categoryName);
                case 7: return Vehicles ?? throw new KeyNotFoundException("Couldn't fetch " + categoryName);
                case 8: return Shippables ?? throw new KeyNotFoundException("Couldn't fetch " + categoryName);
            }
        }
        public string GetProductionBuilding(string itemCategory)
        {
            if (itemCategory == "Vehicles")
                return "Garage";
            else if (itemCategory == "Shippables")
                return "ConYard";
            else
                return "Factory";
        }
    }
}
