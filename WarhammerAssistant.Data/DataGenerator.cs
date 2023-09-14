using System.Reflection.Metadata.Ecma335;
using System.Xml.Schema;

using WarHammerAssistant.MasterData.Command;

using static WarHammerAssistant.MasterData.Shared.WeaponModeValueTypes;

namespace WarhammerAssistant.Data;

public class DataGenerator
{
    public static void CreateAll()
    {
        var keywords = new
        {
            Imperium = new FractionKeyword()
            {
                Name = "Imperium",
                Description = "You can play units with the imperium keyword"
            },
            Pistol = new RangedWeaponKeyword()
            {
                Name = "Pistol",
                Description = "",
            },
            Risky = new RangedWeaponKeyword()
            {
                Name = "Risky",
                Description = "Riskant"
            },
            Infantry = new RangedWeaponKeyword()
            {
                Name = "Infantry",
                Description = "Infanterie"
            },
            CharacterModel = new RangedWeaponKeyword()
            {
                Name = "CharakterModel",
                Description = ""
            },
            Grenades = new RangedWeaponKeyword()
            {
                Name = "Grenades",
                Description = ""
            },
            Tacticus = new RangedWeaponKeyword()
            {
                Name = "Tacticus",
                Description = ""
            },
            Primaris = new RangedWeaponKeyword()
            {
                Name = "Primaris",
                Description = ""
            },
            Captain = new RangedWeaponKeyword()
            {
                Name = "Captain",
                Description = ""
            }
        };

        var nations = new
        {
            Imperium = new Nation()
            {
                Name = "Imperium",
                Description = "Based Imperial Bastards",
                Keyword = keywords.Imperium
            }
        };
        var factions = new
        {
            primarisOath = new Faction()
            {
                Name = "Primaris",
                Nation = nations.Imperium
            }
        };
        var rangedWeapons = new
        {
            Boltgun = new RangedWeapon()
            {
                Name = "Boltgun",
                Modes = {
                    new(){
                        Range = 12,
                        Attacks = new ConstantAttacks(1),
                        BF = 2,
                        S = 4,
                        DS = 0,
                        SW = 1
                    }
                }
            },
            MasterfullBoltrifle = new RangedWeapon()
            {
                Name = "Masterfull Boltrifle",
                Modes = {
                    new(){
                        Range = 24,
                        Attacks = new ConstantAttacks(2),
                        BF = 2,
                        S = 4,
                        DS = -1,
                        SW = 2
                    }
                }
            },
            PlasmaPistol = new RangedWeapon()
            {
                Name = "Plasma Pistol",
                Modes = {
                    new(){
                        Name = "Default",
                        Range = 12,
                        Attacks = new ConstantAttacks(1),
                        BF = 2,
                        S = 7,
                        DS = -2,
                        SW = 1
                    },
                    new(){
                        Name = "Overload",
                        Range = 12,
                        Attacks = new ConstantAttacks(1),
                        BF = 2,
                        S = 8,
                        DS = -3,
                        SW = 2,
                        Keywords =
                        {
                            keywords.Pistol,
                            keywords.Risky
                        }
                    }
                }
            },
            HeavyBoltgun = new RangedWeapon()
            {
                Name = "Heavy Boltgun",
                Modes =
                {
                    new()
                    {
                        Range = 18,
                        Attacks = new ConstantAttacks(1),
                        BF = 2,
                        S = 4,
                        DS = -1,
                        SW = 1
                    }
                }
            }
        };
        var meeleWeapons = new
        {
            EnergyFist = new MeeleWeapon()
            {
                Name = "EnergyFist",
                Modes =
                {
                    new()
                    {
                        Range=0,
                        Attacks = new ConstantAttacks(5),
                        KG = 2,
                        S = 8,
                        DS = -2,
                        SW = 2
                    }
                }
            },
            HandWeapon = new MeeleWeapon()
            {
                Name = "HandWeapon",
                Modes =
                {
                    new()
                    {
                        Range=0,
                        Attacks = new ConstantAttacks(6),
                        KG = 2,
                        S = 4,
                        DS = 0,
                        SW = 1
                    }
                }
            },
            MasterfullEnergyweapon = new MeeleWeapon()
            {
                Name = "Masterfull Energyweapon",
                Modes =
                {
                    new()
                    {
                        Range=0,
                        Attacks = new ConstantAttacks(6),
                        KG = 2,
                        S = 5,
                        DS = -2,
                        SW = 2
                    }
                }
            }
        };
        var equipments = new
        {
            HonorShield = new Equipment()
            {
                Name = "HonorShield",
                Skills =
                {
                    new()
                    {
                        Name="Honor Shield",
                        Description= "Der Träger hat LP=6"
                    }
                }
            }
        };
        var units = new
        {
            IntercessorSturmtrupp = null as Unit,
            Klingengardetrupp = null as Unit,
            PlasmaInterfectortrupp = null as Unit,
            Infernustrupp = null as Unit,
            Intercessortrupp = null as Unit,
            Protektorgardetrupp = null as Unit,
        };
        var leader = new
        {
            PrimarisCaptain = new Unit()
            {
                Name = "Primaris-Captain",
                Move = 6,
                Toughness = 4,
                SV = 3,
                Wounds = 5,
                Leadership = 6,
                ObjectiveControl = 1,
                EquipmentOptions =
                {
                    new() {
                        Items =
                        {
                            rangedWeapons.Boltgun,
                            rangedWeapons.MasterfullBoltrifle,
                        },
                        NestedOptions =
                        {
                            new()
                            {
                                Items =
                                {
                                    meeleWeapons.HandWeapon,
                                    meeleWeapons.EnergyFist,
                                    meeleWeapons.MasterfullEnergyweapon
                                }
                            }
                        }
                    },
                    new()
                    {
                        Items = {
                            rangedWeapons.PlasmaPistol,
                            meeleWeapons.EnergyFist
                        }
                    },
                    new()
                    {
                        Items = {
                            rangedWeapons.HeavyBoltgun,
                            meeleWeapons.MasterfullEnergyweapon,
                            equipments.HonorShield
                        }
                    }
                },
                Keywords =
                {
                    keywords.Infantry, keywords.CharacterModel, keywords.Grenades,
                    keywords.Imperium, keywords.Tacticus, keywords.Primaris, keywords.Captain
                },
                Skills =
                {
                    new Rettungswurf()
                    {
                        Header="Rettungswurf",
                        Name="Rettungswurf",
                        Value=4
                    },
                    new CustomSkill()
                    {
                        Name="Riten der Schlacht",
                        Description="..."
                    },
                    new CustomSkill()
                    {
                        Name="Sternstunde",
                        Description="..."
                    },
                    new Leader()
                    {
                        Name="Leader",
                        Options =
                        {
                            new(){Unit=units.IntercessorSturmtrupp },
                            new(){
                                Unit=units.Klingengardetrupp,
                                Condition="nur wenn Ehrenschild ausgerüstet ist"
                            },
                            new(){
                                Unit=units.PlasmaInterfectortrupp,
                                Condition="nur wenn Plasmapistole ausgerüstet ist"
                            },
                            new(){Unit=units.Infernustrupp },
                            new(){Unit=units.Intercessortrupp },
                            new(){Unit=units.Protektorgardetrupp },
                        }
                    }
                }
            }
        };
    }
}