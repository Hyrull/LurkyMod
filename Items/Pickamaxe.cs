using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Hyrulish.Items
{
    public class Pickamaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Pickamaxe");
            // Tooltip.SetDefault("Every tool, every use, all at once");
        }

        public override void SetDefaults()
        {
            Item.damage = 35;
            Item.noMelee= false;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 10;
            Item.useAnimation = 10;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.knockBack = 5;
            Item.value = Item.sellPrice(gold: 5);
            Item.rare = ItemRarityID.Yellow;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
            Item.scale = 1f;

            // Properties for pickaxe
            Item.pick = 200;                    // Pickaxe power (higher values mine harder blocks)
            Item.tileBoost = 4;                 // Mining speed multiplier (higher values mine faster)

            // Properties for hammer
            Item.hammer = 80;                  // Hammer power (higher values can break harder tiles)

            // Properties for axe
            Item.axe = 15;                     // Axe power (multiply by 5 for the actual value)

            // Additional properties for multitool
            Item.useTurn = true;                // Allows using the item while facing the opposite direction
            Item.useStyle = ItemUseStyleID.Swing; // Mining and combat animation style
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.IronPickaxe, 1);
            recipe.AddIngredient(ItemID.Bone, 25);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }

    }
}