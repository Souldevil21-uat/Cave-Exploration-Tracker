using System;

namespace CaveExplorationTracker
{
    // This class represents a single cave.
    // It is the blueprint used to create cave objects.
    public class Cave
    {
        // Property 1
        public string CaveName { get; set; }

        // Property 2
        public string Location { get; set; }

        // Property 3
        public double Depth { get; set; }

        // Property 4
        public double Length { get; set; }

        // Property 5
        public bool IsExplored { get; set; }

        // Constructor
        public Cave(string caveName, string location, double depth, double length, bool isExplored)
        {
            CaveName = caveName;
            Location = location;
            Depth = depth;
            Length = length;
            IsExplored = isExplored;
        }

        // Method 1
        public string GetExplorationStatus()
        {
            return IsExplored ? "Explored" : "Unexplored";
        }

        // Method 2
        public string GetDisplayText()
        {
            return $"{CaveName} ({Location})\n Depth: {Depth} ft | Length: {Length} ft | {GetExplorationStatus()}";
        }
    }
}
