using System;
namespace Galactica
{
    public enum StarType
    {
        YellowDwarf,
        White,
        BlueNeutron,
        RedGiant
    }

    public class Star : SpaceObject
    {
        public StarType Type { get; set; }
        public double Temperature { get; set; }
        public List<Planet> Planets { get; set; } = new List<Planet>();

        public Star()
        {
            position = new Position { X = 0.0, Y = 0.0 };
        }
    }
}

