using System;

namespace CaveExplorationTracker
{
    // This class represents a single cave.
    // It is the blueprint used to create cave objects.
    public class Cave
    {
        // Private backing fields
        private string caveName;
        private double depth;
        private double length;

        // Encapsulated Property 1
        public string CaveName
        {
            get { return caveName; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    caveName = value;
                else
                    caveName = "Unknown Cave";
            }
        }

        // Encapsulated Property 2
        public double Depth
        {
            get { return depth; }
            set
            {
                if (value >= 0)
                    depth = value;
                else
                    depth = 0;
            }
        }

        // Encapsulated Property 3
        public double Length
        {
            get { return length; }
            set
            {
                if (value >= 0)
                    length = value;
                else
                    length = 0;
            }
        }
        // Property 4
        public bool IsExplored { get; set; }

        // Property 5
        public string Location { get; set; }

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

        // Display ALL attributes
        public virtual string Display()
        {
            return $"{CaveName} ({Location}) | Depth: {Depth} ft | Length: {Length} ft | {GetExplorationStatus()}";
        }

        // Display PARTIAL attributes based on number
        public virtual string Display(int num)
        {
            if (num == 1)
            {
                return $"{CaveName}";
            }
            else if (num == 2)
            {
                return $"{CaveName} ({Location})";
            }
            else
            {
                return Display(); // fallback to full display
            }
        }
    }
}
