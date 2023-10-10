using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Hyrulish.Accessories
{
	public class LurkyEmblem : ModItem
	{
		public override void SetStaticDefaults()
		{
            // DisplayName.SetDefault("Lurky's Emblem");
            // Tooltip.SetDefault("15% increased damage with Lurky's weapons");
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
			player.GetModPlayer<GlobalPlayer>().LurkyDmg += 0.15f;
        }


        public override void AddRecipes()
		{
			Recipe Warrecipe = CreateRecipe();
			Warrecipe.AddIngredient(ItemID.WarriorEmblem, 1);
			Warrecipe.AddIngredient(ItemID.SoulofLight, 5);
			Warrecipe.AddIngredient(ItemID.SoulofNight, 5);
			Warrecipe.AddTile(TileID.Anvils);
			Warrecipe.Register();

            Recipe Ranrecipe = CreateRecipe();
            Ranrecipe.AddIngredient(ItemID.RangerEmblem, 1);
            Ranrecipe.AddIngredient(ItemID.SoulofLight, 5);
            Ranrecipe.AddIngredient(ItemID.SoulofNight, 5);
            Ranrecipe.AddTile(TileID.Anvils);
            Ranrecipe.Register();

            Recipe Sorrecipe = CreateRecipe();
            Sorrecipe.AddIngredient(ItemID.SorcererEmblem, 1);
            Sorrecipe.AddIngredient(ItemID.SoulofLight, 5);
            Sorrecipe.AddIngredient(ItemID.SoulofNight, 5);
            Sorrecipe.AddTile(TileID.Anvils);
            Sorrecipe.Register();

            Recipe Sumrecipe = CreateRecipe();
            Sumrecipe.AddIngredient(ItemID.SummonerEmblem, 1);
            Sumrecipe.AddIngredient(ItemID.SoulofLight, 5);
            Sumrecipe.AddIngredient(ItemID.SoulofNight, 5);
            Sumrecipe.AddTile(TileID.Anvils);
            Sumrecipe.Register();
        }
	}
}