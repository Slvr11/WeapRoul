using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using InfinityScript;

namespace RollTheDice
{
    public class RollTheDice : BaseScript
    {
        public const int NumOfRolls = 40;
        public List<string> PlayerStop = new List<string>();
        public int tickcount = 0;
        public RollTheDice()
        {
            PlayerConnected += RollTheDice_PlayerConnected;
            GSCFunctions.SetDvar("g_deadchat", 1);
            GSCFunctions.SetDvar("painVisionTriggerHealth", 0);
            Tick += RollTheDice_Tick;
        }

        void RollTheDice_Tick()
        {
            tickcount++;
            if (tickcount % 10 == 0)
            {
                tickcount = 0;
            }
        }

        void RollTheDice_PlayerConnected(Entity obj)
        {
            obj.SpawnedPlayer += () => OnPlayerSpawned(obj);
            obj.OnNotify("disconnect", entity => PlayerStop.Add(obj.Name));
        }

        public override void OnPlayerKilled(Entity player, Entity inflictor, Entity attacker, int damage, string mod, string weapon, Vector3 dir, string hitLoc)
        {
            PlayerStop.Add(player.Name);
        }

        public override void OnPlayerDamage(Entity player, Entity inflictor, Entity attacker, int damage, int dFlags, string mod, string weapon, Vector3 point, Vector3 dir, string hitLoc)
        {
        }

        public void OnPlayerSpawned(Entity player)
        {
            if (PlayerStop.Contains(player.Name))
                PlayerStop.Remove(player.Name);
            ResetPlayer(player);
            player.TakeAllWeapons();
            //player.Call(@"maps\mp\gametypes\_class::setKillstreaks", "none", "none", "none");
            DoRandom(player, null);
        }

        public void DoRandom(Entity player, int? desiredNumber)
        {
            int? roll = new Random().Next(40);
            var rollname = "";
            switch (roll)
            {
                case 0:
                    rollname = "Dragunov";
                    player.TakeAllWeapons();
                    player.SetPerk("specialty_scavenger", true, true);
                    player.SetPerk("specialty_quickdraw", true, true);
                    player.SetPerk("specialty_stalker", true, true);
                    player.GiveWeapon("iw5_dragunov_mp_dragunovscope");
                    AfterDelay(100, () =>
                    player.SwitchToWeaponImmediate("iw5_dragunov_mp_dragunovscope"));
                    player.DisableWeaponPickup();
                    break;
                case 1:
                    rollname = "AS50";
                    player.TakeAllWeapons();
                    player.SetPerk("specialty_scavenger", true, true);
                    player.SetPerk("specialty_quickdraw", true, true);
                    player.SetPerk("specialty_stalker", true, true);
                    player.GiveWeapon("iw5_as50_mp_as50scope");
                    AfterDelay(100, () =>
                    player.SwitchToWeaponImmediate("iw5_as50_mp_as50scope"));
                    player.DisableWeaponPickup();
                    break;
                case 2:
                    rollname = "L118A";
                    player.TakeAllWeapons();
                    player.SetPerk("specialty_scavenger", true, true);
                    player.SetPerk("specialty_quickdraw", true, true);
                    player.SetPerk("specialty_stalker", true, true);
                    player.GiveWeapon("iw5_l96a1_mp_l96a1scope");
                    AfterDelay(100, () =>
                    player.SwitchToWeaponImmediate("iw5_l96a1_mp_l96a1scope"));
                    player.DisableWeaponPickup();
                    break;
                case 3:
                    rollname = "MW2 M16 Grenade Launcher";
                    player.TakeAllWeapons();
                    player.SetPerk("specialty_scavenger", true, true);
                    player.SetPerk("specialty_quickdraw", true, true);
                    player.SetPerk("specialty_stalker", true, true);
                    player.GiveWeapon("gl_mp");
                    AfterDelay(100, () =>
                    player.SwitchToWeaponImmediate("gl_mp"));
                    player.DisableWeaponPickup();
                    break;
                case 4:
                    rollname = "RPG";
                    player.TakeAllWeapons();
                    player.SetPerk("specialty_scavenger", true, true);
                    player.SetPerk("specialty_quickdraw", true, true);
                    player.SetPerk("specialty_stalker", true, true);
                    player.GiveWeapon("rpg_mp");
                    AfterDelay(100, () =>
                    player.SwitchToWeaponImmediate("rpg_mp"));
                    player.DisableWeaponPickup();
                    break;
                case 5:
                    rollname = "AUG HBAR";
                    player.TakeAllWeapons();
                    player.SetPerk("specialty_scavenger", true, true);
                    player.SetPerk("specialty_quickdraw", true, true);
                    player.SetPerk("specialty_stalker", true, true);
                    player.GiveWeapon("iw5_m60jugg_mp_eotech_camo07");
                    AfterDelay(100, () =>
                    player.SwitchToWeaponImmediate("iw5_m60jugg_mp_eotech_camo07"));
                    player.DisableWeaponPickup();
                    break;
                case 6:
                    rollname = "ACR 6.8";
                    player.TakeAllWeapons();
                    player.SetPerk("specialty_scavenger", true, true);
                    player.SetPerk("specialty_quickdraw", true, true);
                    player.SetPerk("specialty_stalker", true, true);
                    player.GiveWeapon("iw5_acr_mp");
                    AfterDelay(100, () =>
                    player.SwitchToWeaponImmediate("iw5_acr_mp"));
                    player.DisableWeaponPickup();
                    break;
                case 7:
                    rollname = "Type 95";
                    player.TakeAllWeapons();
                    player.SetPerk("specialty_scavenger", true, true);
                    player.SetPerk("specialty_quickdraw", true, true);
                    player.SetPerk("specialty_stalker", true, true);
                    player.GiveWeapon("iw5_type95_mp");
                    AfterDelay(100, () =>
                    player.SwitchToWeaponImmediate("iw5_type95_mp"));
                    player.DisableWeaponPickup();
                    break;
                case 8:
                    rollname = "M4A1";
                    player.TakeAllWeapons();
                    player.SetPerk("specialty_scavenger", true, true);
                    player.SetPerk("specialty_quickdraw", true, true);
                    player.SetPerk("specialty_stalker", true, true);
                    player.GiveWeapon("iw5_m4_mp");
                    AfterDelay(100, () =>
                    player.SwitchToWeaponImmediate("iw5_m4_mp"));
                    player.DisableWeaponPickup();
                    break;
                case 9:
                    rollname = "AK-47";
                    player.TakeAllWeapons();
                    player.SetPerk("specialty_scavenger", true, true);
                    player.SetPerk("specialty_quickdraw", true, true);
                    player.SetPerk("specialty_stalker", true, true);
                    player.GiveWeapon("iw5_ak47_mp");
                    AfterDelay(100, () =>
                    player.SwitchToWeaponImmediate("iw5_ak47_mp"));
                    player.DisableWeaponPickup();
                    break;
                case 10:
                    rollname = "M16A4";
                    player.TakeAllWeapons();
                    player.SetPerk("specialty_scavenger", true, true);
                    player.SetPerk("specialty_quickdraw", true, true);
                    player.SetPerk("specialty_stalker", true, true);
                    player.GiveWeapon("iw5_m16_mp");
                    AfterDelay(100, () =>
                    player.SwitchToWeaponImmediate("iw5_m16_mp"));
                    player.DisableWeaponPickup();
                    break;
                case 11:
                    rollname = "MK14";
                    player.TakeAllWeapons();
                    player.SetPerk("specialty_scavenger", true, true);
                    player.SetPerk("specialty_quickdraw", true, true);
                    player.SetPerk("specialty_stalker", true, true);
                    player.GiveWeapon("iw5_mk14_mp");
                    AfterDelay(100, () =>
                    player.SwitchToWeaponImmediate("iw5_mk14_mp"));
                    player.DisableWeaponPickup();
                    break;
                case 12:
                    rollname = "G36C";
                    player.TakeAllWeapons();
                    player.SetPerk("specialty_scavenger", true, true);
                    player.SetPerk("specialty_quickdraw", true, true);
                    player.SetPerk("specialty_stalker", true, true);
                    player.GiveWeapon("iw5_g36c_mp");
                    AfterDelay(100, () =>
                    player.SwitchToWeaponImmediate("iw5_g36c_mp"));
                    player.DisableWeaponPickup();
                    break;
                case 13:
                    rollname = "SCAR-L";
                    player.TakeAllWeapons();
                    player.SetPerk("specialty_scavenger", true, true);
                    player.SetPerk("specialty_quickdraw", true, true);
                    player.SetPerk("specialty_stalker", true, true);
                    player.GiveWeapon("iw5_scar_mp");
                    AfterDelay(100, () =>
                    player.SwitchToWeaponImmediate("iw5_scar_mp"));
                    player.DisableWeaponPickup();
                    break;
                case 14:
                    rollname = "FAD";
                    player.TakeAllWeapons();
                    player.SetPerk("specialty_scavenger", true, true);
                    player.SetPerk("specialty_quickdraw", true, true);
                    player.SetPerk("specialty_stalker", true, true);
                    player.GiveWeapon("iw5_fad_mp");
                    AfterDelay(100, () =>
                    player.SwitchToWeaponImmediate("iw5_fad_mp"));
                    player.DisableWeaponPickup();
                    break;
                case 15:
                    rollname = "CM901";
                    player.TakeAllWeapons();
                    player.SetPerk("specialty_scavenger", true, true);
                    player.SetPerk("specialty_quickdraw", true, true);
                    player.SetPerk("specialty_stalker", true, true);
                    player.GiveWeapon("iw5_cm901_mp");
                    AfterDelay(100, () =>
                    player.SwitchToWeaponImmediate("iw5_cm901_mp"));
                    player.DisableWeaponPickup();
                    break;
                case 16:
                    rollname = "MP5";
                    player.TakeAllWeapons();
                    player.SetPerk("specialty_scavenger", true, true);
                    player.SetPerk("specialty_quickdraw", true, true);
                    player.SetPerk("specialty_stalker", true, true);
                    player.GiveWeapon("iw5_mp5_mp");
                    AfterDelay(100, () =>
                    player.SwitchToWeaponImmediate("iw5_mp5_mp"));
                    player.DisableWeaponPickup();
                    break;
                case 17:
                    rollname = "PM-9";
                    player.TakeAllWeapons();
                    player.SetPerk("specialty_scavenger", true, true);
                    player.SetPerk("specialty_quickdraw", true, true);
                    player.SetPerk("specialty_stalker", true, true);
                    player.GiveWeapon("iw5_m9_mp");
                    AfterDelay(100, () =>
                    player.SwitchToWeaponImmediate("iw5_m9_mp"));
                    player.DisableWeaponPickup();
                    break;
                case 18:
                    rollname = "P90";
                    player.TakeAllWeapons();
                    player.SetPerk("specialty_scavenger", true, true);
                    player.SetPerk("specialty_quickdraw", true, true);
                    player.SetPerk("specialty_stalker", true, true);
                    player.GiveWeapon("iw5_p90_mp");
                    AfterDelay(100, () =>
                    player.SwitchToWeaponImmediate("iw5_p90_mp"));
                    player.DisableWeaponPickup();
                    break;
                case 19:
                    rollname = "PP90M1";
                    player.TakeAllWeapons();
                    player.SetPerk("specialty_scavenger", true, true);
                    player.SetPerk("specialty_quickdraw", true, true);
                    player.SetPerk("specialty_stalker", true, true);
                    player.GiveWeapon("iw5_pp90m1_mp");
                    AfterDelay(100, () =>
                    player.SwitchToWeaponImmediate("iw5_pp90m1_mp"));
                    player.DisableWeaponPickup();
                    break;
                case 20:
                    rollname = "UMP45";
                    player.TakeAllWeapons();
                    player.SetPerk("specialty_scavenger", true, true);
                    player.SetPerk("specialty_quickdraw", true, true);
                    player.SetPerk("specialty_stalker", true, true);
                    player.GiveWeapon("iw5_ump45_mp");
                    AfterDelay(100, () =>
                    player.SwitchToWeaponImmediate("iw5_ump45_mp"));
                    player.DisableWeaponPickup();
                    break;
                case 21:
                    rollname = "MP7";
                    player.TakeAllWeapons();
                    player.SetPerk("specialty_scavenger", true, true);
                    player.SetPerk("specialty_quickdraw", true, true);
                    player.SetPerk("specialty_stalker", true, true);
                    player.GiveWeapon("iw5_mp7_mp");
                    AfterDelay(100, () =>
                    player.SwitchToWeaponImmediate("iw5_mp7_mp"));
                    player.DisableWeaponPickup();
                    break;
                case 22:
                    rollname = "FMG9";
                    player.TakeAllWeapons();
                    player.SetPerk("specialty_scavenger", true, true);
                    player.SetPerk("specialty_quickdraw", true, true);
                    player.SetPerk("specialty_stalker", true, true);
                    player.GiveWeapon("iw5_fmg9_mp");
                    AfterDelay(100, () =>
                    player.SwitchToWeaponImmediate("iw5_fmg9_mp"));
                    player.DisableWeaponPickup();
                    break;
                case 23:
                    rollname = "G18";
                    player.TakeAllWeapons();
                    player.SetPerk("specialty_scavenger", true, true);
                    player.SetPerk("specialty_quickdraw", true, true);
                    player.SetPerk("specialty_stalker", true, true);
                    player.GiveWeapon("iw5_g18_mp");
                    AfterDelay(100, () =>
                    player.SwitchToWeaponImmediate("iw5_g18_mp"));
                    player.DisableWeaponPickup();
                    break;
                case 24:
                    rollname = "MP9";
                    player.TakeAllWeapons();
                    player.SetPerk("specialty_scavenger", true, true);
                    player.SetPerk("specialty_quickdraw", true, true);
                    player.SetPerk("specialty_stalker", true, true);
                    player.GiveWeapon("iw5_mp9_mp");
                    AfterDelay(100, () =>
                    player.SwitchToWeaponImmediate("iw5_mp9_mp"));
                    player.DisableWeaponPickup();
                    break;
                case 25:
                    rollname = "Skorpion";
                    player.TakeAllWeapons();
                    player.SetPerk("specialty_scavenger", true, true);
                    player.SetPerk("specialty_quickdraw", true, true);
                    player.SetPerk("specialty_stalker", true, true);
                    player.GiveWeapon("iw5_skorpion_mp");
                    AfterDelay(100, () =>
                    player.SwitchToWeaponImmediate("iw5_skorpion_mp"));
                    player.DisableWeaponPickup();
                    break;
                case 26:
                    rollname = "SPAS-12";
                    player.TakeAllWeapons();
                    player.SetPerk("specialty_scavenger", true, true);
                    player.SetPerk("specialty_quickdraw", true, true);
                    player.SetPerk("specialty_stalker", true, true);
                    player.GiveWeapon("iw5_spas12_mp");
                    AfterDelay(100, () =>
                    player.SwitchToWeaponImmediate("iw5_spas12_mp"));
                    player.DisableWeaponPickup();
                    break;
                case 27:
                    rollname = "AA-12";
                    player.TakeAllWeapons();
                    player.SetPerk("specialty_scavenger", true, true);
                    player.SetPerk("specialty_quickdraw", true, true);
                    player.SetPerk("specialty_stalker", true, true);
                    player.GiveWeapon("iw5_aa12_mp");
                    AfterDelay(100, () =>
                    player.SwitchToWeaponImmediate("iw5_aa12_mp"));
                    player.DisableWeaponPickup();
                    break;
                case 28:
                    rollname = "Striker";
                    player.TakeAllWeapons();
                    player.SetPerk("specialty_scavenger", true, true);
                    player.SetPerk("specialty_quickdraw", true, true);
                    player.SetPerk("specialty_stalker", true, true);
                    player.GiveWeapon("iw5_striker_mp");
                    AfterDelay(100, () =>
                    player.SwitchToWeaponImmediate("iw5_striker_mp"));
                    player.DisableWeaponPickup();
                    break;
                case 29:
                    rollname = "Model 1887";
                    player.TakeAllWeapons();
                    player.SetPerk("specialty_scavenger", true, true);
                    player.SetPerk("specialty_quickdraw", true, true);
                    player.SetPerk("specialty_stalker", true, true);
                    player.GiveWeapon("iw5_1887_mp");
                    AfterDelay(100, () =>
                    player.SwitchToWeaponImmediate("iw5_1887_mp"));
                    player.DisableWeaponPickup();
                    break;
                case 30:
                    rollname = "USAS12";
                    player.TakeAllWeapons();
                    player.SetPerk("specialty_scavenger", true, true);
                    player.SetPerk("specialty_quickdraw", true, true);
                    player.SetPerk("specialty_stalker", true, true);
                    player.GiveWeapon("iw5_usas12_mp");
                    AfterDelay(100, () =>
                    player.SwitchToWeaponImmediate("iw5_usas12_mp"));
                    player.DisableWeaponPickup();
                    break;
                case 31:
                    rollname = "KSG";
                    player.TakeAllWeapons();
                    player.SetPerk("specialty_scavenger", true, true);
                    player.SetPerk("specialty_quickdraw", true, true);
                    player.SetPerk("specialty_stalker", true, true);
                    player.GiveWeapon("iw5_ksg_mp");
                    AfterDelay(100, () =>
                    player.SwitchToWeaponImmediate("iw5_ksg_mp"));
                    player.DisableWeaponPickup();
                    break;
                case 32:
                    rollname = "M60E4";
                    player.TakeAllWeapons();
                    player.SetPerk("specialty_scavenger", true, true);
                    player.SetPerk("specialty_quickdraw", true, true);
                    player.SetPerk("specialty_stalker", true, true);
                    player.GiveWeapon("iw5_m60_mp");
                    AfterDelay(100, () =>
                    player.SwitchToWeaponImmediate("iw5_m60_mp"));
                    player.DisableWeaponPickup();
                    break;
                case 33:
                    rollname = "MK46";
                    player.TakeAllWeapons();
                    player.SetPerk("specialty_scavenger", true, true);
                    player.SetPerk("specialty_quickdraw", true, true);
                    player.SetPerk("specialty_stalker", true, true);
                    player.GiveWeapon("iw5_mk46_mp");
                    AfterDelay(100, () =>
                    player.SwitchToWeaponImmediate("iw5_mk46_mp"));
                    player.DisableWeaponPickup();
                    break;
                case 34:
                    rollname = "PKP Pecheneg";
                    player.TakeAllWeapons();
                    player.SetPerk("specialty_scavenger", true, true);
                    player.SetPerk("specialty_quickdraw", true, true);
                    player.SetPerk("specialty_stalker", true, true);
                    player.GiveWeapon("iw5_pecheneg_mp");
                    AfterDelay(100, () =>
                    player.SwitchToWeaponImmediate("iw5_pecheneg_mp"));
                    player.DisableWeaponPickup();
                    break;
                case 35:
                    rollname = "L86 LSW";
                    player.TakeAllWeapons();
                    player.SetPerk("specialty_scavenger", true, true);
                    player.SetPerk("specialty_quickdraw", true, true);
                    player.SetPerk("specialty_stalker", true, true);
                    player.GiveWeapon("iw5_sa80_mp");
                    AfterDelay(100, () =>
                    player.SwitchToWeaponImmediate("iw5_sa80_mp"));
                    player.DisableWeaponPickup();
                    break;
                case 36:
                    rollname = "MG36";
                    player.TakeAllWeapons();
                    player.SetPerk("specialty_scavenger", true, true);
                    player.SetPerk("specialty_quickdraw", true, true);
                    player.SetPerk("specialty_stalker", true, true);
                    player.GiveWeapon("iw5_mg36_mp");
                    AfterDelay(100, () =>
                    player.SwitchToWeaponImmediate("iw5_mg36_mp"));
                    player.DisableWeaponPickup();
                    break;
                case 37:
                    rollname = "Barrett 50. Cal";
                    player.TakeAllWeapons();
                    player.SetPerk("specialty_scavenger", true, true);
                    player.SetPerk("specialty_quickdraw", true, true);
                    player.SetPerk("specialty_stalker", true, true);
                    player.GiveWeapon("iw5_barrett_mp_barrettscope");
                    AfterDelay(100, () =>
                    player.SwitchToWeaponImmediate("iw5_barrett_mp_barrettscope"));
                    player.DisableWeaponPickup();
                    break;
                case 38:
                    rollname = "MSR";
                    player.TakeAllWeapons();
                    player.SetPerk("specialty_scavenger", true, true);
                    player.SetPerk("specialty_quickdraw", true, true);
                    player.SetPerk("specialty_stalker", true, true);
                    player.GiveWeapon("iw5_msr_mp_msrscope");
                    AfterDelay(100, () =>
                    player.SwitchToWeaponImmediate("iw5_msr_mp_msrscope"));
                    player.DisableWeaponPickup();
                    break;
                case 39:
                    rollname = "RSASS";
                    player.TakeAllWeapons();
                    player.SetPerk("specialty_scavenger", true, true);
                    player.SetPerk("specialty_quickdraw", true, true);
                    player.SetPerk("specialty_stalker", true, true);
                    player.GiveWeapon("iw5_rsass_mp_rsassscope");
                    AfterDelay(100, () =>
                    player.SwitchToWeaponImmediate("iw5_rsass_mp_rsassscope"));
                    player.DisableWeaponPickup();
                    break;
            }
            PrintRollNames(player, rollname, 0, roll);
        }

        public void PrintRollNames(Entity player, string name, int index, int? roll)
        {
            HudElem elem = player.HasField("rtd_rolls") ? player.GetField<HudElem>("rtd_rolls") : HudElem.CreateFontString(player, HudElem.Fonts.HudBig, 1f);
            elem.SetPoint("RIGHT", "RIGHT", -90, 165 - ((index - 1) * 13));
            elem.SetText(string.Format("You Have The {1}", roll + 1, name));
            player.SetField("rtd_rolls", new Parameter(elem));
            player.IPrintLnBold(string.Format("You Got The {1}", roll + 1, name));
            GSCFunctions.IPrintLn(string.Format("{0} got the {2}", player.Name, roll + 1, name));
        }

        public void ResetPlayer(Entity player)
        {
            player.SetMoveSpeedScale(1f);
        }
    }
}