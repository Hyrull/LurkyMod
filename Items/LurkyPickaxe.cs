using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Hyrulish.Items
{
	public class LurkyPickaxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Lurky's Pickaxe");
		}

		public override void SetDefaults()
		{
			Item.damage = 11;
			Item.DamageType = DamageClass.Melee;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 16;
			Item.useAnimation = 16;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 2;
			Item.value = 1500;
            Item.rare = ItemRarityID.LightRed;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.pick = 130;
			Item.useTurn = true;
			Item.tileBoost = 2;

		}

        public override void ModifyWeaponDamage(Player player, ref StatModifier damage)
        {
            damage += player.GetModPlayer<GlobalPlayer>().LurkyDmg;
        }
        public override void ModifyWeaponCrit(Player player, ref float crit)
        {
			crit += player.GetModPlayer<GlobalPlayer>().LurkyCrit;
        }
        public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.IronPickaxe, 1);
            recipe.AddIngredient(ItemID.Gel, 10);
            recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}