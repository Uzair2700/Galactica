using System;
namespace Galactica
{
    public enum PlanetType
    {
        Terrestrial,
        Giant,
        Dwarf,
        GasGiant
    }

    public class Planet : SpaceObject
    {
        public PlanetType PlanetType { get; set; }
        public double Diameter { get; set; }
        public double RotationPeriod { get; set; }
        public double RevolutionPeriod { get; set; }
        public List<Moon> Moons { get; set; } = new List<Moon>();
        public Star Orbiting { get; set; }

        public double Distance(Star star)
        {
            double xDiff = position.X - star.position.X;
            double yDiff = position.Y - star.position.Y;
            return Math.Sqrt(Math.Pow(xDiff, 2) + Math.Pow(yDiff, 2));
        }
    }
}