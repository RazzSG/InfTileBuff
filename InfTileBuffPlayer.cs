using Terraria.ID;
using Terraria.ModLoader;

namespace InfTileBuff
{
    public class InfTileBuffPlayer : ModPlayer
    {
        public bool BewitchingTableTileBuff;
        public bool SharpeningStationTileBuff;
        public bool CrystalBallTileBuff;
        public bool AmmoBoxTileBuff;

        public override void ResetEffects()
        {
            BewitchingTableTileBuff = false;
            SharpeningStationTileBuff = false;
            CrystalBallTileBuff = false;
            AmmoBoxTileBuff = false;
        }

        public override void PostUpdateMiscEffects()
        {
            if (BewitchingTableTileBuff)
                player.AddBuff(BuffID.Bewitched, 2);

            if (SharpeningStationTileBuff)
                player.AddBuff(BuffID.Sharpened, 2);

            if (CrystalBallTileBuff)
                player.AddBuff(BuffID.Clairvoyance, 2);

            if (AmmoBoxTileBuff)
                player.AddBuff(BuffID.AmmoBox, 2);
        }
    }
}