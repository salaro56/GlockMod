using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GlockMod.HJD
{
    class DamagePlayer : ModPlayer
    {
        public static DamagePlayer ModPlayer(Player player)
        {
            return player.GetModPlayer<DamagePlayer>();
        }

        public float hjdDamageAdd;
        public float hjdDamageMult = 1f;
        public float hjdKnockback;
        public int hjdCrit = 4;

        public override void ResetEffects()
        {
            ResetVariables();
        }

        private void ResetVariables()
        {
            hjdDamageAdd = 0f;
            hjdDamageMult = 1f;
            hjdKnockback = 0f;
            hjdKnockback = 0f;
        }
    }
}
