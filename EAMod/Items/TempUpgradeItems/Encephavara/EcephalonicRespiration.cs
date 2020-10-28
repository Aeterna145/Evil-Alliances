using Terraria;
using Terraria.ModLoader;

namespace EAMod.Items.TempUpgradeItems.Encephavara
{
    public class EcephalonicRespiration : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Encephalonic Respiration");
            Tooltip.SetDefault("Allows you to breathe the gas in the Underground Crimson..."
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
            if (player.GetModPlayer<EEPlayer>().EncephResp == false)
            {
                return true;
            }
            if (player.GetModPlayer<EEPlayer>().EncephResp == true)
            {
                return false;
            }
            return base.CanUseItem(player);
        }
        public override bool UseItem(Player player)
        {
            return player.GetModPlayer<EEPlayer>().EncephResp = true;
        }
    }
}