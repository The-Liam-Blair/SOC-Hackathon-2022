namespace LetItBurn.Client.Shared.Upgrades;

public class SolarPanel : IUpgrade
{
    public string Name { get; } = "Solar Panel";
    public string Description { get; } = "A simple machine that will generate clean renewable energy";
    public string PathToIcon { get; }
    public float Modifier { get; set; }
}