﻿using AmeisenBotX.Core.Data.Enums;
using AmeisenBotX.Core.Dungeon.Enums;
using AmeisenBotX.Core.Dungeon.Objects;
using AmeisenBotX.Core.Jobs.Profiles;
using AmeisenBotX.Core.Movement.Pathfinding.Objects;
using System.Collections.Generic;

namespace AmeisenBotX.Core.Dungeon.Profiles.WotLK
{
    public class AzjolNerubProfile : IDungeonProfile
    {
        public string Author { get; } = "Jannis";

        public string Description { get; } = "Profile for the Dungeon in Dragonblight, made for Level 70 to 80.";

        public DungeonFactionType FactionType { get; } = DungeonFactionType.Neutral;

        public int GroupSize { get; } = 5;

        public MapId MapId { get; } = MapId.AzjolNerub;

        public int MaxLevel { get; } = 80;

        public string Name { get; } = "[70-80] Azjol Nerub";

        public List<DungeonNode> Path { get; private set; } = new List<DungeonNode>()
        {
            new DungeonNode(new Vector3(413, 796, 831)),
            new DungeonNode(new Vector3(418, 790, 830)),
            new DungeonNode(new Vector3(423, 784, 828)),
            new DungeonNode(new Vector3(429, 779, 827)),
            new DungeonNode(new Vector3(435, 774, 827)),
            new DungeonNode(new Vector3(442, 770, 827)),
            new DungeonNode(new Vector3(449, 766, 827)),
            new DungeonNode(new Vector3(456, 763, 825)),
            new DungeonNode(new Vector3(464, 760, 824)),
            new DungeonNode(new Vector3(472, 759, 823)),
            new DungeonNode(new Vector3(479, 757, 821)),
            new DungeonNode(new Vector3(486, 755, 818)),
            new DungeonNode(new Vector3(494, 754, 815)),
            new DungeonNode(new Vector3(501, 753, 811)),
            new DungeonNode(new Vector3(508, 752, 808)),
            new DungeonNode(new Vector3(515, 751, 804)),
            new DungeonNode(new Vector3(522, 749, 800)),
            new DungeonNode(new Vector3(528, 747, 795)),
            new DungeonNode(new Vector3(535, 745, 790)),
            new DungeonNode(new Vector3(541, 742, 786)),
            new DungeonNode(new Vector3(547, 739, 782)),
            new DungeonNode(new Vector3(551, 734, 778)),
            new DungeonNode(new Vector3(552, 726, 777)),
            new DungeonNode(new Vector3(549, 719, 777)),
            new DungeonNode(new Vector3(546, 712, 777)),
            new DungeonNode(new Vector3(542, 705, 777)),
            new DungeonNode(new Vector3(539, 698, 776)),
            new DungeonNode(new Vector3(536, 691, 775)),
            new DungeonNode(new Vector3(533, 684, 775)),
            new DungeonNode(new Vector3(531, 676, 775)),
            new DungeonNode(new Vector3(529, 668, 776)),
            new DungeonNode(new Vector3(530, 660, 776)),
            new DungeonNode(new Vector3(530, 652, 777)),
            new DungeonNode(new Vector3(530, 644, 777)),
            new DungeonNode(new Vector3(530, 636, 777)),
            new DungeonNode(new Vector3(530, 628, 778)),
            new DungeonNode(new Vector3(531, 620, 778)),
            new DungeonNode(new Vector3(531, 612, 778)),
            new DungeonNode(new Vector3(531, 604, 777)),
            new DungeonNode(new Vector3(531, 596, 777)),
            new DungeonNode(new Vector3(531, 588, 777)),
            new DungeonNode(new Vector3(531, 580, 777)),
            new DungeonNode(new Vector3(531, 572, 776)),
            new DungeonNode(new Vector3(531, 564, 775)),
            new DungeonNode(new Vector3(531, 557, 772)),
            new DungeonNode(new Vector3(530, 550, 769)),
            new DungeonNode(new Vector3(531, 542, 768)),
            new DungeonNode(new Vector3(531, 534, 766)),
            new DungeonNode(new Vector3(530, 527, 761)),
            new DungeonNode(new Vector3(530, 520, 757)),
            new DungeonNode(new Vector3(530, 513, 754)),
            new DungeonNode(new Vector3(531, 505, 754)),
            new DungeonNode(new Vector3(536, 499, 755)),
            new DungeonNode(new Vector3(543, 495, 758)),
            new DungeonNode(new Vector3(548, 500, 753)),
            new DungeonNode(new Vector3(549, 505, 747)),
            new DungeonNode(new Vector3(548, 512, 744)),
            new DungeonNode(new Vector3(546, 519, 742)),
            new DungeonNode(new Vector3(542, 526, 739)),
            new DungeonNode(new Vector3(538, 532, 736)),
            new DungeonNode(new Vector3(534, 539, 734)),
            new DungeonNode(new Vector3(529, 545, 732)),
            new DungeonNode(new Vector3(528, 553, 732)),
            new DungeonNode(new Vector3(534, 558, 733)),
            new DungeonNode(new Vector3(541, 561, 732)),
            new DungeonNode(new Vector3(548, 564, 731)),
            new DungeonNode(new Vector3(555, 568, 729)),
            new DungeonNode(new Vector3(562, 571, 728)),
            new DungeonNode(new Vector3(569, 574, 727)),
            new DungeonNode(new Vector3(577, 576, 727)),
            new DungeonNode(new Vector3(585, 577, 726)),
            new DungeonNode(new Vector3(593, 576, 725)),
            new DungeonNode(new Vector3(601, 575, 723)),
            new DungeonNode(new Vector3(607, 570, 721)),
            new DungeonNode(new Vector3(612, 564, 719)),
            new DungeonNode(new Vector3(615, 557, 716)),
            new DungeonNode(new Vector3(618, 550, 712)),
            new DungeonNode(new Vector3(620, 543, 708)),
            new DungeonNode(new Vector3(621, 536, 704)),
            new DungeonNode(new Vector3(620, 529, 699)),
            new DungeonNode(new Vector3(616, 523, 695)),
            new DungeonNode(new Vector3(611, 517, 695)),
            new DungeonNode(new Vector3(605, 512, 695)),
            new DungeonNode(new Vector3(597, 512, 695)),
            new DungeonNode(new Vector3(589, 511, 695)),
            new DungeonNode(new Vector3(582, 512, 698)),
            new DungeonNode(new Vector3(574, 512, 698)),
            new DungeonNode(new Vector3(566, 512, 699)),
            new DungeonNode(new Vector3(559, 513, 695)),
            new DungeonNode(new Vector3(551, 514, 695)),
            new DungeonNode(new Vector3(546, 519, 692)),
            new DungeonNode(new Vector3(539, 524, 689)),
            new DungeonNode(new Vector3(534, 528, 685)),
            new DungeonNode(new Vector3(529, 532, 681)),
            new DungeonNode(new Vector3(525, 537, 677)),
            new DungeonNode(new Vector3(520, 543, 675)),
            new DungeonNode(new Vector3(522, 550, 672)),
            new DungeonNode(new Vector3(523, 558, 670)),
            new DungeonNode(new Vector3(518, 562, 666)),
            new DungeonNode(new Vector3(518, 561, 658)),
            new DungeonNode(new Vector3(520, 557, 651)),
            new DungeonNode(new Vector3(522, 550, 647)),
            new DungeonNode(new Vector3(527, 544, 646)),
            new DungeonNode(new Vector3(532, 549, 643)),
            new DungeonNode(new Vector3(536, 514, 290)),
            new DungeonNode(new Vector3(537, 506, 290)),
            new DungeonNode(new Vector3(539, 498, 290)),
            new DungeonNode(new Vector3(541, 490, 289)),
            new DungeonNode(new Vector3(543, 482, 289)),
            new DungeonNode(new Vector3(544, 474, 289)),
            new DungeonNode(new Vector3(546, 466, 289)),
            new DungeonNode(new Vector3(547, 458, 288)),
            new DungeonNode(new Vector3(549, 450, 287)),
            new DungeonNode(new Vector3(549, 442, 285)),
            new DungeonNode(new Vector3(549, 434, 285)),
            new DungeonNode(new Vector3(549, 426, 285)),
            new DungeonNode(new Vector3(549, 418, 284)),
            new DungeonNode(new Vector3(548, 410, 283)),
            new DungeonNode(new Vector3(548, 402, 280)),
            new DungeonNode(new Vector3(549, 396, 275)),
            new DungeonNode(new Vector3(549, 391, 269)),
            new DungeonNode(new Vector3(549, 385, 263)),
            new DungeonNode(new Vector3(549, 380, 257)),
            new DungeonNode(new Vector3(549, 374, 252)),
            new DungeonNode(new Vector3(549, 369, 246)),
            new DungeonNode(new Vector3(550, 363, 241)),
            new DungeonNode(new Vector3(550, 355, 241)),
            new DungeonNode(new Vector3(550, 347, 241)),
            new DungeonNode(new Vector3(550, 339, 241)),
            new DungeonNode(new Vector3(550, 331, 241)),
            new DungeonNode(new Vector3(550, 324, 238)),
            new DungeonNode(new Vector3(550, 317, 235)),
            new DungeonNode(new Vector3(550, 310, 232)),
            new DungeonNode(new Vector3(550, 302, 230)),
            new DungeonNode(new Vector3(551, 294, 228)),
            new DungeonNode(new Vector3(551, 286, 226)),
            new DungeonNode(new Vector3(551, 278, 224)),
            new DungeonNode(new Vector3(551, 270, 223)),
            new DungeonNode(new Vector3(551, 262, 224)),
            new DungeonNode(new Vector3(551, 254, 224)),
            new DungeonNode(new Vector3(550, 246, 223)),
            new DungeonNode(new Vector3(557, 242, 223)),
            new DungeonNode(new Vector3(563, 247, 223)),
            new DungeonNode(new Vector3(556, 250, 224)),
            new DungeonNode(new Vector3(550, 245, 223)),
            new DungeonNode(new Vector3(550, 237, 224)),
            new DungeonNode(new Vector3(550, 229, 224)),
            new DungeonNode(new Vector3(550, 222, 220)),
            new DungeonNode(new Vector3(550, 215, 216)),
            new DungeonNode(new Vector3(549, 208, 213)),
            new DungeonNode(new Vector3(550, 201, 209)),
            new DungeonNode(new Vector3(550, 194, 206)),
            new DungeonNode(new Vector3(549, 187, 202)),
            new DungeonNode(new Vector3(549, 180, 199)),
            new DungeonNode(new Vector3(549, 173, 196)),
            new DungeonNode(new Vector3(549, 165, 196)),
            new DungeonNode(new Vector3(549, 157, 196)),
            new DungeonNode(new Vector3(549, 149, 197)),
            new DungeonNode(new Vector3(548, 141, 198)),
            new DungeonNode(new Vector3(548, 133, 198)),
            new DungeonNode(new Vector3(548, 125, 198)),
            new DungeonNode(new Vector3(548, 117, 197)),
            new DungeonNode(new Vector3(548, 109, 195)),
            new DungeonNode(new Vector3(548, 101, 195)),
            new DungeonNode(new Vector3(545, 95, 199)),
            new DungeonNode(new Vector3(539, 91, 202)),
            new DungeonNode(new Vector3(533, 89, 207)),
            new DungeonNode(new Vector3(526, 89, 212)),
            new DungeonNode(new Vector3(519, 88, 216)),
            new DungeonNode(new Vector3(512, 88, 220)),
            new DungeonNode(new Vector3(505, 87, 224)),
            new DungeonNode(new Vector3(498, 87, 228)),
            new DungeonNode(new Vector3(491, 86, 232)),
            new DungeonNode(new Vector3(484, 86, 235)),
            new DungeonNode(new Vector3(477, 84, 238)),
            new DungeonNode(new Vector3(469, 83, 240)),
            new DungeonNode(new Vector3(462, 81, 242)),
            new DungeonNode(new Vector3(455, 78, 243)),
            new DungeonNode(new Vector3(448, 75, 244)),
            new DungeonNode(new Vector3(441, 72, 245)),
            new DungeonNode(new Vector3(434, 68, 246)),
            new DungeonNode(new Vector3(427, 65, 246)),
            new DungeonNode(new Vector3(420, 61, 246)),
            new DungeonNode(new Vector3(413, 58, 249)),
        };

        public List<string> PriorityUnits { get; } = new List<string>();

        public int RequiredItemLevel { get; } = 100;

        public int RequiredLevel { get; } = 70;

        public Vector3 WorldEntry { get; } = new Vector3(3672, 2170, 36);

        public MapId WorldEntryMapId { get; } = MapId.Northrend;
    }
}