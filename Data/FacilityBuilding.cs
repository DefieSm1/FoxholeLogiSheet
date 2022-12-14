namespace FoxholeLogiSheet.Data
{
    public class FacilityBuilding
    {
        public string? Name { get; set; }

        public string? BuildingType { get; set; }

        public string? Description { get; set; }

        public int BmatCost { get; set; }

        public int CmatCost { get; set; }

        public int PCmatCost { get; set; }

        public int SteelCost { get; set; }

        public List<string> BuildingUpgrades { get; set; }

        public List<FacilityRecipe> BuildingRecipes {get; set; }

        public FacilityBuilding()
        {
            Name = "";
            BuildingType = "";
            Description = "";
            BmatCost = 0;
            CmatCost = 0;
            PCmatCost = 0;
            SteelCost = 0;
            BuildingUpgrades = new();
            BuildingRecipes = new();
        }
    }
}
