using System;
namespace Galactica
{
    public sealed class Moon : Planet
    {
        public Planet Orbiting { get; set; }

        public new double Distance(Star star)
        {
            double xDiff = position.X - Orbiting.position.X;
            double yDiff = position.Y - Orbiting.position.Y;
            return Math.Sqrt(Math.Pow(xDiff, 2) + Math.Pow(yDiff, 2));
        }
    }
}