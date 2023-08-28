namespace LetItBurn.Client.Shared.Upgrades;

public interface IUpgrade
{
    public string Name { get; }
    public string Description { get; }
    public string PathToIcon { get; }
    public float Modifier { get; set; }
}