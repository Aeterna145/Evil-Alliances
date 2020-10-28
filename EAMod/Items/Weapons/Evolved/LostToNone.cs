using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EAMod.Items.Weapons.Evolved
{
    public class LostToNone : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lost To None");
            Tooltip.SetDefault("An artifact, reformed for the modern age.");
        }
        public override void SetDefaults()
        {
            item.width = 72;
            item.height = 74;
            item.damage = 60;
            item.knockBack = 4;
            item.crit = 4;
            item.useTime = 10;
            item.useAnimation = 10;

            item.melee = true;
            item.autoReuse = false;

            item.useStyle = ItemUseStyleID.SwingThrow;
            item.UseSound = SoundID.Item1;
        }
        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            
        }
    }
}
