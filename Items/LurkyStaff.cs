using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Hyrulish.Items
{
	public class LurkyStaff : ModItem
	{
		public override void SetStaticDefaults()
		{
            // DisplayName.SetDefault("Lurky's Staff");
            // Tooltip.SetDefault("Casts an electrosphere");
		}

		public override void SetDefaults()
		{
			Item.damage = 40;
			Item.DamageType = DamageClass.Magic;
			Item.mana = 15;
			Item.width = 40; 
			Item.height = 40;
			Item.useTime = 22;
			Item.useAnimation = 22;
			Item.useStyle = ItemUseStyleID.Thrust;
			Item.value = Item.sellPrice(gold: 8);
            Item.rare = ItemRarityID.Cyan;
			Item.UseSound = SoundID.Item92;
			Item.autoReuse = true;
			Item.useTurn = true;
			Item.shoot = ProjectileID.Electrosphere;
			Item.shootSpeed = 12f;
			Item.scale = 1.0f;
		}

        public override void ModifyWeaponDamage(Player player, ref StatModifier damage)
        {
			damage += player.GetModPlayer<GlobalPlayer>().LurkyDmg;
        }
        public override void ModifyWeaponCrit(Player player, ref float crit)
        {
            crit += player.GetModPlayer<GlobalPlayer>().LurkyCrit;
        }
	}
}