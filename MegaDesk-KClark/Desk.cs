using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_KClark
{
    // Define the DesktopMaterial enum outside the Desk class
    public enum DesktopMaterial
    {
        Laminate,
        Oak,
        Rosewood,
        Veneer,
        Pine
    }

    internal class Desk
    {
        // Constants for width and depth constraints
        public const int MIN_WIDTH = 24; // Minimum width in inches
        public const int MAX_WIDTH = 96; // Maximum width in inches
        public const int MIN_DEPTH = 12; // Minimum depth in inches
        public const int MAX_DEPTH = 48; // Maximum depth in inches

        // Properties representing the characteristics of a desk
        public int Width { get; set; }
        public int Depth { get; set; }
        public int NumberOfDrawers { get; set; }
        public DesktopMaterial Material { get; set; }

    }
}

