﻿using AmeisenBotX.Core.Data.Objects.WowObjects;
using AmeisenBotX.Core.Movement.Enums;
using AmeisenBotX.Core.Movement.Pathfinding.Objects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AmeisenBotX.Core.StateMachine.States.Idle.Actions
{
    public class AuctionHouseIdleAction : IIdleAction
    {
        public AuctionHouseIdleAction()
        {
            Rnd = new Random();
        }

        public bool AutopilotOnly => true;

        public int MaxCooldown => 20 * 60 * 1000;

        public int MaxDuration => 4 * 60 * 1000;

        public int MinCooldown => 20 * 60 * 1000;

        public int MinDuration => 2 * 60 * 1000;

        private DateTime AuctioneerTalkTime { get; set; }

        private Vector3 CurrentAuctioneer { get; set; }

        private Vector3 OriginPosition { get; set; }

        private bool ReturnedToOrigin { get; set; }

        private Random Rnd { get; }

        private bool TalkedToAuctioneer { get; set; }

        public bool Enter()
        {
            TalkedToAuctioneer = false;
            AuctioneerTalkTime = default;
            OriginPosition = WowInterface.I.ObjectManager.Player.Position;

            if (WowInterface.I.Db.TryGetPointsOfInterest(WowInterface.I.ObjectManager.MapId, Data.Db.Enums.PoiType.Auctioneer, WowInterface.I.ObjectManager.Player.Position, 256.0, out IEnumerable<Vector3> auctioneers))
            {
                CurrentAuctioneer = WowInterface.I.PathfindingHandler.GetRandomPointAround((int)WowInterface.I.ObjectManager.MapId, auctioneers.OrderBy(e => e.GetDistance(WowInterface.I.ObjectManager.Player.Position)).First(), 2.5f);
                return true;
            }

            return false;
        }

        public void Execute()
        {
            if (!TalkedToAuctioneer)
            {
                if (CurrentAuctioneer.GetDistance(WowInterface.I.ObjectManager.Player.Position) > 3.2f)
                {
                    WowInterface.I.MovementEngine.SetMovementAction(MovementAction.Moving, CurrentAuctioneer);
                }
                else
                {
                    WowInterface.I.MovementEngine.StopMovement();

                    WowUnit auctioneer = WowInterface.I.ObjectManager.WowObjects.OfType<WowUnit>()
                        .FirstOrDefault(e => e.IsAuctioneer && e.Position.GetDistance(CurrentAuctioneer) < 1.0f);

                    if (auctioneer != null)
                    {
                        WowInterface.I.HookManager.WowFacePosition(WowInterface.I.ObjectManager.Player, auctioneer.Position);
                        WowInterface.I.HookManager.WowUnitRightClick(auctioneer);
                    }

                    TalkedToAuctioneer = true;
                    AuctioneerTalkTime = DateTime.UtcNow + TimeSpan.FromSeconds(Rnd.Next(120, 180));
                }
            }
            else if (!ReturnedToOrigin && AuctioneerTalkTime < DateTime.UtcNow)
            {
                if (CurrentAuctioneer.GetDistance(OriginPosition) > 8.0f)
                {
                    WowInterface.I.MovementEngine.SetMovementAction(MovementAction.Moving, OriginPosition);
                }
                else
                {
                    WowInterface.I.MovementEngine.StopMovement();
                    ReturnedToOrigin = true;
                }
            }
        }
    }
}