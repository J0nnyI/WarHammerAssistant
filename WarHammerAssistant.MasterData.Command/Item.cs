using JLib;

using static WarHammerAssistant.MasterData.Shared.EquipmentValueTypes;

namespace WarHammerAssistant.MasterData.Command;

public abstract class Item
{
    public required Name Name { get; set; }
}
public class Equipment : Item
{
    public List<EquipmentSkill> Skills { get; } = new();
}
public abstract class Item<TMode> : Item
    where TMode : WeaponMode
{
    public List<TMode> Modes { get; set; }
}
public class MeeleWeapon : Item<MeeleWeaponMode>
{

}
public class RangedWeapon : Item<RangedWeaponMode>
{

}
