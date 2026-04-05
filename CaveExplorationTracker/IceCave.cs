using CaveExplorationTracker;

public class IceCave : Cave, IExplorable
{
    public double IceThickness { get; set; }

    public IceCave(string caveName, string location, double depth, double length, bool isExplored, double iceThickness)
        : base(caveName, location, depth, length, isExplored)
    {
        IceThickness = iceThickness;
    }

    public override string Display()
    {
        return base.Display() + $" | Ice Thickness: {IceThickness} in";
    }

    public override string Display(int num)
    {
        if (num == 1)
            return $"{CaveName}";
        else if (num == 2)
            return $"{CaveName} | Ice: {IceThickness}";
        else
            return Display();
    }

    public string GetExplorationTip()
    {
        return "Watch for slippery ice!";
    }

    public string MeasureIce()
    {
        return $"Ice thickness is {IceThickness} inches.";
    }
}