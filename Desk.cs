using System;

namespace MegaDesk_Fox
{
    public class Desk
    {
        public int Width { get; set; }

        public int Depth { get; set; }

        public int Drawers { get; set; }

        public DesktopMaterial Material { get; set; }

        public int SurfaceArea => Width * Depth;

        public decimal Cost
        {
            get
            {
                var cost = BASECOST + GetSurfaceCost(Material);

                if (Drawers > 0)
                    cost += Drawers * DRAWERCOST;

                if(SurfaceArea > 1000)
                    cost += SURFACEAREAFACTOR * (SurfaceArea - 1000);

                return cost;
            }
        }

        #region Validation Constraints

        public const int MINWIDTH = 24;
        public const int MAXWIDTH = 96;
        public const int MINDEPTH = 12;
        public const int MAXDEPTH = 48;
        public const int MINDRAWERS = 0;
        public const int MAXDRAWERS = 7;

        #endregion

        #region Costs

        public const decimal BASECOST = 200;        // Base cost.
        public const decimal SURFACEAREAFACTOR = 1;   // $'s per in^2 over 1000 in^2.
        public const decimal DRAWERCOST = 50;
        public static decimal GetSurfaceCost(DesktopMaterial material)
        {
            switch (material)
            {
                case DesktopMaterial.Laminate:
                    return 100m;
                case DesktopMaterial.Oak:
                    return 200m;
                case DesktopMaterial.Rosewood:
                    return 300m;
                case DesktopMaterial.Veneer:
                    return 125m;
                case DesktopMaterial.Pine:
                    return 50m;
                default:
                    throw new NotImplementedException();
            }
        }

        #endregion
    }

    public enum DesktopMaterial
    {
        Laminate,
        Oak,
        Rosewood,
        Veneer,
        Pine
    }
}
