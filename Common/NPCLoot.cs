using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.GameContent.ItemDropRules;
using Hyrulish.Items;
using Hyrulish.Accessories;

namespace Hyrulish.Common;

internal class NPCLoot : GlobalNPC
{
    public override void ModifyNPCLoot(NPC npc, Terraria.ModLoader.NPCLoot npcLoot)
    {
        if (npc.netID == NPCID.WallofFlesh)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<LurkyEmblem>(),4, 1, 1 ));
        }
    }

    public override void ModifyShop(NPCShop shop)
    {
        if (shop.NpcType == NPCID.Wizard)
        {
            shop.Add<LurkyStaff>();
        }
    }
}
