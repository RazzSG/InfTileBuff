using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace InfTileBuff
{
    public class InfTileBuffGlobalItem : GlobalItem
    {
        public override void UpdateInventory(Item item, Player player)
        {
            InfTileBuffPlayer modPlayer = player.GetModPlayer<InfTileBuffPlayer>();
            
            switch (item.type)
            {
                case ItemID.BewitchingTable:
                    if (item.favorited)
                        modPlayer.BewitchingTableTileBuff = true;
                    break;

                case ItemID.SharpeningStation:
                    if (item.favorited)
                        modPlayer.SharpeningStationTileBuff = true;
                    break;
                
                case ItemID.CrystalBall:
                    if (item.favorited)
                        modPlayer.CrystalBallTileBuff = true;
                    break;
                
                case ItemID.AmmoBox:
                    if (item.favorited)
                        modPlayer.AmmoBoxTileBuff = true;
                    break;
            }
        }
    }
}