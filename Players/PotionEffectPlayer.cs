using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using CalamityMod;

namespace Hyrulish.Players
{
    public class PotionEffectPlayer : ModPlayer
    {
        public override void ResetEffects()
        {
            // Ensure buffs are reset each frame if not reapplied
        }

        public override void UpdateEquips()
        {
            ApplyPotionEffects();
        }

        private void ApplyPotionEffects()
        {
            // Define the potion item IDs and their corresponding buff IDs
            (int potionID, int buffID)[] vanillaPotions = new (int, int)[]
              {
                // VANILLA TERRARIA - Toutes potions
                  (ItemID.SpelunkerPotion, BuffID.Spelunker),
                  (ItemID.IronskinPotion, BuffID.Ironskin),
                  (ItemID.SwiftnessPotion, BuffID.Swiftness),
                  (ItemID.RegenerationPotion, BuffID.Regeneration),
                  (ItemID.ShinePotion, BuffID.Shine),
                  (ItemID.NightOwlPotion, BuffID.NightOwl),
                  (ItemID.BattlePotion, BuffID.Battle),
                  (ItemID.ThornsPotion, BuffID.Thorns),
                  (ItemID.WaterWalkingPotion, BuffID.WaterWalking),
                  (ItemID.GillsPotion, BuffID.Gills),
                  (ItemID.ObsidianSkinPotion, BuffID.ObsidianSkin),
                  (ItemID.HunterPotion, BuffID.Hunter),
                  (ItemID.GravitationPotion, BuffID.Gravitation),
                  (ItemID.InvisibilityPotion, BuffID.Invisibility),
                  (ItemID.ShinePotion, BuffID.Shine),
                  (ItemID.MiningPotion, BuffID.Mining),
                  (ItemID.HeartreachPotion, BuffID.Heartreach),
                  (ItemID.MagicPowerPotion, BuffID.MagicPower),
                  (ItemID.ManaRegenerationPotion, BuffID.ManaRegeneration),
                  (ItemID.ArcheryPotion, BuffID.Archery),
                  (ItemID.SonarPotion, BuffID.Sonar),
                  (ItemID.CratePotion, BuffID.Crate),
                  (ItemID.CalmingPotion, BuffID.Calm),
                  (ItemID.TitanPotion, BuffID.Titan),
                  (ItemID.FlipperPotion, BuffID.Flipper),
                  (ItemID.AmmoReservationPotion, BuffID.AmmoReservation),
                  (ItemID.LifeforcePotion, BuffID.Lifeforce),
                  (ItemID.EndurancePotion, BuffID.Endurance),
                  (ItemID.RagePotion, BuffID.Rage),
                  (ItemID.WrathPotion, BuffID.Wrath),
                  (ItemID.SummoningPotion, BuffID.Summoning),
                  (ItemID.BuilderPotion, BuffID.Builder),
                  (2329, 111), // Dangersense
                  (ItemID.FeatherfallPotion, BuffID.Featherfall),
                  (ItemID.WarmthPotion, BuffID.Warmth),
                  (ItemID.InfernoPotion, BuffID.Inferno),
                  (ItemID.FishingPotion, BuffID.Fishing),
                  (ItemID.Ale, BuffID.Tipsy),
                  (ModContent.ItemType<CalamityMod.Items.Potions.ZergPotion>(),  ModContent.BuffType<CalamityMod.Buffs.Potions.Zerg>())
              };

            foreach ((int potionID, int buffID) in vanillaPotions)
            {
                if (HasPotionStack(potionID, 30))
                {
                    Player.AddBuff(buffID, 2); // Buff à courte durée pour rapidement se stop si le stack est cut
                }
            }

                // Define the potion item IDs and their corresponding buff IDs for Calamity potions
                (int potionID, int buffID)[] calamityPotions = new (int, int)[]
                {
                    (ModContent.ItemType<CalamityMod.Items.Potions.ZergPotion>(),  ModContent.BuffType<CalamityMod.Buffs.Potions.Zerg>())
                };

                foreach ((int potionID, int buffID) in calamityPotions)
                {
                Mod calamityMod = ModLoader.GetMod("CalamityMod");
                if (calamityMod != null)
                {
                    if (HasPotionStack(potionID, 30))
                    {
                        Player.AddBuff(buffID, 2);
                    }
                }
                else
                {
                    Mod.Logger.Warn("CalamityMod not loaded. Ensure it is installed and enabled.");
                }
            }
        }

        private bool HasPotionStack(int potionID, int requiredStack)
        {
            int count = 0;
            for (int i = 0; i < Player.inventory.Length; i++)
            {
                if (Player.inventory[i].type == potionID)
                {
                    count += Player.inventory[i].stack;
                }

                if (count >= requiredStack)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
