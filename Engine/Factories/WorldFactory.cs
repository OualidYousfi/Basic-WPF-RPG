using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Engine.Models;

namespace Engine.Factories
{
    //only will be used in Engine project
    internal class WorldFactory
    {
        internal World createWorld()
        {
            World newWorld = new World();
            newWorld.AddLocation(-2, -1, "Farmer's Field",
                "There are rows of corn growing here, with giant rats hiding between them.",
                "/Engine;component/Images/Locations/FarmFields.png");
            newWorld.AddLocation(-1, -1, "Farmer's House",
                "This is the house of your neighbor, Farmer Ted.",
                "/Engine;component/Images/Locations/FarmHouse.png");
            newWorld.AddLocation(0, -1, "Home", 
                "This is your home.", 
                "/Engine;component/Images/Locations/Home.png");
            newWorld.AddLocation(-1, 0, "Trading Shop",
                "This is the trading shop.",
                "/Engine;component/Images/Locations/Trader.png");
            newWorld.AddLocation(0, 0, "Town Square",
                "This is the town square.",
                "/Engine;component/Images/Locations/TownSquare.png");
            newWorld.AddLocation(1, 0, "Town Gate",
                "This is the town gate.",
                "/Engine;component/Images/Locations/TownGate.png");
            newWorld.AddLocation(2, 0, "Spider Forest",
                "This is the spider forest.",
                "/Engine;component/Images/Locations/SpiderForest.png");
            newWorld.AddLocation(0, 1, "Herbalist's Hut",
                "This is the herbalist's hut.",
                "/Engine;component/Images/Locations/HerbalistsHut.png");
            newWorld.AddLocation(0, 2, "Herb Garden",
                "This is the herb garden.",
                "/Engine;component/Images/Locations/HerbalistsGarden.png");
            return newWorld;
        }
    }
}
