using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Hyrulish.Items
{
	public class LurkyBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Lurky's Bow");
			// Tooltip.SetDefault("So many grandmas died in the process of making this bow");
		}

		public override void SetDefaults()
		{
			Item.damage = 33;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 21;
			Item.useAnimation = 21;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.knockBack = 6;
			Item.value = 1000;
            Item.rare = ItemRarityID.Cyan;
			Item.UseSound = SoundID.Item5;
			Item.autoReuse = true;
			Item.shoot = ProjectileID.WoodenArrowFriendly;
			Item.useAmmo = AmmoID.Arrow;
			Item.shootSpeed = 6f;
			Item.noMelee = true;

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
			recipe.AddIngredient(ItemID.Wood, 8);
            recipe.AddIngredient(ItemID.HellstoneBar, 3);
            recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}