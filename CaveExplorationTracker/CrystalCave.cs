using CaveExplorationTracker;

public class CrystalCave : Cave, IExplorable
{
    public int CrystalCount { get; set; }

    public CrystalCave(string caveName, string location, double depth, double length, bool isExplored, int crystalCount)
        : base(caveName, location, depth, length, isExplored)
    {
        CrystalCount = crystalCount;
    }

    public override string Display()
    {
        return base.Display() + $" | Crystals: {CrystalCount}";
    }

    public override string Display(int num)
    {
        if (num == 1)
            return $"{CaveName}";
        else if (num == 2)
            return $"{CaveName} | Crystals: {CrystalCount}";
        else
            return Display();
    }

    public string GetExplorationTip()
    {
        return "Handle crystals carefully!";
    }

    public string EvaluateCrystals()
    {
        return $"This cave has {CrystalCount} crystals.";
    }
}