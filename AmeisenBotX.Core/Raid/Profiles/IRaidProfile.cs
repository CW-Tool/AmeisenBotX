﻿using AmeisenBotX.Core.Data.Enums;
using AmeisenBotX.Core.Dungeon.Enums;
using AmeisenBotX.Core.Dungeon.Objects;
using System.Collections.Generic;
using System.Numerics;

namespace AmeisenBotX.Core.Jobs.Profiles
{
    public interface IRaidProfile
    {
        public string Author { get; }

        public string Description { get; }

        public DungeonFactionType FactionType { get; }

        public int GroupSize { get; }

        public MapId MapId { get; }

        public int MaxLevel { get; }

        public string Name { get; }

        public List<DungeonNode> Path { get; }

        public int RequiredItemLevel { get; }

        public int RequiredLevel { get; }

        public Vector3 WorldEntry { get; }
    }
}