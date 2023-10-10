using Hyrulish.Items;
using System.Runtime.InteropServices;
using Terraria.ModLoader;

namespace Hyrulish
	{
        public class GlobalPlayer : ModPlayer
        {
           public bool ShootingPlasma = false;
        public bool LurkysGift = false;
        public float LurkyDmg = 0f;
        public float LurkyCrit = 0f;

            public override void PostUpdate()
            {
            Player.moveSpeed += 0.50f;
            }

            public override void ResetEffects()
            {
                ShootingPlasma = false;
                LurkysGift = false;
                LurkyDmg = 0f;
                LurkyCrit= 0f;
            }
        }
    }