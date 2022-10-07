namespace FoxholeLogiSheet.Data
{   
    public class ProductionItem
    {
        public string? Name { get; set; }

        public string? Category { get; set; }

        public string? Description { get; set; }

        public string? DamageType { get; set; }

        public string[]? DamageInfo { get; set; }

        public string? AmmoUsed { get; set; }

        public bool CanMPF { get; set; }

        public int CrateSize { get; set; }

        public int BmatCost { get; set; }

        public int RmatCost { get; set; }

        public int EmatCost { get; set; }

        public int HematCost { get; set; }

        public ProductionItem(string? name, string? category, string? description, string? damageType, string[]? damageInfo, string? ammoUsed, bool canMPF, int crateSize, int bmatCost, int rmatCost, int ematCost, int hematCost)
        {
            Name = name;
            Category = category;
            Description = description;
            DamageType = damageType;
            DamageInfo = damageInfo;
            AmmoUsed = ammoUsed;
            CanMPF = canMPF;
            CrateSize = crateSize;
            BmatCost = bmatCost;
            RmatCost = rmatCost;
            EmatCost = ematCost;
            HematCost = hematCost;
        }

        public ProductionItem()
        {
            Name = "";
            Category = "";
            Description = "";
            DamageType = "";
            DamageInfo = new string[] { "" };
            AmmoUsed = "";
            CanMPF = true;
            CrateSize = 0;
            BmatCost = 0;
            RmatCost = 0;
            EmatCost = 0;
            HematCost = 0;
        }
    }
}
