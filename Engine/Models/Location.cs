using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Engine.Factories;

namespace Engine.Models
{
    public class Location
    {
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public String ImageName { get; set; }
        public List<Quest> QuestsAvailableHere { get; set; } = new List<Quest>();

        public List<MonsterEncounter> MonstersHere { get; set; } = new List<MonsterEncounter>();

        public void AddMonster(int monsterID, int chanceOfEncountering)
        {
            if(MonstersHere.Exists(m => m.MonsterID == monsterID))
            {
                //this monster has already been added to this location.
                //so, overwrite the ChanceOfEncountering with the new number.
                MonstersHere.First(m => m.MonsterID == monsterID).ChanceOfEncountering = chanceOfEncountering;
            } else
            {
                //this monster is not already at this location, so add it.
                MonstersHere.Add(new MonsterEncounter(monsterID, chanceOfEncountering));
            }
        }

        public Monster GetMonster()
        {
            if (!MonstersHere.Any()) { return null; }

            //total the percentages of all monsters at this location.
            int totalChances = MonstersHere.Sum(m => m.ChanceOfEncountering);

            //select a random number between 1 and the total (in case the total chances is not 100)
            int randomNumber = RandomNumberGenerator.NumberBetween(1, totalChances);

            //loop through the monster list,
            //adding the monster's percentage chance of appearing to the runningTotal variable.
            //when the random number is lower than the runningTotal, 
            //that is the monster to return
            int runningTotal = 0;

            foreach(MonsterEncounter monsterEncounter in MonstersHere)
            {
                runningTotal += monsterEncounter.ChanceOfEncountering;

                if(randomNumber <= runningTotal)
                {
                    return MonsterFactory.GetMonster(monsterEncounter.MonsterID);
                }
            }

            //if there was a problem, return to the last monster in the list.
            return MonsterFactory.GetMonster(MonstersHere.Last().MonsterID);
        }
    }
}
