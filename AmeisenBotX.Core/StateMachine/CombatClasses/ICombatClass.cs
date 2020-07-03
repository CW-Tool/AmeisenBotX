﻿using AmeisenBotX.Core.Character.Comparators;
using AmeisenBotX.Core.Character.Talents.Objects;
using AmeisenBotX.Core.Data.Enums;
using AmeisenBotX.Core.Statemachine.Enums;
using System.Collections.Generic;

namespace AmeisenBotX.Core.Statemachine.CombatClasses
{
    public interface ICombatClass
    {
        string Author { get; }

        WowClass Class { get; }

        Dictionary<string, dynamic> Configureables { get; set; }

        string Description { get; }

        string Displayname { get; }

        bool HandlesMovement { get; }

        bool IsMelee { get; }

        IWowItemComparator ItemComparator { get; }

        List<string> PriorityTargets { get; set; }

        CombatClassRole Role { get; }

        TalentTree Talents { get; }

        string Version { get; }

        bool WalkBehindEnemy { get; }

        bool TargetInLineOfSight { get; set; }

        void Execute();

        void OutOfCombatExecute();
    }
}