﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Engine.Models
{
    public class MonsterEncounter
    {
        public int MonsterID { get; }
        public int ChanceOfEncountering { get; set; }

        public MonsterEncounter(int monsterID, int chanceOfEncountering)
        {
            MonsterID = monsterID;
            ChanceOfEncountering = chanceOfEncountering;
        }
    }
}
