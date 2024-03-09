using TagTool.Cache;
using TagTool.Cache.HaloOnline;
using TagTool.Common;
using TagTool.Tags.Definitions;
using System.IO;

namespace TagTool.MtnDewIt.Commands.GenerateCache.Tags 
{
    public class ui_hud_hud_messages_multilingual_unicode_string_list : TagFile
    {
        public ui_hud_hud_messages_multilingual_unicode_string_list(GameCache cache, GameCacheHaloOnline cacheContext, Stream stream) : base
        (
            cache,
            cacheContext,
            stream
        )
        {
            Cache = cache;
            CacheContext = cacheContext;
            Stream = stream;
            TagData();
        }

        public override void TagData()
        {
            var tag = GetCachedTag<MultilingualUnicodeStringList>($@"ui\hud\hud_messages");
            var unic = CacheContext.Deserialize<MultilingualUnicodeStringList>(Stream, tag);
            //AddString(unic, "ar_acc_picked_up", "Picked up an Assault Rifle with Accuracy mods");
            //AddString(unic, "ar_acc_pickup", @"Hold \UE445 to pickup \r\UE139");
            //AddString(unic, "ar_acc_swap", @"Hold \UE445 to swap for \r\UE139");
            //AddString(unic, "ar_acc_swap_ai", @"Hold \UE445 to take ally's \r\UE139");
            //AddString(unic, "ar_acc_switch_to", @"Out of ammo \rPress \UE446 to switch to \UE139");
            //AddString(unic, "ar_dmg_picked_up", "Picked up an Assault Rifle with Damage mods");
            //AddString(unic, "ar_dmg_pickup", @"Hold \UE445 to pickup \r\UE13a");
            //AddString(unic, "ar_dmg_swap", @"Hold \UE445 to swap for \r\UE13a");
            //AddString(unic, "ar_dmg_swap_ai", @"Hold \UE445 to take ally's \r\UE13a");
            //AddString(unic, "ar_dmg_switch_to", @"Out of ammo \rPress \UE446 to switch to \UE13a");
            //AddString(unic, "ar_pwr_picked_up", "Picked up an Assault Rifle with Power mods");
            //AddString(unic, "ar_pwr_pickup", @"Hold \UE445 to pickup \r\UE13b");
            //AddString(unic, "ar_pwr_swap", @"Hold \UE445 to swap for \r\UE13b");
            //AddString(unic, "ar_pwr_swap_ai", @"Hold \UE445 to take ally's \r\UE13b");
            //AddString(unic, "ar_pwr_switch_to", @"Out of ammo \rPress \UE446 to switch to \UE13b");
            //AddString(unic, "ar_rof_picked_up", "Picked up an Assault Rifle with Rate of Fire mods");
            //AddString(unic, "ar_rof_pickup", @"Hold \UE445 to pickup \r\UE13c");
            //AddString(unic, "ar_rof_swap", @"Hold \UE445 to swap for \r\UE13c");
            //AddString(unic, "ar_rof_swap_ai", @"Hold \UE445 to take ally's \r\UE13c");
            //AddString(unic, "ar_rof_switch_to", @"Out of ammo \rPress \UE446 to switch to \UE13c");
            AddString(unic, "black_eye", "BLACK EYE");
            //AddString(unic, "bombrun_picked_up", "Picked up Bomb Run");
            //AddString(unic, "bombrun_swap", @"\UE461 \UE445 to swap for Bomb Run");
            AddString(unic, "bonus_text", "Bonus Round: Lives awarded at 10,000");
            //AddString(unic, "br_acc_picked_up", "Picked up a Battle Rifle with Accuracy mods");
            //AddString(unic, "br_acc_pickup", @"Hold \UE445 to pickup \r\UE13d");
            //AddString(unic, "br_acc_swap", @"Hold \UE445 to swap for \r\UE13d");
            //AddString(unic, "br_acc_swap_ai", @"Hold \UE445 to take ally's \r\UE13d");
            //AddString(unic, "br_acc_switch_to", @"Out of ammo \rPress \UE446 to switch to \UE13d");
            //AddString(unic, "br_dmg_picked_up", "Picked up a Battle Rifle with Damage mods");
            //AddString(unic, "br_dmg_pickup", @"Hold \UE445 to pickup \r\UE13e");
            //AddString(unic, "br_dmg_swap", @"Hold \UE445 to swap for \r\UE13e");
            //AddString(unic, "br_dmg_swap_ai", @"Hold \UE445 to take ally's \r\UE13e");
            //AddString(unic, "br_dmg_switch_to", @"Out of ammo \rPress \UE446 to switch to \UE13e");
            //AddString(unic, "br_mag_picked_up", "Picked up a Battle Rifle with Ammo mods");
            //AddString(unic, "br_mag_pickup", @"Hold \UE445 to pickup \r\UE13f");
            //AddString(unic, "br_mag_swap", @"Hold \UE445 to swap for \r\UE13f");
            //AddString(unic, "br_mag_swap_ai", @"Hold \UE445 to take ally's \r\UE13f");
            //AddString(unic, "br_mag_switch_to", @"Out of ammo \rPress \UE446 to switch to \UE13f");
            //AddString(unic, "br_pwr_picked_up", "Picked up a Battle Rifle with Power mods");
            //AddString(unic, "br_pwr_pickup", @"Hold \UE445 to pickup \r\UE140");
            //AddString(unic, "br_pwr_swap", @"Hold \UE445 to swap for \r\UE140");
            //AddString(unic, "br_pwr_swap_ai", @"Hold \UE445 to take ally's \r\UE140");
            //AddString(unic, "br_pwr_switch_to", @"Out of ammo \rPress \UE446 to switch to \UE140");
            //AddString(unic, "br_rng_picked_up", "Picked up a Battle Rifle with Range mods");
            //AddString(unic, "br_rng_pickup", @"Hold \UE445 to pickup \r\UE141");
            //AddString(unic, "br_rng_swap", @"Hold \UE445 to swap for \r\UE141");
            //AddString(unic, "br_rng_swap_ai", @"Hold \UE445 to take ally's \r\UE141");
            //AddString(unic, "br_rng_switch_to", @"Out of ammo \rPress \UE446 to switch to \UE141");
            //AddString(unic, "br_rof_picked_up", "Picked up a Battle Rifle with Rate of Fire mods");
            //AddString(unic, "br_rof_pickup", @"Hold \UE445 to pickup \r\UE142");
            //AddString(unic, "br_rof_swap", @"Hold \UE445 to swap for \r\UE142");
            //AddString(unic, "br_rof_swap_ai", @"Hold \UE445 to take ally's \r\UE142");
            //AddString(unic, "br_rof_switch_to", @"Out of ammo \rPress \UE446 to switch to \UE142");
            AddString(unic, "buck", "BUCK");
            AddString(unic, "catch", "CATCH");
            //AddString(unic, "cc_acc_picked_up", "Picked up a Carbine with Accuracy mods");
            //AddString(unic, "cc_acc_pickup", @"Hold \UE445 to pickup \r\UE143");
            //AddString(unic, "cc_acc_swap", @"Hold \UE445 to swap for \r\UE143");
            //AddString(unic, "cc_acc_swap_ai", @"Hold \UE445 to take ally's \r\UE143");
            //AddString(unic, "cc_acc_switch_to", @"Out of ammo \rPress \UE446 to switch to \UE143");
            //AddString(unic, "cc_dmg_picked_up", "Picked up a Carbine with Damage mods");
            //AddString(unic, "cc_dmg_pickup", @"Hold \UE445 to pickup \r\UE144");
            //AddString(unic, "cc_dmg_swap", @"Hold \UE445 to swap for \r\UE144");
            //AddString(unic, "cc_dmg_swap_ai", @"Hold \UE445 to take ally's \r\UE144");
            //AddString(unic, "cc_dmg_switch_to", @"Out of ammo \rPress \UE446 to switch to \UE144");
            //AddString(unic, "cc_mag_picked_up", "Picked up a Carbine with Ammo mods");
            //AddString(unic, "cc_mag_pickup", @"Hold \UE445 to pickup \r\UE145");
            //AddString(unic, "cc_mag_swap", @"Hold \UE445 to swap for \r\UE145");
            //AddString(unic, "cc_mag_swap_ai", @"Hold \UE445 to take ally's \r\UE145");
            //AddString(unic, "cc_mag_switch_to", @"Out of ammo \rPress \UE446 to switch to \UE145");
            //AddString(unic, "cc_pwr_picked_up", "Picked up a Carbine with Power mods");
            //AddString(unic, "cc_pwr_pickup", @"Hold \UE445 to pickup \r\UE146");
            //AddString(unic, "cc_pwr_swap", @"Hold \UE445 to swap for \r\UE146");
            //AddString(unic, "cc_pwr_swap_ai", @"Hold \UE445 to take ally's \r\UE146");
            //AddString(unic, "cc_pwr_switch_to", @"Out of ammo \rPress \UE446 to switch to \UE146");
            //AddString(unic, "cc_rng_picked_up", "Picked up a Carbine with Range mods");
            //AddString(unic, "cc_rng_pickup", @"Hold \UE445 to pickup \r\UE147");
            //AddString(unic, "cc_rng_swap", @"Hold \UE445 to swap for \r\UE147");
            //AddString(unic, "cc_rng_swap_ai", @"Hold \UE445 to take ally's \r\UE147");
            //AddString(unic, "cc_rng_switch_to", @"Out of ammo \rPress \UE446 to switch to \UE147");
            //AddString(unic, "cc_rof_picked_up", "Picked up a Carbine with Rate of Fire mods");
            //AddString(unic, "cc_rof_pickup", @"Hold \UE445 to pickup \r\UE148");
            //AddString(unic, "cc_rof_swap", @"Hold \UE445 to swap for \r\UE148");
            //AddString(unic, "cc_rof_swap_ai", @"Hold \UE445 to take ally's \r\UE148");
            //AddString(unic, "cc_rof_switch_to", @"Out of ammo \rPress \UE446 to switch to \UE148");
            //AddString(unic, "concussiveblast_picked_up", "Picked up Concussive Blast");
            //AddString(unic, "concussiveblast_swap", @"\UE461 \UE445 to swap for Concussive Blast");
            //AddString(unic, "consumable_1", "consumable 1");
            //AddString(unic, "consumable_2", "consumable 2");
            //AddString(unic, "consumable_3", "consumable 3");
            //AddString(unic, "consumable_4", "consumable 4");
            AddString(unic, "dare", "DARE");
            AddString(unic, "device_arg", @"Tap \UE445 to download COMM data to VISR|nHold \UE445 to download and play immediately");
            AddString(unic, "dutch", "DUCH");
            AddString(unic, "engineer", "VRGL");
            //AddString(unic, "ex_pwr_dual", @"Hold \UE45e to dual-wield \r\UE159");
            //AddString(unic, "ex_pwr_dual_swap", @"Hold \UE45e to swap for \r\UE159");
            //AddString(unic, "ex_pwr_picked_up", "Picked up a Mauler with Power mods");
            //AddString(unic, "ex_pwr_pickup", @"Hold \UE445 to pickup \r\UE160");
            //AddString(unic, "ex_pwr_swap", @"Hold \UE445 to swap for \r\UE160");
            //AddString(unic, "ex_pwr_swap_ai", @"Hold \UE445 to take ally's \r\UE160");
            //AddString(unic, "ex_pwr_switch_to", @"Out of ammo \rPress \UE446 to switch to \UE160");
            AddString(unic, "famine", "FAMINE");
            AddString(unic, "gm_assault_bomb_defused", "BOMB HAS BEEN DEFUSED");
            AddString(unic, "gm_assault_bomb_dropped", "BOMB DROPPED");
            AddString(unic, "gm_assault_bomb_dropped_message", "BOMB IS DROPPED");
            AddString(unic, "gm_assault_bomb_exploded", "BOMB HAS EXPLODED");
            AddString(unic, "gm_assault_bomb_planted", "BOMB HAS BEEN PLANTED");
            AddString(unic, "gm_assault_overrun", "YOUR TEAM HAVE BEEN OVERRUN");
            AddString(unic, "gm_assault_overrun_enemy", "YOU HAVE OVERRUN THE ENEMY TEAM");
            AddString(unic, "gm_assault_player_defender_aim", "PROTECT THE ARMING POINTS");
            AddString(unic, "gm_assault_player_whithout_bomb", "PROTECT THE BOMB CARRIER");
            AddString(unic, "gm_assault_player_with_bomb", "PLANT THE BOMB AT ARMING POINT");
            AddString(unic, "gm_bomb_controlled", "BOMB");
            AddString(unic, "gm_bomb_planted", "BOMB PLANTED");
            AddString(unic, "gm_flag_dropped", "FLAG DROPPED");
            AddString(unic, "gm_flag_stolen", "FLAG STOLEN");
            AddString(unic, "gm_hill_controlled", "KING");
            AddString(unic, "gm_oddball_controlled", "ODDBALL");
            //AddString(unic, "hologram_picked_up", "Picked up Hologram");
            //AddString(unic, "hologram_swap", @"\UE461 \UE445 to swap for Hologram");
            //AddString(unic, "idx_1", "1");
            //AddString(unic, "idx_2", "2");
            //AddString(unic, "idx_3", "3");
            //AddString(unic, "idx_4", "4");
            //AddString(unic, "invisibility_vehicle_picked_up", "Picked up Vehicle Cloaking");
            //AddString(unic, "invisibility_vehicle_swap", @"\UE461 \UE445 to swap for Vehicle Cloaking");
            AddString(unic, "iron", "IRON");
            //AddString(unic, "lightningstrike_picked_up", "Picked up Lightning Strike");
            //AddString(unic, "lightningstrike_swap", @"\UE461 \UE445 to swap for Lightning Strike");
            AddString(unic, "message_downloaded", "Message downloaded to VISR");
            AddString(unic, "mickey", "MCKY");
            //AddString(unic, "mp_dmg_dual", @"Hold \UE45e to dual-wield \r\UE155");
            //AddString(unic, "mp_dmg_dual_swap", @"Hold \UE45e to swap for \r\UE155");
            //AddString(unic, "mp_dmg_picked_up", "Picked up a Magnum with Damage mods");
            //AddString(unic, "mp_dmg_pickup", @"Hold \UE445 to pickup \r\UE156");
            //AddString(unic, "mp_dmg_swap", @"Hold \UE445 to swap for \r\UE156");
            //AddString(unic, "mp_dmg_swap_ai", @"Hold \UE445 to take ally's \r\UE156");
            //AddString(unic, "mp_dmg_switch_to", "Out of ammo \rPress \UE446 to switch to \UE156");
            //AddString(unic, "mp_pwr_dual", @"Hold \UE45e to dual-wield \r\UE157");
            //AddString(unic, "mp_pwr_dual_swap", @"Hold \UE45e to swap for \r\UE157");
            //AddString(unic, "mp_pwr_picked_up", "Picked up a Magnum with Power mods");
            //AddString(unic, "mp_pwr_pickup", @"Hold \UE445 to pickup \r\UE158");
            //AddString(unic, "mp_pwr_swap", @"Hold \UE445 to swap for \r\UE158");
            //AddString(unic, "mp_pwr_swap_ai", @"Hold \UE445 to take ally's \r\UE158");
            //AddString(unic, "mp_pwr_switch_to", @"Out of ammo \rPress \UE446 to switch to \UE158");
            //AddString(unic, "mr_acc_picked_up", "Picked up a DMR with Accuracy mods");
            //AddString(unic, "mr_acc_pickup", @"Hold \UE445 to pickup \r\UE149");
            //AddString(unic, "mr_acc_swap", @"Hold \UE445 to swap for \r\UE149");
            //AddString(unic, "mr_acc_swap_ai", @"Hold \UE445 to take ally's \r\UE149");
            //AddString(unic, "mr_acc_switch_to", "Out of ammo \rPress \UE446 to switch to \UE149");
            //AddString(unic, "mr_ammo_plural", @"Picked up \UE425 rounds for DMR");
            //AddString(unic, "mr_ammo_singular", @"Picked up \UE425 round for DMR");
            //AddString(unic, "mr_dmg_picked_up", "Picked up a DMR with Damage mods");
            //AddString(unic, "mr_dmg_pickup", @"Hold \UE445 to pickup \r\UE150");
            //AddString(unic, "mr_dmg_swap", @"Hold \UE445 to swap for \r\UE150");
            //AddString(unic, "mr_dmg_swap_ai", @"Hold \UE445 to take ally's \r\UE150");
            //AddString(unic, "mr_dmg_switch_to", @"Out of ammo \rPress \UE446 to switch to \UE150");
            //AddString(unic, "mr_mag_picked_up", "Picked up a DMR with Ammo mods");
            //AddString(unic, "mr_mag_pickup", @"Hold \UE445 to pickup \r\UE151");
            //AddString(unic, "mr_mag_swap", @"Hold \UE445 to swap for \r\UE151");
            //AddString(unic, "mr_mag_swap_ai", @"Hold \UE445 to take ally's \r\UE151");
            //AddString(unic, "mr_mag_switch_to", @"Out of ammo \rPress \UE446 to switch to \UE151");
            //AddString(unic, "mr_picked_up", "Picked up a DMR");
            //AddString(unic, "mr_pickup", @"Hold \UE445 to pickup \r\UE170");
            //AddString(unic, "mr_pwr_picked_up", "Picked up a DMR with Power mods");
            //AddString(unic, "mr_pwr_pickup", @"Hold \UE445 to pickup \r\UE152");
            //AddString(unic, "mr_pwr_swap", @"Hold \UE445 to swap for \r\UE152");
            //AddString(unic, "mr_pwr_swap_ai", @"Hold \UE445 to take ally's \r\UE152");
            //AddString(unic, "mr_pwr_switch_to", @"Out of ammo \rPress \UE446 to switch to \UE152");
            //AddString(unic, "mr_rng_picked_up", "Picked up a RNG DMR");
            //AddString(unic, "mr_rng_pickup", @"Hold \UE445 to pickup \r\UE153");
            //AddString(unic, "mr_rng_swap", @"Hold \UE445 to swap for \r\UE153");
            //AddString(unic, "mr_rng_swap_ai", @"Hold \UE445 to take ally's \r\UE153");
            //AddString(unic, "mr_rng_switch_to", @"Out of ammo \rPress \UE446 to switch to \UE153");
            //AddString(unic, "mr_rof_picked_up", "Picked up a DMR with Rate of Fire mods");
            //AddString(unic, "mr_rof_pickup", @"Hold \UE445 to pickup \r\UE154");
            //AddString(unic, "mr_rof_swap", @"Hold \UE445 to swap for \r\UE154");
            //AddString(unic, "mr_rof_swap_ai", @"Hold \UE445 to take ally's \r\UE154");
            //AddString(unic, "mr_rof_switch_to", @"Out of ammo \rPress \UE446 to switch to \UE154");
            //AddString(unic, "mr_swap", @"Hold \UE445 to swap for \r\UE170");
            //AddString(unic, "mr_swap_ai", @"Hold \UE445 to take ally's \r\UE170");
            //AddString(unic, "mr_switch_to", @"Out of ammo \rPress \UE446 to switch to \UE170");
            AddString(unic, "mythic", "MYTHIC");
            AddString(unic, "pda_activate_all", @"Press \UE44c to open VISR database");
            AddString(unic, "pda_activate_comm", @"Press \UE44c to open VISR COMM data");
            AddString(unic, "pda_activate_intel", @"Press \UE44c to open VISR INTEL data");
            AddString(unic, "pda_activate_nav", @"Press \UE44c to open VISR NAV data");
            //AddString(unic, "pp_pwr_dual", @"Hold \UE45e to dual-wield \r\UE161");
            //AddString(unic, "pp_pwr_dual_swap", @"Hold \UE45e to swap for \r\UE161");
            //AddString(unic, "pp_pwr_picked_up", "Picked up a Plasma Pistol with Power mods");
            //AddString(unic, "pp_pwr_pickup", @"Hold \UE445 to pickup \r\UE162");
            //AddString(unic, "pp_pwr_swap", @"Hold \UE445 to swap for \r\UE162");
            //AddString(unic, "pp_pwr_swap_ai", @"Hold \UE445 to take ally's \r\UE162");
            //AddString(unic, "pp_pwr_switch_to", @"Out of ammo \rPress \UE446 to switch to \UE162");
            //AddString(unic, "pr_pwr_dual", @"Hold \UE45e to dual-wield \r\UE163");
            //AddString(unic, "pr_pwr_dual_swap", @"Hold \UE45e to swap for \r\UE163");
            //AddString(unic, "pr_pwr_picked_up", "Picked up a Plasma Rifle with Power mods");
            //AddString(unic, "pr_pwr_pickup", @"Hold \UE445 to pickup \r\UE164");
            //AddString(unic, "pr_pwr_swap", @"Hold \UE445 to swap for \r\UE164");
            //AddString(unic, "pr_pwr_swap_ai", @"Hold \UE445 to take ally's \r\UE164");
            //AddString(unic, "pr_pwr_switch_to", @"Out of ammo \rPress \UE446 to switch to \UE164");
            //AddString(unic, "prim_attr_accuracy", "ACCURACY");
            //AddString(unic, "prim_attr_ammo", "AMMO");
            //AddString(unic, "prim_attr_damage", "DAMAGE");
            //AddString(unic, "prim_attr_none", " ");
            //AddString(unic, "prim_attr_power", "POWER");
            //AddString(unic, "prim_attr_range", "RANGE");
            //AddString(unic, "prim_attr_rof", "RATE OF FIRE");
            //AddString(unic, "reactive_armor_picked_up", "Picked up Reflective Shield");
            //AddString(unic, "reactive_armor_swap", @"\UE461 \UE445 to swap for Reflective Shield");
            AddString(unic, "romeo", "ROME");
            AddString(unic, "skull_black_eye", "Melee to recharge your Stamina");
            AddString(unic, "skull_catch", "Enemies love to throw grenades");
            AddString(unic, "skull_famine", "Enemies drop low-ammo weapons");
            AddString(unic, "skull_iron", "Respawning is disabled. Be Careful!");
            AddString(unic, "skull_mythic", "Enemies have 2x health");
            AddString(unic, "skull_thunderstorm", "Enemies are upgraded");
            AddString(unic, "skull_tilt", "Enemy shields deflect bullets");
            AddString(unic, "skull_tough_luck", "Enemies always evade danger");
            AddString(unic, "slash", "/");
            //AddString(unic, "smg_acc_dual", @"Hold \UE45e to dual-wield \r\UE165");
            //AddString(unic, "smg_acc_dual_swap", @"Hold \UE45e to swap for \r\UE165");
            //AddString(unic, "smg_acc_picked_up", "Picked up an SMG with Accuracy mods");
            //AddString(unic, "smg_acc_pickup", @"Hold \UE445 to pickup \r\UE166");
            //AddString(unic, "smg_acc_swap", @"Hold \UE445 to swap for \r\UE166");
            //AddString(unic, "smg_acc_swap_ai", @"Hold \UE445 to take ally's \r\UE166");
            //AddString(unic, "smg_acc_switch_to", @"Out of ammo \rPress \UE446 to switch to \UE166");
            //AddString(unic, "smg_dmg_dual", @"Hold \UE45e to dual-wield \r\UE168");
            //AddString(unic, "smg_dmg_dual_swap", @"Hold \UE45e to swap for \r\UE168");
            //AddString(unic, "smg_dmg_picked_up", "Picked up an SMG with Damage mods");
            //AddString(unic, "smg_dmg_pickup", @"Hold \UE445 to pickup \r\UE169");
            //AddString(unic, "smg_dmg_swap", @"Hold \UE445 to swap for \r\UE169");
            //AddString(unic, "smg_dmg_swap_ai", @"Hold \UE445 to take ally's \r\UE169");
            //AddString(unic, "smg_dmg_switch_to", @"Out of ammo \rPress \UE446 to switch to \UE169");
            //AddString(unic, "smg_pwr_dual", @"Hold \UE45e to dual-wield \r\UE15a");
            //AddString(unic, "smg_pwr_dual_swap", @"Hold \UE45e to swap for \r\UE15a");
            //AddString(unic, "smg_pwr_picked_up", "Picked up an SMG with Power mods");
            //AddString(unic, "smg_pwr_pickup", @"Hold \UE445 to pickup \r\UE15b");
            //AddString(unic, "smg_pwr_swap", @"Hold \UE445 to swap for \r\UE15b");
            //AddString(unic, "smg_pwr_swap_ai", @"Hold \UE445 to take ally's \r\UE15b");
            //AddString(unic, "smg_pwr_switch_to", @"Out of ammo \rPress \UE446 to switch to \UE15b");
            //AddString(unic, "smg_rof_dual", @"Hold \UE45e to dual-wield \r\UE15c");
            //AddString(unic, "smg_rof_dual_swap", @"Hold \UE45e to swap for \r\UE15c");
            //AddString(unic, "smg_rof_picked_up", "Picked up an SMG with Rate of Fire mods");
            //AddString(unic, "smg_rof_pickup", @"Hold \UE445 to pickup \r\UE15d");
            //AddString(unic, "smg_rof_swap", @"Hold \UE445 to swap for \r\UE15d");
            //AddString(unic, "smg_rof_swap_ai", @"Hold \UE445 to take ally's \r\UE15d");
            //AddString(unic, "smg_rof_switch_to", @"Out of ammo \rPress \UE446 to switch to \UE15d");
            AddString(unic, "survival_bits", ">>>WAVE:\r\n>>ROUND:\r\n>SET:\r\nLIVES:");
            AddString(unic, "thunderstorm", "THUNDERSTORM");
            AddString(unic, "tilt", "TILT");
            AddString(unic, "tough_luck", "TOUGH LUCK");
            AddString(unic, "vision_picked_up", "Picked up V.I.S.R.");
            AddString(unic, "vision_swap", @"\UE461 \UE445 to swap for V.I.S.R.");
            AddString(unic, "visr_warning", "V.I.S.R. DETECTED");
            //AddString(unic, "wp_pickup", @"\UE461 \UE45f to pick up\r\n");
            CacheContext.Serialize(Stream, tag, unic);
        }
    }
}