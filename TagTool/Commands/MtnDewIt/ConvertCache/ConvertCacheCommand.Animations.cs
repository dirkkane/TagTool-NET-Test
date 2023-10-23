using TagTool.Commands.Common;
using TagTool.Tags.Definitions;
using System.Collections.Generic;
using System.Linq;
using TagTool.Cache;
using System.IO;

namespace TagTool.Commands.MtnDewIt
{
    partial class ConvertCacheCommand : Command
    {
        public void ImportAnimations() 
        {
            CommandRunner.Current.RunCommand($@"edittag objects\characters\masterchief\masterchief.model_animation_graph");
            CommandRunner.Current.RunCommand($"addanimation \"{Program.TagToolDirectory}\\Tools\\BaseCache\\Animations\\Spartan\\combat thunderclap.JMM\"");
            CommandRunner.Current.RunCommand($"addanimation \"{Program.TagToolDirectory}\\Tools\\BaseCache\\Animations\\Spartan\\any any dance1test.JMM\"");
            CommandRunner.Current.RunCommand($"addanimation \"{Program.TagToolDirectory}\\Tools\\BaseCache\\Animations\\Spartan\\any any dance1.JMM\"");
            CommandRunner.Current.RunCommand($"addanimation \"{Program.TagToolDirectory}\\Tools\\BaseCache\\Animations\\Spartan\\any any mixamo.JMM\"");
            CommandRunner.Current.RunCommand($"addanimation \"{Program.TagToolDirectory}\\Tools\\BaseCache\\Animations\\Spartan\\any any fingerlay.JMM\"");
            CommandRunner.Current.RunCommand($"addanimation \"{Program.TagToolDirectory}\\Tools\\BaseCache\\Animations\\Spartan\\any any fingerstand.JMM\"");
            CommandRunner.Current.RunCommand($"addanimation \"{Program.TagToolDirectory}\\Tools\\BaseCache\\Animations\\Spartan\\any any breakdance.JMM\"");
            CommandRunner.Current.RunCommand($"addanimation \"{Program.TagToolDirectory}\\Tools\\BaseCache\\Animations\\Spartan\\any any twerk.JMM\"");
            CommandRunner.Current.RunCommand($"addanimation \"{Program.TagToolDirectory}\\Tools\\BaseCache\\Animations\\Spartan\\any any hiphop.JMM\"");
            CommandRunner.Current.RunCommand($"addanimation \"{Program.TagToolDirectory}\\Tools\\BaseCache\\Animations\\Spartan\\any any ballskick.JMM\"");
            ContextStack.Pop();

            CommandRunner.Current.RunCommand($@"edittag objects\characters\elite\elite.model_animation_graph");
            CommandRunner.Current.RunCommand($"addanimation \"{Program.TagToolDirectory}\\Tools\\BaseCache\\Animations\\Elite\\combat thunderclap.JMM\"");
            CommandRunner.Current.RunCommand($"addanimation \"{Program.TagToolDirectory}\\Tools\\BaseCache\\Animations\\Elite\\any any dance1test.JMM\"");
            CommandRunner.Current.RunCommand($"addanimation \"{Program.TagToolDirectory}\\Tools\\BaseCache\\Animations\\Elite\\any any dance1.JMM\"");
            CommandRunner.Current.RunCommand($"addanimation \"{Program.TagToolDirectory}\\Tools\\BaseCache\\Animations\\Elite\\any any mixamo.JMM\"");
            CommandRunner.Current.RunCommand($"addanimation \"{Program.TagToolDirectory}\\Tools\\BaseCache\\Animations\\Elite\\any any fingerlay.JMM\"");
            CommandRunner.Current.RunCommand($"addanimation \"{Program.TagToolDirectory}\\Tools\\BaseCache\\Animations\\Elite\\any any fingerstand.JMM\"");
            CommandRunner.Current.RunCommand($"addanimation \"{Program.TagToolDirectory}\\Tools\\BaseCache\\Animations\\Elite\\any any breakdance.JMM\"");
            CommandRunner.Current.RunCommand($"addanimation \"{Program.TagToolDirectory}\\Tools\\BaseCache\\Animations\\Elite\\any any twerk.JMM\"");
            CommandRunner.Current.RunCommand($"addanimation \"{Program.TagToolDirectory}\\Tools\\BaseCache\\Animations\\Elite\\any any hiphop.JMM\"");
            CommandRunner.Current.RunCommand($"addanimation \"{Program.TagToolDirectory}\\Tools\\BaseCache\\Animations\\Elite\\any any ballskick.JMM\"");
            CommandRunner.Current.RunCommand($"addanimation \"{Program.TagToolDirectory}\\Tools\\BaseCache\\Animations\\Elite\\combat armor_lock_enter.JMM\"");
            CommandRunner.Current.RunCommand($"addanimation \"{Program.TagToolDirectory}\\Tools\\BaseCache\\Animations\\Elite\\combat armor_lock_exit.JMM\"");
            CommandRunner.Current.RunCommand($"addanimation \"{Program.TagToolDirectory}\\Tools\\BaseCache\\Animations\\Elite\\combat armor_lock_idle.JMM\"");
            CommandRunner.Current.RunCommand($"addanimation \"{Program.TagToolDirectory}\\Tools\\BaseCache\\Animations\\Elite\\combat con_blast_enter.JMM\"");
            CommandRunner.Current.RunCommand($"addanimation \"{Program.TagToolDirectory}\\Tools\\BaseCache\\Animations\\Elite\\combat con_blast_exit.JMM\"");
            CommandRunner.Current.RunCommand($"addanimation \"{Program.TagToolDirectory}\\Tools\\BaseCache\\Animations\\Elite\\combat mag_pulse_enter.JMM\"");
            CommandRunner.Current.RunCommand($"addanimation \"{Program.TagToolDirectory}\\Tools\\BaseCache\\Animations\\Elite\\sprint ball any move_front.JMA\"");
            CommandRunner.Current.RunCommand($"addanimation \"{Program.TagToolDirectory}\\Tools\\BaseCache\\Animations\\Elite\\sprint hammer any move_front.JMA\"");
            CommandRunner.Current.RunCommand($"addanimation \"{Program.TagToolDirectory}\\Tools\\BaseCache\\Animations\\Elite\\sprint missile any move_front.JMA\"");
            CommandRunner.Current.RunCommand($"addanimation \"{Program.TagToolDirectory}\\Tools\\BaseCache\\Animations\\Elite\\sprint pistol any move_front.JMA\"");
            CommandRunner.Current.RunCommand($"addanimation \"{Program.TagToolDirectory}\\Tools\\BaseCache\\Animations\\Elite\\sprint rifle any move_front.JMA\"");
            CommandRunner.Current.RunCommand($"addanimation \"{Program.TagToolDirectory}\\Tools\\BaseCache\\Animations\\Elite\\sprint sword any move_front.JMA\"");
            ContextStack.Pop();


            using (var stream = Cache.OpenCacheReadWrite()) 
            {
                Cache.StringTable.Add($@"con_blast_exit");
                Cache.SaveStrings();

                foreach (var tag in CacheContext.TagCache.NonNull()) 
                {
                    if (tag.IsInGroup("jmad") && tag.Name == $@"objects\characters\masterchief\masterchief") 
                    {
                        var jmad = CacheContext.Deserialize<ModelAnimationGraph>(stream, tag);
                        jmad.Modes[0].WeaponClass[1].WeaponType[0].Set.Actions = new List<ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry> 
                        {
                            new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry
                            {
                                Label = CacheContext.StringTable.GetStringId($@"airborne_dead"),
                                GraphIndex = -1,
                                Animation = 88,
                            },
                            new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry
                            {
                                Label = CacheContext.StringTable.GetStringId($@"landing_dead"),
                                GraphIndex = -1,
                                Animation = 89,
                            },
                            new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry
                            {
                                Label = CacheContext.StringTable.GetStringId($@"armor_lock_enter"),
                                GraphIndex = -1,
                                Animation = 91,
                            },
                            new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry
                            {
                                Label = CacheContext.StringTable.GetStringId($@"armor_lock_exit"),
                                GraphIndex = -1,
                                Animation = 92,
                            },
                            new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry
                            {
                                Label = CacheContext.StringTable.GetStringId($@"armor_lock_idle"),
                                GraphIndex = -1,
                                Animation = 93,
                            },
                            new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry
                            {
                                Label = CacheContext.StringTable.GetStringId($@"con_blast_enter"),
                                GraphIndex = -1,
                                Animation = 123,
                            },
                            new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry
                            {
                                Label = CacheContext.StringTable.GetStringId($@"mag_pulse_enter"),
                                GraphIndex = -1,
                                Animation = 238,
                            },
                            new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry
                            {
                                Label = CacheContext.StringTable.GetStringId($@"thunder_clap"),
                                GraphIndex = -1,
                                Animation = 1173,
                            },
                            new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry
                            {
                                Label = CacheContext.StringTable.GetStringId($@"twerk"),
                                GraphIndex = -1,
                                Animation = 1180,
                            },
                            new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry
                            {
                                Label = CacheContext.StringTable.GetStringId($@"dance1test"),
                                GraphIndex = -1,
                                Animation = 1174,
                            },
                            new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry
                            {
                                Label = CacheContext.StringTable.GetStringId($@"dance1"),
                                GraphIndex = -1,
                                Animation = 1175,
                            },
                            new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry
                            {
                                Label = CacheContext.StringTable.GetStringId($@"mixamo"),
                                GraphIndex = -1,
                                Animation = 1176,
                            },
                            new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry
                            {
                                Label = CacheContext.StringTable.GetStringId($@"fingerlay"),
                                GraphIndex = -1,
                                Animation = 1177,
                            },
                            new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry
                            {
                                Label = CacheContext.StringTable.GetStringId($@"fingerstand"),
                                GraphIndex = -1,
                                Animation = 1178,
                            },
                            new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry
                            {
                                Label = CacheContext.StringTable.GetStringId($@"breakdance"),
                                GraphIndex = -1,
                                Animation = 1179,
                            },
                            new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry
                            {
                                Label = CacheContext.StringTable.GetStringId($@"hiphop"),
                                GraphIndex = -1,
                                Animation = 1181,
                            },
                            new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry
                            {
                                Label = CacheContext.StringTable.GetStringId($@"ballskick"),
                                GraphIndex = -1,
                                Animation = 1182,
                            },
                        };
                        CacheContext.Serialize(stream, tag, jmad);
                    }

                    if (tag.IsInGroup("jmad") && tag.Name == $@"objects\characters\elite\elite")
                    {
                        var jmad = CacheContext.Deserialize<ModelAnimationGraph>(stream, tag);
                        jmad.EffectReferences = new List<ModelAnimationGraph.AnimationTagReference> 
                        {
                            new ModelAnimationGraph.AnimationTagReference
                            {
                                Reference = GetCachedTag<Effect>($@"objects\weapons\melee\gravity_hammer\fx\gravity_hammer_impact"),
                            },
                            new ModelAnimationGraph.AnimationTagReference
                            {
                                Reference = GetCachedTag<Effect>($@"fx\scenery_fx\morph\morph_medium\morph_to_medium_elite"),
                            },
                            new ModelAnimationGraph.AnimationTagReference
                            {
                                Reference = GetCachedTag<Effect>($@"objects\characters\masterchief\damage_effects\wraith_board_melee"),
                            },
                            new ModelAnimationGraph.AnimationTagReference
                            {
                                Reference = GetCachedTag<Effect>($@"objects\characters\masterchief\damage_effects\scorpion_board_melee"),
                            },
                            new ModelAnimationGraph.AnimationTagReference
                            {
                                Reference = GetCachedTag<Effect>($@"objects\characters\masterchief\damage_effects\assassination_hit_0"),
                            },
                            new ModelAnimationGraph.AnimationTagReference
                            {
                                Reference = GetCachedTag<Effect>($@"objects\characters\masterchief\damage_effects\assassination_hit_1"),
                            },
                            new ModelAnimationGraph.AnimationTagReference
                            {
                                Reference = GetCachedTag<Effect>($@"objects\characters\masterchief\damage_effects\assassination_hit_2"),
                            },
                            new ModelAnimationGraph.AnimationTagReference
                            {
                                Reference = GetCachedTag<Effect>($@"objects\characters\masterchief\damage_effects\assassination_hit_3"),
                            },
                            new ModelAnimationGraph.AnimationTagReference
                            {
                                Reference = GetCachedTag<Effect>($@"objects\characters\masterchief\damage_effects\concussive_blast"),
                            },
                        };
                        jmad.Animations[1610].PlaybackFlags = ModelAnimationGraph.Animation.PlaybackFlagsValue.DisableWeaponIk;
                        jmad.Animations[1610].AnimationData.EffectEvents = new List<ModelAnimationGraph.Animation.EffectEvent> 
                        {
                            new ModelAnimationGraph.Animation.EffectEvent
                            {
                                Effect = 8,
                                Frame = 16,
                                MarkerName = CacheContext.StringTable.GetStringId($@"shield_recharge"),
                                DamageEffectReportingType = new Damage.DamageReportingType
                                {
                                    HaloOnline = Damage.DamageReportingType.HaloOnlineValue.Guardians,
                                },
                            },
                        };
                        jmad.Modes[3].WeaponClass[1].WeaponType[0].Set.Actions = new List<ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry>
                        {
                            new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry
                            {
                                Label = CacheContext.StringTable.GetStringId($@"airborne_dead"),
                                GraphIndex = -1,
                                Animation = 109,
                            },
                            new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry
                            {
                                Label = CacheContext.StringTable.GetStringId($@"landing_dead"),
                                GraphIndex = -1,
                                Animation = 252,
                            },
                            new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry
                            {
                                Label = CacheContext.StringTable.GetStringId($@"armor_lock_enter"),
                                GraphIndex = -1,
                                Animation = 1607,
                            },
                            new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry
                            {
                                Label = CacheContext.StringTable.GetStringId($@"armor_lock_exit"),
                                GraphIndex = -1,
                                Animation = 1608,
                            },
                            new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry
                            {
                                Label = CacheContext.StringTable.GetStringId($@"armor_lock_idle"),
                                GraphIndex = -1,
                                Animation = 1609,
                            },
                            new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry
                            {
                                Label = CacheContext.StringTable.GetStringId($@"con_blast_enter"),
                                GraphIndex = -1,
                                Animation = 1610,
                            },
                            new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry
                            {
                                Label = CacheContext.StringTable.GetStringId($@"con_blast_exit"),
                                GraphIndex = -1,
                                Animation = 1611,
                            },
                            new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry
                            {
                                Label = CacheContext.StringTable.GetStringId($@"mag_pulse_enter"),
                                GraphIndex = -1,
                                Animation = 1612,
                            },
                            new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry
                            {
                                Label = CacheContext.StringTable.GetStringId($@"thunder_clap"),
                                GraphIndex = -1,
                                Animation = 1597,
                            },
                            new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry
                            {
                                Label = CacheContext.StringTable.GetStringId($@"twerk"),
                                GraphIndex = -1,
                                Animation = 1604,
                            },
                            new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry
                            {
                                Label = CacheContext.StringTable.GetStringId($@"dance1test"),
                                GraphIndex = -1,
                                Animation = 1598,
                            },
                            new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry
                            {
                                Label = CacheContext.StringTable.GetStringId($@"dance1"),
                                GraphIndex = -1,
                                Animation = 1599,
                            },
                            new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry
                            {
                                Label = CacheContext.StringTable.GetStringId($@"mixamo"),
                                GraphIndex = -1,
                                Animation = 1600,
                            },
                            new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry
                            {
                                Label = CacheContext.StringTable.GetStringId($@"fingerlay"),
                                GraphIndex = -1,
                                Animation = 1601,
                            },
                            new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry
                            {
                                Label = CacheContext.StringTable.GetStringId($@"fingerstand"),
                                GraphIndex = -1,
                                Animation = 1602,
                            },
                            new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry
                            {
                                Label = CacheContext.StringTable.GetStringId($@"breakdance"),
                                GraphIndex = -1,
                                Animation = 1603,
                            },
                            new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry
                            {
                                Label = CacheContext.StringTable.GetStringId($@"hiphop"),
                                GraphIndex = -1,
                                Animation = 1605,
                            },
                            new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry
                            {
                                Label = CacheContext.StringTable.GetStringId($@"ballskick"),
                                GraphIndex = -1,
                                Animation = 1606,
                            },
                        };
                        jmad.Modes.Add(new ModelAnimationGraph.Mode 
                        {
                            Name = CacheContext.StringTable.GetStringId("sprint"),
                            WeaponClass = new List<ModelAnimationGraph.Mode.WeaponClassBlock> 
                            {
                                new ModelAnimationGraph.Mode.WeaponClassBlock
                                {
                                    Label = CacheContext.StringTable.GetStringId("missile"),
                                    WeaponType = new List<ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock>
                                    {
                                        new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock
                                        {
                                            Label = CacheContext.StringTable.GetStringId("any"),
                                            Set = new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.AnimationSet
                                            {
                                                Actions = new List<ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry>
                                                {
                                                    new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry
                                                    {
                                                        Label = CacheContext.StringTable.GetStringId("move_front"),
                                                        GraphIndex = -1,
                                                        Animation = 1615,
                                                    },
                                                },
                                            },
                                        },
                                    },
                                },
                                new ModelAnimationGraph.Mode.WeaponClassBlock
                                {
                                    Label = CacheContext.StringTable.GetStringId("rifle"),
                                    WeaponType = new List<ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock>
                                    {
                                        new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock
                                        {
                                            Label = CacheContext.StringTable.GetStringId("any"),
                                            Set = new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.AnimationSet
                                            {
                                                Actions = new List<ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry>
                                                {
                                                    new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry
                                                    {
                                                        Label = CacheContext.StringTable.GetStringId("move_front"),
                                                        GraphIndex = -1,
                                                        Animation = 1617,
                                                    },
                                                },
                                            },
                                        },
                                    },
                                },
                                new ModelAnimationGraph.Mode.WeaponClassBlock
                                {
                                    Label = CacheContext.StringTable.GetStringId("pistol"),
                                    WeaponType = new List<ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock>
                                    {
                                        new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock
                                        {
                                            Label = CacheContext.StringTable.GetStringId("any"),
                                            Set = new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.AnimationSet
                                            {
                                                Actions = new List<ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry>
                                                {
                                                    new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry
                                                    {
                                                        Label = CacheContext.StringTable.GetStringId("move_front"),
                                                        GraphIndex = -1,
                                                        Animation = 1616,
                                                    },
                                                },
                                            },
                                        },
                                    },
                                },
                                new ModelAnimationGraph.Mode.WeaponClassBlock
                                {
                                    Label = CacheContext.StringTable.GetStringId("sword"),
                                    WeaponType = new List<ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock>
                                    {
                                        new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock
                                        {
                                            Label = CacheContext.StringTable.GetStringId("any"),
                                            Set = new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.AnimationSet
                                            {
                                                Actions = new List<ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry>
                                                {
                                                    new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry
                                                    {
                                                        Label = CacheContext.StringTable.GetStringId("move_front"),
                                                        GraphIndex = -1,
                                                        Animation = 1618,
                                                    },
                                                },
                                            },
                                        },
                                    },
                                },
                                new ModelAnimationGraph.Mode.WeaponClassBlock
                                {
                                    Label = CacheContext.StringTable.GetStringId("ball"),
                                    WeaponType = new List<ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock>
                                    {
                                        new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock
                                        {
                                            Label = CacheContext.StringTable.GetStringId("any"),
                                            Set = new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.AnimationSet
                                            {
                                                Actions = new List<ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry>
                                                {
                                                    new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry
                                                    {
                                                        Label = CacheContext.StringTable.GetStringId("move_front"),
                                                        GraphIndex = -1,
                                                        Animation = 1613,
                                                    },
                                                },
                                            },
                                        },
                                    },
                                },
                                new ModelAnimationGraph.Mode.WeaponClassBlock
                                {
                                    Label = CacheContext.StringTable.GetStringId("hammer"),
                                    WeaponType = new List<ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock>
                                    {
                                        new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock
                                        {
                                            Label = CacheContext.StringTable.GetStringId("any"),
                                            Set = new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.AnimationSet
                                            {
                                                Actions = new List<ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry>
                                                {
                                                    new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry
                                                    {
                                                        Label = CacheContext.StringTable.GetStringId("move_front"),
                                                        GraphIndex = -1,
                                                        Animation = 1614,
                                                    },
                                                },
                                            },
                                        },
                                    },
                                },
                            },
                        });

                        CacheContext.Serialize(stream, tag, jmad);

                        SortAnimationModes(stream, tag);
                    }

                    if (tag.IsInGroup("jmad") && tag.Name == $@"objects\characters\dervish\dervish") 
                    {
                        var jmad = CacheContext.Deserialize<ModelAnimationGraph>(stream, tag);
                        jmad.Modes[3].WeaponClass[1].WeaponType[0].Set.Actions = new List<ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry>
                        {
                            new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry
                            {
                                Label = CacheContext.StringTable.GetStringId($@"airborne_dead"),
                                GraphIndex = 0,
                                Animation = 109,
                            },
                            new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry
                            {
                                Label = CacheContext.StringTable.GetStringId($@"landing_dead"),
                                GraphIndex = 0,
                                Animation = 252,
                            },
                            new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry
                            {
                                Label = CacheContext.StringTable.GetStringId($@"armor_lock_enter"),
                                GraphIndex = 0,
                                Animation = 1607,
                            },
                            new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry
                            {
                                Label = CacheContext.StringTable.GetStringId($@"armor_lock_exit"),
                                GraphIndex = 0,
                                Animation = 1608,
                            },
                            new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry
                            {
                                Label = CacheContext.StringTable.GetStringId($@"armor_lock_idle"),
                                GraphIndex = 0,
                                Animation = 1609,
                            },
                            new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry
                            {
                                Label = CacheContext.StringTable.GetStringId($@"con_blast_enter"),
                                GraphIndex = 0,
                                Animation = 1610,
                            },
                            new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry
                            {
                                Label = CacheContext.StringTable.GetStringId($@"con_blast_exit"),
                                GraphIndex = 0,
                                Animation = 1611,
                            },
                            new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry
                            {
                                Label = CacheContext.StringTable.GetStringId($@"mag_pulse_enter"),
                                GraphIndex = 0,
                                Animation = 1612,
                            },
                            new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry
                            {
                                Label = CacheContext.StringTable.GetStringId($@"thunder_clap"),
                                GraphIndex = 0,
                                Animation = 1597,
                            },
                            new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry
                            {
                                Label = CacheContext.StringTable.GetStringId($@"twerk"),
                                GraphIndex = 0,
                                Animation = 1604,
                            },
                            new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry
                            {
                                Label = CacheContext.StringTable.GetStringId($@"dance1test"),
                                GraphIndex = 0,
                                Animation = 1598,
                            },
                            new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry
                            {
                                Label = CacheContext.StringTable.GetStringId($@"dance1"),
                                GraphIndex = 0,
                                Animation = 1599,
                            },
                            new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry
                            {
                                Label = CacheContext.StringTable.GetStringId($@"mixamo"),
                                GraphIndex = 0,
                                Animation = 1600,
                            },
                            new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry
                            {
                                Label = CacheContext.StringTable.GetStringId($@"fingerlay"),
                                GraphIndex = 0,
                                Animation = 1601,
                            },
                            new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry
                            {
                                Label = CacheContext.StringTable.GetStringId($@"fingerstand"),
                                GraphIndex = 0,
                                Animation = 1602,
                            },
                            new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry
                            {
                                Label = CacheContext.StringTable.GetStringId($@"breakdance"),
                                GraphIndex = 0,
                                Animation = 1603,
                            },
                            new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry
                            {
                                Label = CacheContext.StringTable.GetStringId($@"hiphop"),
                                GraphIndex = 0,
                                Animation = 1605,
                            },
                            new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry
                            {
                                Label = CacheContext.StringTable.GetStringId($@"ballskick"),
                                GraphIndex = 0,
                                Animation = 1606,
                            },
                        };
                        jmad.Modes.Add(new ModelAnimationGraph.Mode
                        {
                            Name = CacheContext.StringTable.GetStringId("sprint"),
                            WeaponClass = new List<ModelAnimationGraph.Mode.WeaponClassBlock>
                            {
                                new ModelAnimationGraph.Mode.WeaponClassBlock
                                {
                                    Label = CacheContext.StringTable.GetStringId("missile"),
                                    WeaponType = new List<ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock>
                                    {
                                        new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock
                                        {
                                            Label = CacheContext.StringTable.GetStringId("any"),
                                            Set = new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.AnimationSet
                                            {
                                                Actions = new List<ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry>
                                                {
                                                    new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry
                                                    {
                                                        Label = CacheContext.StringTable.GetStringId("move_front"),
                                                        GraphIndex = 0,
                                                        Animation = 1615,
                                                    },
                                                },
                                            },
                                        },
                                    },
                                },
                                new ModelAnimationGraph.Mode.WeaponClassBlock
                                {
                                    Label = CacheContext.StringTable.GetStringId("rifle"),
                                    WeaponType = new List<ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock>
                                    {
                                        new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock
                                        {
                                            Label = CacheContext.StringTable.GetStringId("any"),
                                            Set = new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.AnimationSet
                                            {
                                                Actions = new List<ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry>
                                                {
                                                    new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry
                                                    {
                                                        Label = CacheContext.StringTable.GetStringId("move_front"),
                                                        GraphIndex = 0,
                                                        Animation = 1617,
                                                    },
                                                },
                                            },
                                        },
                                    },
                                },
                                new ModelAnimationGraph.Mode.WeaponClassBlock
                                {
                                    Label = CacheContext.StringTable.GetStringId("pistol"),
                                    WeaponType = new List<ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock>
                                    {
                                        new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock
                                        {
                                            Label = CacheContext.StringTable.GetStringId("any"),
                                            Set = new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.AnimationSet
                                            {
                                                Actions = new List<ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry>
                                                {
                                                    new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry
                                                    {
                                                        Label = CacheContext.StringTable.GetStringId("move_front"),
                                                        GraphIndex = 0,
                                                        Animation = 1616,
                                                    },
                                                },
                                            },
                                        },
                                    },
                                },
                                new ModelAnimationGraph.Mode.WeaponClassBlock
                                {
                                    Label = CacheContext.StringTable.GetStringId("sword"),
                                    WeaponType = new List<ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock>
                                    {
                                        new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock
                                        {
                                            Label = CacheContext.StringTable.GetStringId("any"),
                                            Set = new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.AnimationSet
                                            {
                                                Actions = new List<ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry>
                                                {
                                                    new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry
                                                    {
                                                        Label = CacheContext.StringTable.GetStringId("move_front"),
                                                        GraphIndex = 0,
                                                        Animation = 1618,
                                                    },
                                                },
                                            },
                                        },
                                    },
                                },
                                new ModelAnimationGraph.Mode.WeaponClassBlock
                                {
                                    Label = CacheContext.StringTable.GetStringId("ball"),
                                    WeaponType = new List<ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock>
                                    {
                                        new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock
                                        {
                                            Label = CacheContext.StringTable.GetStringId("any"),
                                            Set = new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.AnimationSet
                                            {
                                                Actions = new List<ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry>
                                                {
                                                    new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry
                                                    {
                                                        Label = CacheContext.StringTable.GetStringId("move_front"),
                                                        GraphIndex = 0,
                                                        Animation = 1613,
                                                    },
                                                },
                                            },
                                        },
                                    },
                                },
                                new ModelAnimationGraph.Mode.WeaponClassBlock
                                {
                                    Label = CacheContext.StringTable.GetStringId("hammer"),
                                    WeaponType = new List<ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock>
                                    {
                                        new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock
                                        {
                                            Label = CacheContext.StringTable.GetStringId("any"),
                                            Set = new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.AnimationSet
                                            {
                                                Actions = new List<ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry>
                                                {
                                                    new ModelAnimationGraph.Mode.WeaponClassBlock.WeaponTypeBlock.Entry
                                                    {
                                                        Label = CacheContext.StringTable.GetStringId("move_front"),
                                                        GraphIndex = 0,
                                                        Animation = 1614,
                                                    },
                                                },
                                            },
                                        },
                                    },
                                },
                            },
                        });

                        CacheContext.Serialize(stream, tag, jmad);

                        SortAnimationModes(stream, tag);
                    }
                }
            }
        }

        public void SortAnimationModes(Stream stream, CachedTag tag)
        {
            var jmad = CacheContext.Deserialize<ModelAnimationGraph>(stream, tag);

            var resolver = CacheContext.StringTable.Resolver;

            jmad.Modes = jmad.Modes.OrderBy(a => resolver.GetSet(a.Name)).ThenBy(a => resolver.GetIndex(a.Name)).ToList();

            foreach (var mode in jmad.Modes)
            {
                mode.WeaponClass = mode.WeaponClass.OrderBy(a => resolver.GetSet(a.Label)).ThenBy(a => resolver.GetIndex(a.Label)).ToList();

                foreach (var weaponClass in mode.WeaponClass)
                {
                    weaponClass.WeaponType = weaponClass.WeaponType.OrderBy(a => resolver.GetSet(a.Label)).ThenBy(a => resolver.GetIndex(a.Label)).ToList();

                    foreach (var weaponType in weaponClass.WeaponType)
                    {
                        weaponType.Set.Actions = weaponType.Set.Actions.OrderBy(a => resolver.GetSet(a.Label)).ThenBy(a => resolver.GetIndex(a.Label)).ToList();
                        weaponType.Set.Overlays = weaponType.Set.Overlays.OrderBy(a => resolver.GetSet(a.Label)).ThenBy(a => resolver.GetIndex(a.Label)).ToList();
                        weaponType.Set.DeathAndDamage = weaponType.Set.DeathAndDamage.OrderBy(a => resolver.GetSet(a.Label)).ThenBy(a => resolver.GetIndex(a.Label)).ToList();
                        weaponType.Set.Transitions = weaponType.Set.Transitions.OrderBy(a => resolver.GetSet(a.FullName)).ThenBy(a => resolver.GetIndex(a.FullName)).ToList();

                        foreach (var transition in weaponType.Set.Transitions) 
                        {
                            transition.Destinations = transition.Destinations.OrderBy(a => resolver.GetSet(a.FullName)).ThenBy(a => resolver.GetIndex(a.FullName)).ToList();
                        }
                    }
                }
            }

            CacheContext.Serialize(stream, tag, jmad);
        }
    }
}