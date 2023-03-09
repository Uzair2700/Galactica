using System;
using System.Collections.Generic;

namespace Galactica
{
    class Program
    {
        static void Main(string[] args)
        {
            Star sun = new Star()
            {
                Id = 1,
                Name = "Sun",
                Type = StarType.YellowDwarf,
                Temperature = 5778
            };


            Planet mercury = new Planet()
            {
                Id = 2,
                Name = "Mercury",
                PlanetType = PlanetType.Terrestrial,
                Diameter = 4879,
                RotationPeriod = 1407,
                RevolutionPeriod = 88,
                position = new SpaceObject.Position() { X = 0.387, Y = 0.0 }
            };


            Planet venus = new Planet()
            {
                Id = 3,
                Name = "Venus",
                PlanetType = PlanetType.Terrestrial,
                Diameter = 12104,
                RotationPeriod = 5832.5,
                RevolutionPeriod = 225,
                position = new SpaceObject.Position() { X = 0.723, Y = 0.0 }
            };


            Planet earth = new Planet()
            {
                Id = 4,
                Name = "Earth",
                PlanetType = PlanetType.Terrestrial,
                Diameter = 12742,
                RotationPeriod = 24,
                RevolutionPeriod = 365,
                position = new SpaceObject.Position() { X = 0.345, Y = 0.0 }
            };



            Planet mars = new Planet()
            {
                Id = 5,
                Name = "Mars",
                PlanetType = PlanetType.Terrestrial,
                Diameter = 2356,
                RotationPeriod = 23,
                RevolutionPeriod = 543,
                position = new SpaceObject.Position() { X = 0.445, Y = 0.0 }
            };


            Planet jupiter = new Planet()
            {
                Id = 6,
                Name = "Jupiter",
                PlanetType = PlanetType.Giant,
                Diameter = 14600,
                RotationPeriod = 10,
                RevolutionPeriod = 4300,
                position = new SpaceObject.Position() { X = 0.563, Y = 0.0 }
            };


            Planet saturn = new Planet()
            {
                Id = 7,
                Name = "Saturn",
                PlanetType = PlanetType.GasGiant,
                Diameter = 125432,
                RotationPeriod = 32,
                RevolutionPeriod = 10800,
                position = new SpaceObject.Position() { X = 0.432, Y = 0.0 }
            };


            Planet uranus = new Planet()
            {
                Id = 8,
                Name = "Uranus",
                PlanetType = PlanetType.GasGiant,
                Diameter = 51673,
                RotationPeriod = 17,
                RevolutionPeriod = 30500,
                position = new SpaceObject.Position() { X = 0.215, Y = 0.0 }
            };


            Planet neptune = new Planet()
            {
                Id = 9,
                Name = "Neptune",
                PlanetType = PlanetType.GasGiant,
                Diameter = 3249,
                RotationPeriod = 21,
                RevolutionPeriod = 59800,
                position = new SpaceObject.Position() { X = 0.231, Y = 0.0 }
            };


            Moon luna = new Moon()
            {
                Id = 10,
                Name = "Luna",
                PlanetType = PlanetType.Dwarf,
                Diameter = 49654,
                RotationPeriod = 16,
                RevolutionPeriod = 59832,
                position = new SpaceObject.Position() { X = 0.145, Y = 0.0 },
                Orbiting = earth
            };



            Moon titan = new Moon()
            {
                Id = 11,
                Name = "Titan",
                PlanetType = PlanetType.Dwarf,
                Diameter = 5151,
                RotationPeriod = 382,
                RevolutionPeriod = 16,
                position = new SpaceObject.Position() { X = 5.145, Y = 0.0 },
                Orbiting = jupiter
            };


            Moon phobos = new Moon()
            {
                Id = 12,
                Name = "Phobos",
                PlanetType = PlanetType.Dwarf,
                Diameter = 2343,
                RotationPeriod = 32,
                RevolutionPeriod = 322,
                position = new SpaceObject.Position() { X = 3.145, Y = 0.0 },
                Orbiting = mars
            };



            Moon europa = new Moon()
            {
                Id = 13,
                Name = "Europa",
                PlanetType = PlanetType.Dwarf,
                Diameter = 2345,
                RotationPeriod = 23,
                RevolutionPeriod = 35653,
                position = new SpaceObject.Position() { X = 3.455, Y = 0.0 },
                Orbiting = jupiter
            };



            Moon deimos = new Moon()
            {
                Id = 14,
                Name = "Deimos",
                PlanetType = PlanetType.Dwarf,
                Diameter = 24653,
                RotationPeriod = 235,
                RevolutionPeriod = 245,
                position = new SpaceObject.Position() { X = 3.362, Y = 0.0 },
                Orbiting = mars
            };


            Moon ganymedes = new Moon()
            {
                Id = 15,
                Name = "Ganymedes",
                PlanetType = PlanetType.Dwarf,
                Diameter = 44354,
                RotationPeriod = 136,
                RevolutionPeriod = 4352,
                position = new SpaceObject.Position() { X = 1.545, Y = 0.0 },
                Orbiting = jupiter
            };


            Moon io = new Moon()
            {
                Id = 16,
                Name = "Io",
                PlanetType = PlanetType.Dwarf,
                Diameter = 3654,
                RotationPeriod = 43,
                RevolutionPeriod = 2456,
                position = new SpaceObject.Position() { X = 2.525, Y = 0.0 },
                Orbiting = jupiter
            };


            Moon mimas = new Moon()
            {
                Id = 17,
                Name = "Mimas",
                PlanetType = PlanetType.Dwarf,
                Diameter = 2345,
                RotationPeriod = 36,
                RevolutionPeriod = 3345,
                position = new SpaceObject.Position() { X = 5.764, Y = 0.0 },
                Orbiting = saturn
            };



            sun.Planets.AddRange(new Planet[] { mercury, venus, earth, mars, jupiter, saturn, uranus, neptune });


            luna.Moons.AddRange(new Moon[] { titan, phobos, europa, deimos, ganymedes, io, mimas });


            foreach (Planet planet in sun.Planets)
            {
                Console.WriteLine($"Name: {planet.Name}\nType: {planet.PlanetType}\nDistance From Sun {planet.Distance(sun)}\n");

            }
            Console.ReadLine();




        }
    }
}