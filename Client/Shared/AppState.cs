using LetItBurn.Client.Shared.Upgrades;

namespace LetItBurn.Client.Shared;

public class AppState
{
    
    public long carbonDioxideTons = 0;

    public Tree Tree = new Tree();
    
    public WindTurbine WindTurbine = new WindTurbine();

    public SolarPanel SolarPanel = new SolarPanel();
    



}