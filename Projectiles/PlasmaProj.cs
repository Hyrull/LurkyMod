using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Hyrulish.Projectiles
{

	public class PlasmaProj : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Plasma Projectile");
		}

		public override void SetDefaults()
		{
			Projectile.damage = 5000;
			Projectile.width = 8;
			Projectile.height = 8;
			Projectile.aiStyle = 1;
			Projectile.friendly = true;
			Projectile.hostile = false;
			Projectile.penetrate = 1;
			Projectile.timeLeft = 400;
			Projectile.light = 0.8f;
			Projectile.ignoreWater = true;
			Projectile.tileCollide = true;
			Projectile.scale = 1.2f;
			Projectile.extraUpdates = 1;
			AIType = ProjectileID.Bullet;

		}

		public override void AI()
		{
			Projectile.aiStyle = 0;
			Lighting.AddLight(Projectile.position, 0.2f, 0.2f, 0.6f);
			Lighting.Brightness(1, 1);

		}
		public override void Kill(int timeLeft)
		{
			Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, DustID.Cloud, 0f, 0f, 0, default, 1f);
		}
	}
}