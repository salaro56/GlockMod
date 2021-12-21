using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace GlockMod
{
    class MyGlobalItem : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if(item.type == ItemID.Coal)
            {
                item.maxStack = 999;
            }
        }
    }
}
