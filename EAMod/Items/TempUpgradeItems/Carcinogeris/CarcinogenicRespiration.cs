using Terraria;
using Terraria.ModLoader;

namespace EAMod.Items.TempUpgradeItems.Carcinogeris
{
    public class CarcinogenicRespiration : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Carcinogenic Respiration");
            Tooltip.SetDefault("Allows you to breathe the gas in the Underground Corruption..." 
                + "\nConsume to obtain this upgrade");
        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 1;

            item.consumable = true;
        }
        public override bool CanUseItem(Player player)
        {
            if (player.GetModPlayer<EEPlayer>().CarcinResp == false)
            {
                return true;
            }
            if (player.GetModPlayer<EEPlayer>().CarcinResp == true)
            {
                return false;
            }
            return base.CanUseItem(player);
        }
        public override bool UseItem(Player player)
        {
            return player.GetModPlayer<EEPlayer>().CarcinResp = true;
        }
    }
}
