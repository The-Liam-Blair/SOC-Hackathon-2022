namespace LetItBurn.Client.Shared.Upgrades;

public class WindTurbine : IUpgrade
{
    public string Name { get; } = "Wind Turbine";
    public string Description { get; } = "A simple machine that will generate clean renewable energy";
    public string PathToIcon { get; }
    public float Modifier { get; set; }
}