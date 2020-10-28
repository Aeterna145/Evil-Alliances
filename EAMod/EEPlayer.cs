using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace EAMod
{
    public class EEPlayer : ModPlayer
    {
        public bool CancerGas;
        public bool EncephGas;
        public bool EncephMut;
        public bool CarcinMut;

        public bool CarcinResp = false;
        public bool EncephResp = false;

        public override TagCompound Save()
        {
            return new TagCompound
            {
                {"EncephResp", EncephResp},
                {"CarcinResp", CarcinResp},
            };
        }
        public override void Load(TagCompound tag)
        {
            EncephResp = tag.GetBool("EncephResp");
            CarcinResp = tag.GetBool("CarcinResp");
        }
        public override void ResetEffects()
        {
            CancerGas = false;
            EncephGas = false;
        }
        public override void UpdateDead()
        {
            CancerGas = false;
            EncephGas = false;
            EncephMut = false;
            CarcinMut = false;
        }
        public override void UpdateBadLifeRegen()
        {
            if (CancerGas)
            {
                if (player.lifeRegen > 0){
                    player.lifeRegen = 0;
                }
                player.lifeRegenTime = 0;
                player.lifeRegen -= 20;
            }
            if (EncephGas)
            {
                if (player.lifeRegen > 0){
                    player.lifeRegen = 0;
                }
                player.lifeRegenTime = 0;
                player.lifeRegen -= 20;
            }
        }
    }
}
