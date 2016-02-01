using AutoBuddy.Humanizers;
using EloBuddy;

namespace AutoBuddy
{
    internal class Disrespekt
    {
        public Disrespekt()
        {
            //Game.OnNotify += Game_OnNotify;
        }

        private static void Game_OnNotify(GameNotifyEventArgs args)
        {

            if (args.EventId == GameEventId.OnChampionKill && args.NetworkId == AutoWalker.p.NetworkId&&RandGen.r.Next(10)>5)
                Player.DoMasteryBadge();

            if (args.EventId == GameEventId.OnChampionDoubleKill && args.NetworkId == AutoWalker.p.NetworkId &&
                RandGen.r.Next(10) > 5)
                Player.DoEmote(Emote.Laugh);

        }
    }
}
