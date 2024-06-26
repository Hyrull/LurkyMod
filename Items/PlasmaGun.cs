using Terraria;
using Terraria.ID;
using Terraria.Audio;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Hyrulish.Projectiles;

namespace Hyrulish.Items
{
	public class PlasmaGun : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Lurky's Plasma Gun"); 
			// Tooltip.SetDefault("Converts normal bullets into plasma balls");
		}

        public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)

        {

            if (type == ProjectileID.Bullet)

            { // or ProjectileID.WoodenArrowFriendly

                type = ModContent.ProjectileType<PlasmaProj>(); // or ProjectileID.FireArrow;
				player.GetModPlayer<GlobalPlayer>().ShootingPlasma = true;

            }

        }

        public override void SetDefaults()
		{
			Item.damage = 12;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 6;
			Item.useAnimation = 6;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.knockBack = 0.2f;
			Item.value = 8000;
			Item.UseSound = new SoundStyle($"{nameof(Hyrulish)}/Sounds/PlasmaGun")
			{
				Volume = 1f,
				PitchVariance = 0.2f,
			};
			Item.autoReuse = true;
			Item.shoot = ProjectileID.Bullet;
			Item.useAmmo = AmmoID.Bullet;
			Item.shootSpeed = 8f;
			Item.noMelee = true;
			Item.scale = 1f;
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
			Recipe Corruptrecipe = CreateRecipe();
			Corruptrecipe.AddIngredient(ItemID.LaserRifle, 1);
			Corruptrecipe.AddIngredient(ItemID.ShadowScale, 8);
			Corruptrecipe.AddTile(TileID.Anvils);
			Corruptrecipe.Register();

            Recipe Crimsonrecipe = CreateRecipe();
            Crimsonrecipe.AddIngredient(ItemID.LaserRifle, 1);
            Crimsonrecipe.AddIngredient(ItemID.TissueSample, 8);
            Crimsonrecipe.AddTile(TileID.Anvils);
            Crimsonrecipe.Register();

        }

	}
    }