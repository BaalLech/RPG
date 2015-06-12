﻿using System.Collections.Generic;
using KufTheGame.Models.Game.Models;

namespace KufTheGame.Models.Interfaces
{
    interface ICharacter
    {
        double AttackPoints { get; set; }
        double DefencePoints { get; set; }
        double HealthPoints { get; set; }
        IList<Specialty> Specialties { get; set; }

        void RemoveHp(double hp);

        bool IsAlive();
    }
}