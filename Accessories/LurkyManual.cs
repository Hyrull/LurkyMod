using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Hyrulish.Accessories
{
	public class LurkyManual : ModItem
	{
		public override void SetStaticDefaults()
		{
            // DisplayName.SetDefault("Lurky's weapons manual");
            // Tooltip.SetDefault("10% increased critical strike chance with Lurky's weapons");
		}

		public override void SetDefaults()
		{
			Item.width = 20;
			Item.height = 20;
			Item.value = Item.sellPrice(gold: 5);
			Item.rare = ItemRarityID.Yellow;
			Item.accessory = true;
			        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.GetModPlayer<GlobalPlayer>().LurkyCrit += 0.10f;
        }


        public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Book, 1);
			recipe.AddIngredient(ItemID.HallowedBar, 5);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.Register();

        }
	}
}