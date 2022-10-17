namespace FoxholeLogiSheet.Data
{   
    public class ProductionItem
    {
        public string? Name { get; set; }

        public string? Category { get; set; }

        public string? Description { get; set; }

        public string? DamageType { get; set; }

        public List<string>? DamageInfo { get; set; }

        public string? AmmoUsed { get; set; }

        public bool CanMPF { get; set; }

        public int CrateSize { get; set; }

        public int BmatCost { get; set; }

        public int RmatCost { get; set; }

        public int EmatCost { get; set; }

        public int HematCost { get; set; }

        // Facility Variables

        public bool IsLiquid { get; set; }

        // Assembly Station Variables

        public int CmatCost { get; set; }

        public int PCmatCost { get; set; }

        public int SteelCost { get; set; }

        public List<int> AssmatCost { get; set; }

        public string BaseVehicle { get; set; }

        public int ProductionTime { get; set; }

        public ProductionItem()
        {
            Name = "";
            Category = "";
            Description = "";
            DamageType = "";
            DamageInfo = new List<string> { "" };
            AmmoUsed = "";
            CanMPF = true;
            CrateSize = 0;
            BmatCost = 0;
            RmatCost = 0;
            EmatCost = 0;
            HematCost = 0;

            IsLiquid = false;

            CmatCost = 0;
            PCmatCost = 0;
            SteelCost = 0;
            AssmatCost = new List<int> { 0, 0, 0, 0, 0 };
            BaseVehicle = "";
            ProductionTime = 0;
        }
    }
}
