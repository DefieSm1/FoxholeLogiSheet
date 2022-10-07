namespace FoxholeLogiSheet.Data
{
    public class ProductionItemCategories
    {
        public Dictionary<string, ProductionItem>? SmallArms { get; set; } = new();

        public Dictionary<string, ProductionItem>? HeavyArms { get; set; } = new();

        public Dictionary<string, ProductionItem>? HeavyMunitions { get; set; } = new();

        public Dictionary<string, ProductionItem>? Utility { get; set; } = new();

        public Dictionary<string, ProductionItem>? Medical { get; set; } = new();

        public Dictionary<string, ProductionItem>? Supplies { get; set; } = new();

        public Dictionary<string, ProductionItem>? Uniforms { get; set; } = new();

        public Dictionary<string, ProductionItem>? Vehicles { get; set; } = new();

        public Dictionary<string, ProductionItem>? Shippables { get; set; } = new();
    }
}
