     // This interface defines a method that both subclasses must implement.
    // The point of the interface is to force both cave types to provide
    // their own version of an exploration tip.
    public interface IExplorable
    {
        string GetExplorationTip();
    }
