using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Engine.Models
{
    public class Monster : LivingEntity
    {
        public string ImageName { get; set; }

        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }

        public int RewardExperiencePoints { get; private set; }

        public Monster(string name, string imageName,
            int maximumHitPoints, int currentHitPoints,
            int minimumDamage, int maximumDamage,
            int rewardExperiencePoints, int gold)
        {
            Name = name;
            ImageName = $"/Engine;component/Images/Monsters/{imageName}";
            MaximumHitPoints = maximumHitPoints;
            CurrentHitPoints = currentHitPoints;
            MinimumDamage = minimumDamage;
            MaximumDamage = maximumDamage;
            RewardExperiencePoints = rewardExperiencePoints;
            Gold = gold;
        }
    }
}
