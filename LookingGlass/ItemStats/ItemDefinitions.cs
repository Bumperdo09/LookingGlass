﻿using RoR2;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using static RoR2.HealthComponent;

namespace LookingGlass.ItemStatsNameSpace
{
    public class ItemDefinitions
    {
        public static Dictionary<int, ItemStatsDef> allItemDefinitions = new Dictionary<int, ItemStatsDef>();
        public static void RegisterItemStatsDef(ItemStatsDef itemStatsDef, ItemIndex itemIndex)
        {
            allItemDefinitions.Add((int)itemIndex, itemStatsDef);
        }
        internal static void RegisterAll()
        {
            //foreach (var item in ItemCatalog.allItems)
            //{
            //    Log.Debug($"==========  {item}  {ItemCatalog.GetItemDef(item).nameToken}  {ItemCatalog.GetItemDef(item).name}");
            //}


            // ---------- White Items --------------------------------------------------------------------------------

            //Tougher Times
            ItemStatsDef itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Block Chance: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(Utils.GetHyperbolicStacking(0.15f, 0.15f, stackCount));
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.Bear.itemIndex, itemStat);


            //Armor-Piercing Rounds
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Bonus Damage: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Damage);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(0.2f * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.BossDamageBonus.itemIndex, itemStat);


            //Backup Magazine
            //itemStat = new ItemStatsDef();
            //itemStat.descriptions.Add("Skill Charges: ");
            //itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            //itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Number);
            //itemStat.calculateValues = (luck, stackCount, procChance) =>
            //{
            //    List<float> values = new();
            //    values.Add(stackCount);
            //    return values;
            //};
            //allItemDefinitions.Add((int)RoR2Content.Items.SecondarySkillMagazine.itemIndex, itemStat);


            //Bison Steak
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Bonus Health: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Health);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.FlatHealth);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(25 * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.FlatHealth.itemIndex, itemStat);


            //Bundle of Fireworks
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Fireworks: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Damage);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Number);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(4 + 4 * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.Firework.itemIndex, itemStat);


            //Bustling Fungus
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Healing: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Healing);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.PercentHealing);
            itemStat.descriptions.Add("Radius: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Meters);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(0.0225f + 0.0225f * stackCount);
                values.Add(1.5f + 1.5f * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.Mushroom.itemIndex, itemStat);


            //Cautious Slug
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Healing: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Healing);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.FlatHealing);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(3f * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.HealWhileSafe.itemIndex, itemStat);


            //Crowbar
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Bonus Damage: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Damage);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(0.75f * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.Crowbar.itemIndex, itemStat);


            //Delicate Watch
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Bonus Damage: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Damage);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(0.2f * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)DLC1Content.Items.FragileDamageBonus.itemIndex, itemStat);


            //Energy Drink
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Sprint Bonus: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(0.25f * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.SprintBonus.itemIndex, itemStat);


            //Focus Crystal
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Bonus Damage: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Damage);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(0.2f * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.NearbyDamageBonus.itemIndex, itemStat);


            //Gasoline
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Total Damage: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Damage);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.descriptions.Add("Burn Duration: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Damage);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Number);
            itemStat.descriptions.Add("Radius: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Meters);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(2.25f + 0.75f * stackCount);
                values.Add(1.5f + 1.5f * stackCount);
                values.Add(8f + 4f * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.IgniteOnKill.itemIndex, itemStat);


            //Lens-Maker's Glasses
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Crit Chance: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Damage);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(Utils.CalculateChanceWithLuck(.1f * stackCount, luck));
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.CritGlasses.itemIndex, itemStat);


            //Medkit
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Healing: <style=cIsHealing>20</style> + ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Healing);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.PercentHealth);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(0.05f * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.Medkit.itemIndex, itemStat);


            //Mocha
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Attack Speed: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Damage);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.descriptions.Add("Movement Speed: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(0.075f * stackCount);
                values.Add(0.07f * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)DLC1Content.Items.AttackSpeedAndMoveSpeed.itemIndex, itemStat);


            //Monster Tooth
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Healing: <style=cIsHealing>8</style> + ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Healing);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.PercentHealth);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(0.02f * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.Tooth.itemIndex, itemStat);


            //Oddly-shaped Opal
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Bonus Armor: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Armor);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Number);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(100f * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)DLC1Content.Items.OutOfCombatArmor.itemIndex, itemStat);


            //Paul's Goat Hoof
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Movement Speed: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(0.14f * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.Hoof.itemIndex, itemStat);


            //Personal Shield Generator
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Shield Strength: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.PercentHealth);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(0.08f * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.PersonalShield.itemIndex, itemStat);


            //Power Elixir
            //itemStat = new ItemStatsDef();
            //itemStat.descriptions.Add("Charges: ");
            //itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            //itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Number);
            //itemStat.calculateValues = (luck, stackCount, procChance) =>
            //{
            //    List<float> values = new();
            //    values.Add(stackCount);
            //    return values;
            //};
            //allItemDefinitions.Add((int)DLC1Content.Items.HealingPotion.itemIndex, itemStat);


            //Repulsion Armor Plate
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Damage Reduction: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Armor);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Number);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(5 * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.ArmorPlate.itemIndex, itemStat);


            //Roll of Pennies
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Gold Gained: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Gold);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Number);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(3 * stackCount * Run.instance.difficultyCoefficient);
                return values;
            };
            allItemDefinitions.Add((int)DLC1Content.Items.GoldOnHurt.itemIndex, itemStat);


            //Rusted Key
            //itemStat = new ItemStatsDef();
            //itemStat.descriptions.Add("Charges: ");
            //itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            //itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Number);
            //itemStat.calculateValues = (luck, stackCount, procChance) =>
            //{
            //    List<float> values = new();
            //    values.Add(stackCount);
            //    return values;
            //};
            //allItemDefinitions.Add((int)RoR2Content.Items.TreasureCache.itemIndex, itemStat);


            //Soldier's Syringe
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Attack Speed: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Damage);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(0.15f * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.Syringe.itemIndex, itemStat);


            //Sticky Bomb
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Bomb Chance: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Damage);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.hasChance = true;
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(Utils.CalculateChanceWithLuck(.05f * stackCount * procChance, luck));
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.StickyBomb.itemIndex, itemStat);


            //Stun Grenade
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Stun Chance: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.hasChance = true;
            itemStat.chanceScaling = ItemStatsDef.ChanceScaling.Hyperbolic;
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(Utils.CalculateChanceWithLuck(Utils.GetHyperbolicStacking(0.05f, 0.05f, stackCount) * procChance, luck));
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.StunChanceOnHit.itemIndex, itemStat);


            //Topaz Brooch
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Barrier On-Kill: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Healing);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.FlatHealth);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(15 * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.BarrierOnKill.itemIndex, itemStat);


            //Tri-Tip Dagger
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Bleed Chance: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Damage);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.hasChance = true;
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(Utils.CalculateChanceWithLuck(0.1f * stackCount * procChance, luck));
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.BleedOnHit.itemIndex, itemStat);


            //Warbanner
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Effect Radius: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Meters);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(8 + 8 * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.WardOnLevel.itemIndex, itemStat);


            // ---------- Green Items --------------------------------------------------------------------------------

            //AtG Missile Mk. 1
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Fire Chance: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.descriptions.Add("Damage: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Damage);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.hasChance = true;
            itemStat.chanceScaling = ItemStatsDef.ChanceScaling.DoesNotScale;
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(Utils.CalculateChanceWithLuck(0.1f * procChance, luck));
                values.Add(3f * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.Missile.itemIndex, itemStat);


            //Bandolier
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Drop Chance: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(Utils.GetBandolierStacking(stackCount));
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.Bandolier.itemIndex, itemStat);


            //Berzerker's Pauldron
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Buff Duration: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Seconds);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(2 + 4 * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.WarCryOnMultiKill.itemIndex, itemStat);


            //Chronobauble
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Slow Duration: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Seconds);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(2 * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.SlowOnHit.itemIndex, itemStat);


            //Death Mark
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Mark Duration: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Seconds);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(7 * stackCount);
                return values; 
            };
            allItemDefinitions.Add((int)RoR2Content.Items.DeathMark.itemIndex, itemStat);


            //Fuel Cell
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Extra Charges: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Number);
            itemStat.descriptions.Add("Cooldown Reduction: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(stackCount);
                values.Add(Utils.GetExponentialStacking(0.15f, 0.15f, stackCount));
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.EquipmentMagazine.itemIndex, itemStat);


            //Ghor's Tome
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Drop Chance: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(Utils.CalculateChanceWithLuck(0.04f * stackCount, luck));
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.BonusGoldPackOnKill.itemIndex, itemStat);


            //Harvester's Scythe
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Healing: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Healing);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.FlatHealth);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(4 + 4 * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.HealOnCrit.itemIndex, itemStat);


            //Hopoo Feather
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Extra Jumps: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Number);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.Feather.itemIndex, itemStat);


            //Hunter's Harpoon
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Buff Duration: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Seconds);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(0.5f + 0.5f * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)DLC1Content.Items.MoveSpeedOnKill.itemIndex, itemStat);


            //Ignition Tank
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Bonus Damage: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Damage);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(3 * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)DLC1Content.Items.StrengthenBurn.itemIndex, itemStat);


            //Infusion
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Health On-Kill: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Health);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.FlatHealth);
            itemStat.descriptions.Add("Max Health: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Health);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.FlatHealth);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(stackCount);
                values.Add(100 * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.Infusion.itemIndex, itemStat);


            //Kjaro's Band
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Total Damage: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Damage);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(3 * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.FireRing.itemIndex, itemStat);


            //Leeching Seed
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Healing On-Hit: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Healing);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.FlatHealth);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.Seed.itemIndex, itemStat);


            //Lepton Daisy
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Healing Novas: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Healing);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Number);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.TPHealingNova.itemIndex, itemStat);


            //Old Guillotine
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Threshold: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Health);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.PercentHealth);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(Utils.GetHyperbolicStacking(0.13f, 0.13f, stackCount));
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.ExecuteLowHealthElite.itemIndex, itemStat);


            //Old War Stealthkit
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Recharge Time: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Seconds);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(Utils.GetExponentialRechargeTime(30f, 0.5f, stackCount));
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.Phasing.itemIndex, itemStat);


            //Predatory Instincts
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Max Attack Speed: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Damage);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(0.12f + 0.24f * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.AttackSpeedOnCrit.itemIndex, itemStat);


            //Razorwire
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Targets: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Damage);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Meters);
            itemStat.descriptions.Add("Radius: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Damage);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Meters);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(3 + 2 * stackCount);
                values.Add(15 + 10 * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.Thorns.itemIndex, itemStat);


            //Red Whip
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Speed Bonus: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(0.3f * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.SprintOutOfCombat.itemIndex, itemStat);


            ////Regenerating Scrap
            //itemStat = new ItemStatsDef();
            //itemStat.descriptions.Add("Charges: ");
            //itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            //itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Number);
            //itemStat.calculateValues = (luck, stackCount, procChance) =>
            //{
            //    List<float> values = new();
            //    values.Add(stackCount);
            //    return values;
            //};
            //allItemDefinitions.Add((int)ItemCatalog.FindItemIndex("RegeneratingScrap"), itemStat);


            //Rose Buckler
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Armor Bonus: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Armor);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Number);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(30 * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.SprintArmor.itemIndex, itemStat);


            //Runald's Band
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Slow Duration: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Seconds);
            itemStat.descriptions.Add("Total Damage: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Damage);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(stackCount * 3f);
                values.Add(stackCount * 2.5f);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.IceRing.itemIndex, itemStat);


            //Shipping Request Form
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Common Chance: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.descriptions.Add("Uncommon Chance: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Healing);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.descriptions.Add("Legendary Chance: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Damage);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                float common = .79f;
                float uncommon = .2f * stackCount;
                float rare = .01f * Mathf.Pow(stackCount, 2);
                float sum = common + uncommon + rare;
                values.Add(common / sum);
                values.Add(uncommon / sum);
                values.Add(rare / sum);
                return values;
            };
            allItemDefinitions.Add((int)DLC1Content.Items.FreeChest.itemIndex, itemStat);


            //Shuriken
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Damage: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Damage);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.descriptions.Add("Max Shurikens: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Number);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(3 + stackCount);
                values.Add(2 + stackCount);
                return values;
            };
            allItemDefinitions.Add((int)DLC1Content.Items.PrimarySkillShuriken.itemIndex, itemStat);


            //Squid Polyp
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Attack Speed: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Damage);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.Squid.itemIndex, itemStat);


            //Ukulele
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Proc Chance: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.descriptions.Add("Max Targets: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Damage);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Number);
            itemStat.descriptions.Add("Chain Distance: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Damage);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Meters);
            itemStat.hasChance = true;
            itemStat.chanceScaling = ItemStatsDef.ChanceScaling.DoesNotScale;
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(Utils.CalculateChanceWithLuck(0.25f * procChance, luck));
                values.Add(1 + 2 * stackCount);
                values.Add(18 + 2 * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.ChainLightning.itemIndex, itemStat);


            //War Horn
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Buff Duration: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Damage);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Seconds);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(4 + 4 * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.EnergizedOnEquipmentUse.itemIndex, itemStat);


            //Wax Quail
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Jump Boost: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Meters);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(10 * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.JumpBoost.itemIndex, itemStat);


            //Will-o'-the-wisp
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Radius: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Damage);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Meters);
            itemStat.descriptions.Add("Pillar Damage: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Damage);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(9.6f + (2.4f * stackCount));
                values.Add(0.7f + (2.8f * stackCount));
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.ExplodeOnDeath.itemIndex, itemStat);


            // ---------- Red Items --------------------------------------------------------------------------------

            //57 Leaf Clover
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Luck: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Number);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.Clover.itemIndex, itemStat);


            //Aegis HOLY SHIT XENOBLADE???
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Healing Converted: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Healing);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(0.5f * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.BarrierOnOverHeal.itemIndex, itemStat);


            //Alien Head
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Cooldown Reduction: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(Utils.GetExponentialStacking(0.25f, 0.25f, stackCount));
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.AlienHead.itemIndex, itemStat);


            //Ben's Raincoat
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Debuffs Ignored: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Number);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(stackCount);
                return values;
            };
            allItemDefinitions.Add((int)DLC1Content.Items.ImmuneToDebuff.itemIndex, itemStat);


            //Bottled Chaos
            //itemStat = new ItemStatsDef();
            //itemStat.descriptions.Add("Random Effects: ");
            //itemStat.valueTypes.Add(ItemStatsDef.ValueType.Damage);
            //itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Number);
            //itemStat.calculateValues = (luck, stackCount, procChance) =>
            //{
            //    List<float> values = new();
            //    values.Add(stackCount);
            //    return values;
            //};
            //allItemDefinitions.Add((int)DLC1Content.Items.RandomEquipmentTrigger.itemIndex, itemStat);


            //Brainstalks
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Frenzy Duration: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Damage);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Seconds);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(4 * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.KillEliteFrenzy.itemIndex, itemStat);


            //Brilliant Behemoth
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Explosion Radius: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Damage);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Meters);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(1.5f + 2.5f * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.Behemoth.itemIndex, itemStat);


            //Ceremonial Dagger
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Dagger Damage: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Damage);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(1.5f * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.Dagger.itemIndex, itemStat);


            //Defensive Microbots
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Projectiles Blocked: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Damage);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Number);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.CaptainDefenseMatrix.itemIndex, itemStat);


            //Dio's Best Friend
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Revives: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Healing);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Number);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.ExtraLife.itemIndex, itemStat);


            //Frost Relic
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Radius: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Damage);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Meters);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(6 + 12 * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.Icicle.itemIndex, itemStat);


            //H3AD-5T v2
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Recharge Time: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Damage);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Seconds);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(Utils.GetExponentialRechargeTime(10, 0.5f, stackCount));
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.FallBoots.itemIndex, itemStat);


            //Happiest Mask
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Spawn Chance: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.descriptions.Add("Ghost Duration: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Damage);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Seconds);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(Utils.CalculateChanceWithLuck(0.07f, luck));
                values.Add(30 * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.GhostOnKill.itemIndex, itemStat);


            //Hardlight Afterburner
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Skill Charges: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Number);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(2 * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.UtilitySkillMagazine.itemIndex, itemStat);


            //Interstellar Desk Plant
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Healing Radius: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Healing);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Meters);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(5 + 5 * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.Plant.itemIndex, itemStat);


            //Laser Scope
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Crit Damage: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Damage);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(stackCount);
                return values;
            };
            allItemDefinitions.Add((int)DLC1Content.Items.CritDamage.itemIndex, itemStat);


            //N'kuhana's Opinion
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Healing Stored: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Healing);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.NovaOnHeal.itemIndex, itemStat);


            //Pocket I.C.B.M.
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Bonus Damage: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Damage);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(-0.5f + 0.5f * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)DLC1Content.Items.MoreMissile.itemIndex, itemStat);


            //Rejuvenation Rack
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Bonus Healing: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Healing);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.IncreaseHealing.itemIndex, itemStat);


            //Resonance Disc
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Piercing Damage: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Damage);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.descriptions.Add("Explosion Damage: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Damage);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(3 * stackCount);
                values.Add(10 * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.LaserTurbine.itemIndex, itemStat);


            //Sentient Meat Hook
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Hook Chance: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.descriptions.Add("Hook Damage: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Damage);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.hasChance = true;
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(Utils.CalculateChanceWithLuck(Utils.GetHyperbolicStacking(0.2f, 0.2f, stackCount) * procChance, luck));
                values.Add(stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.BounceNearby.itemIndex, itemStat);


            //Shattering Justice
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Debuff Duration: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Damage);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Seconds);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(8 * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.ArmorReductionOnHit.itemIndex, itemStat);


            //Soulbound Catalyst
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Cooldown Reduction: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Seconds);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(2 + 2 * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.Talisman.itemIndex, itemStat);


            //Spare Drone Parts
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Drone Buff: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Damage);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(0.5f * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)DLC1Content.Items.DroneWeapons.itemIndex, itemStat);


            //Symbiotic Scorpion
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Armor Reduced On-Hit: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Damage);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Number);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(2 * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)DLC1Content.Items.PermanentDebuffOnHit.itemIndex, itemStat);


            //Unstable Tesla Coil
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Max Targets: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Damage);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Number);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(1 + 2 * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.ShockNearby.itemIndex, itemStat);


            //Wake of Vultures
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Buff Duration: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Damage);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Seconds);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(3 + 5 * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.HeadHunter.itemIndex, itemStat);


            // ---------- Boss Items --------------------------------------------------------------------------------

            //Charged Perforator
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Proc Chance: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.descriptions.Add("Damage: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Damage);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.hasChance = true;
            itemStat.chanceScaling = ItemStatsDef.ChanceScaling.DoesNotScale;
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(Utils.CalculateChanceWithLuck(0.1f * procChance, luck));
                values.Add(5 * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.LightningStrikeOnHit.itemIndex, itemStat);


            //Defense Nucleus
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Max Constructs: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Number);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(4 * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)DLC1Content.Items.MinorConstructOnKill.itemIndex, itemStat);


            //Empathy Cores
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Damage Per Ally: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Damage);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.RoboBallBuddy.itemIndex, itemStat);


            //Genesis Loop
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Recharge Time: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Seconds);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(30 / (1 + stackCount));
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.NovaOnLowHealth.itemIndex, itemStat);


            //Halcyon Seed
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Aurelionite Damage: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Damage);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.descriptions.Add("Aurelionite Health: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Healing);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(0.5f + 0.5f * stackCount);
                values.Add(stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.TitanGoldDuringTP.itemIndex, itemStat);


            //Irradiant Pearl
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("All Stats: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(0.1f * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.ShinyPearl.itemIndex, itemStat);


            //Little Disciple
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Wisp Damage: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Damage);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(3f * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.SprintWisp.itemIndex, itemStat);


            //Mired Urn
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Tethers: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Healing);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Number);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.SiphonOnLowHealth.itemIndex, itemStat);


            //Molten Perforator
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Proc Chance: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.descriptions.Add("Damage: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Damage);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.hasChance = true;
            itemStat.chanceScaling = ItemStatsDef.ChanceScaling.DoesNotScale;
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(Utils.CalculateChanceWithLuck(0.1f * procChance, luck));
                values.Add(3 * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.FireballsOnHit.itemIndex, itemStat);


            //Pearl
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Health Bonus: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Health);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.PercentHealth);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(0.1f * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.Pearl.itemIndex, itemStat);


            //Planula
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Healing: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Healing);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.FlatHealth);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(15 * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.ParentEgg.itemIndex, itemStat);


            //Queen's Gland
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Beetle Guards: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Number);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.BeetleGland.itemIndex, itemStat);


            //Shatterspleen
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Explosion Base Damage: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Damage);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.descriptions.Add("Explosion Scaling: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Damage);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.PercentHealth);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(4 * stackCount);
                values.Add(0.15f * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.BleedOnHitAndExplode.itemIndex, itemStat);


            //Titanic Knurl
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Bonus Health: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Health);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.FlatHealth);
            itemStat.descriptions.Add("Healing: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Healing);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.FlatHealing);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(40 * stackCount);
                values.Add(1.6f * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.Knurl.itemIndex, itemStat);


            // ---------- why are you blue --------------------------------------------------------------------------------

            //Beads of Fealty
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Nothings Done: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Number);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.LunarTrinket.itemIndex, itemStat);


            //Brittle Crown
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Gold Gained: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Gold);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Number);
            itemStat.descriptions.Add("Gold Lost: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Health);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(2 * stackCount * Run.instance.difficultyCoefficient);
                values.Add(stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.GoldOnHit.itemIndex, itemStat);


            //Corpsebloom
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Bonus Healing: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Healing);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.descriptions.Add("Healing Cap: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Healing);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.PercentHealing);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(stackCount);
                values.Add(0.1f * 1 / stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.RepeatHeal.itemIndex, itemStat);


            //Defiant Gouge
            //itemStat = new ItemStatsDef();
            //itemStat.descriptions.Add("Enemy Strength: ");
            //itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            //itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Number);
            //itemStat.calculateValues = (luck, stackCount, procChance) =>
            //{
            //    return new List<float>([stackCount]);
            //};
            //allItemDefinitions.Add((int)RoR2Content.Items.MonstersOnShrineUse.itemIndex, itemStat);


            //Egocentrism
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Orb Cooldown: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Seconds);
            itemStat.descriptions.Add("Max Orbs: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Number);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(3 * 1 / stackCount);
                values.Add(2 + stackCount);
                return values;
            };
            allItemDefinitions.Add((int)DLC1Content.Items.LunarSun.itemIndex, itemStat);


            //Essence of Heresy
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Ruin Duration: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Damage);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Seconds);
            itemStat.descriptions.Add("Recharge Time: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Seconds);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(10 * stackCount);
                values.Add(8 * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.LunarSpecialReplacement.itemIndex, itemStat);


            //Eulogy Zero
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Lunar Item Chance: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(Utils.CalculateChanceWithLuck(0.05f * stackCount, luck));
                return values;
            };
            allItemDefinitions.Add((int)DLC1Content.Items.RandomlyLunar.itemIndex, itemStat);


            //Focused Convergence
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Charging Time: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Seconds);
            itemStat.descriptions.Add("Zone Size: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Health);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(90f / (1f + 0.3f * Mathf.Min(stackCount, 3)));
                values.Add(1.0f / 2 * Mathf.Min(stackCount, 3));
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.FocusConvergence.itemIndex, itemStat);


            //Gesture of the Drowned
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Cooldown Reduction: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(Utils.GetExponentialStacking(0.5f, 0.15f, stackCount));
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.AutoCastEquipment.itemIndex, itemStat);


            //Hooks of Heresy
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Root Duration: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Seconds);
            itemStat.descriptions.Add("Recharge Time: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Seconds);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(3 * stackCount);
                values.Add(5 * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.LunarSecondaryReplacement.itemIndex, itemStat);


            //Light Flux Pauldron
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Cooldown Reduction: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.descriptions.Add("Attack Speed Multiplier: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Damage);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(Utils.GetExponentialStacking(0.5f, 0.5f, stackCount));
                values.Add(1 / (1 + stackCount));
                return values;
            };
            allItemDefinitions.Add((int)DLC1Content.Items.HalfAttackSpeedHalfCooldowns.itemIndex, itemStat);


            //Mercurial Rachis
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Ward Radius: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Meters);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(16 * Mathf.Pow(1.5f, stackCount - 1));
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.RandomDamageZone.itemIndex, itemStat);


            //Purity
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Cooldown Reduction: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Seconds);
            itemStat.descriptions.Add("Luck: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Death);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Number);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(stackCount + 1);
                values.Add(-stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.LunarBadLuck.itemIndex, itemStat);


            //Shaped Glass
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Damage Multiplier: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Damage);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.descriptions.Add("Health Multiplier: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Health);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(Mathf.Pow(2f, stackCount));
                values.Add(Mathf.Pow(0.5f, stackCount));
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.LunarDagger.itemIndex, itemStat);


            //Stone Flux Pauldron
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Health Bonus: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Healing);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.PercentHealth);
            itemStat.descriptions.Add("MSpeed Multiplier: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(stackCount);
                values.Add(1 / (1 + stackCount));
                return values;
            };
            allItemDefinitions.Add((int)DLC1Content.Items.HalfSpeedDoubleHealth.itemIndex, itemStat);


            //Strides of Heresy
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Healing: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Healing);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.PercentHealth);
            itemStat.descriptions.Add("Skill Duration: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Seconds);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(0.182f * stackCount);
                values.Add(3 * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.LunarUtilityReplacement.itemIndex, itemStat);


            //Transcendence
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Health Bonus: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Health);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(0.25f + 0.25f * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.ShieldOnly.itemIndex, itemStat);


            //Visions of Heresy
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Skill Charges: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Number);
            itemStat.descriptions.Add("Recharge Time: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Seconds);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(12 * stackCount);
                values.Add(2 * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)RoR2Content.Items.LunarPrimaryReplacement.itemIndex, itemStat);


            // ---------- Void Items --------------------------------------------------------------------------------

            //Benthic Bloom
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Items Upgraded: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Number);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(3 * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)DLC1Content.Items.CloverVoid.itemIndex, itemStat);


            ////Encrusted Key
            //itemStat = new ItemStatsDef();
            //itemStat.descriptions.Add("Charges: ");
            //itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            //itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Number);
            //itemStat.calculateValues = (luck, stackCount, procChance) =>
            //{
            //    return new List<float>([stackCount]);
            //};
            //allItemDefinitions.Add((int)DLC1Content.Items.TreasureCacheVoid.itemIndex, itemStat);


            //Lost Seer's Lenses
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Instakill Chance: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Damage);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.hasChance = true;
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(Utils.CalculateChanceWithLuck(0.005f * stackCount * procChance, luck));
                return values;
            };
            allItemDefinitions.Add((int)DLC1Content.Items.CritGlassesVoid.itemIndex, itemStat);


            //Lysate Cell
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Skill Charges: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Number);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(stackCount);
                return values;
            };
            allItemDefinitions.Add((int)DLC1Content.Items.EquipmentMagazineVoid.itemIndex, itemStat);


            //Needletick
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Collapse Chance: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Damage);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.hasChance = true;
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(Utils.CalculateChanceWithLuck(0.1f * stackCount * procChance, luck));
                return values;
            };
            allItemDefinitions.Add((int)DLC1Content.Items.BleedOnHitVoid.itemIndex, itemStat);


            //Newly Hatched Zoea
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Max Allies: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Number);
            itemStat.descriptions.Add("Recharge Time: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Seconds);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(stackCount);
                values.Add(60f / stackCount);
                return values; 
            };
            allItemDefinitions.Add((int)DLC1Content.Items.VoidMegaCrabItem.itemIndex, itemStat);


            //Plasma Shrimp
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Total Damage: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Damage);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(0.4f * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)DLC1Content.Items.MissileVoid.itemIndex, itemStat);


            //Pluripotent Larva
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Revives: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Number);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(stackCount);
                return values;
            };
            allItemDefinitions.Add((int)DLC1Content.Items.ExtraLifeVoid.itemIndex, itemStat);


            //Polylute
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Proc Chance: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.descriptions.Add("Total Hits: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Damage);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Number);
            itemStat.hasChance = true;
            itemStat.chanceScaling = ItemStatsDef.ChanceScaling.DoesNotScale;
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(Utils.CalculateChanceWithLuck(0.25f * procChance, luck));
                values.Add(3 * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)DLC1Content.Items.ChainLightningVoid.itemIndex, itemStat);


            //Safer Spaces
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Recharge Time: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Seconds);
            itemStat.chanceScaling = ItemStatsDef.ChanceScaling.Hyperbolic;
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(Utils.GetExponentialRechargeTime(15, 0.1f, stackCount + 1)); //Kinda bizzare, but safer spaces specifically calculates it's time with 1 extra stack. Compared to StealthKit/Headstompers which calculate accurately
                return values;
            };
            allItemDefinitions.Add((int)DLC1Content.Items.BearVoid.itemIndex, itemStat);


            //Singularity Band
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Total Damage: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Damage);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(stackCount);
                return values;
            };
            allItemDefinitions.Add((int)DLC1Content.Items.ElementalRingVoid.itemIndex, itemStat);


            //Tentabauble
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Root Chance: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.descriptions.Add("Root Duration: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Utility);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Seconds);
            itemStat.hasChance = true;
            itemStat.chanceScaling = ItemStatsDef.ChanceScaling.Hyperbolic;
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(Utils.CalculateChanceWithLuck(0.05f * stackCount * procChance, luck));
                values.Add(stackCount);
                return values;
            };
            allItemDefinitions.Add((int)DLC1Content.Items.SlowOnHitVoid.itemIndex, itemStat);


            //Voidsent Flame
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Radius: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Damage);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Meters);
            itemStat.descriptions.Add("Pillar Damage: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Damage);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.Percentage);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(9.6f + (2.4f * stackCount));
                values.Add(1.04f + (1.56f * stackCount));
                return values;
            };
            allItemDefinitions.Add((int)DLC1Content.Items.ExplodeOnDeathVoid.itemIndex, itemStat);


            //Weeping Fungus
            itemStat = new ItemStatsDef();
            itemStat.descriptions.Add("Sprint Healing: ");
            itemStat.valueTypes.Add(ItemStatsDef.ValueType.Healing);
            itemStat.measurementUnits.Add(ItemStatsDef.MeasurementUnits.PercentHealing);
            itemStat.calculateValuesNew = (luck, stackCount, procChance) =>
            {
                List<float> values = new();
                values.Add(0.02f * stackCount);
                return values;
            };
            allItemDefinitions.Add((int)DLC1Content.Items.MushroomVoid.itemIndex, itemStat);
        }
    }
}
