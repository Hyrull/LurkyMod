using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Hyrulish.Items
{
	public class LurkySword : ModItem
	{
		public override void SetStaticDefaults()
		{
            // DisplayName.SetDefault("Lurky's Sword");
            // Tooltip.SetDefault("Lurky's hopefully not too overpowered sword");
		}

		public override void SetDefaults()
		{
			Item.damage = 59;
			Item.DamageType = DamageClass.Melee;
			Item.width = 40; 
			Item.height = 40;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 4;
			Item.value = Item.sellPrice(gold: 5);
            Item.rare = ItemRarityID.Cyan;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.useTurn = true;
			Item.shoot = ProjectileID.EnchantedBeam;
			Item.shootSpeed = 12f;
			Item.scale = 1.5f;
		}

        public override void ModifyWeaponDamage(Player player, ref StatModifier damage)
        {
			damage += player.GetModPlayer<GlobalPlayer>().LurkyDmg;
        }
        public override void ModifyWeaponCrit(Player player, ref float crit)
        {
            crit += player.GetModPlayer<GlobalPlayer>().LurkyCrit;
        }

        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            if (Main.rand.NextBool(3))
            {
                Dust dust = Dust.NewDustDirect(
                    new Vector2(hitbox.X, hitbox.Y),
                    hitbox.Width,
                    hitbox.Height,
                    DustID.GolfPaticle, // Replace with desired dust ID or custom dust type
                    0f, 0f, 0, default(Color), 2f); 

                dust.velocity *= 0.5f;
                dust.noGravity = true;
            }
        }
        public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
        {
			target.AddBuff(BuffID.OnFire, 45);
        }

        public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.HallowedBar, 12);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.Register();
		}
	}
}