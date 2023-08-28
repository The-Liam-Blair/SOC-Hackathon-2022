namespace LetItBurn.Client.Shared.Upgrades;

public class Tree : IUpgrade
{
    public string Name { get; } 
    public string Description { get; }
    public string PathToIcon { get; }
    public float Modifier { get; set; }
    
    public int Quantity { get; set; }

    public Tree()
    {
        this.Name = "Tree";
        this.Description = "Natures CO2 Absorber";
        this.Quantity = 0;
    }
}