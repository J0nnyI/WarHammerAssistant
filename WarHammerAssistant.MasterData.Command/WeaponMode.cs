using static WarHammerAssistant.MasterData.Shared.WeaponModeValueTypes;

using Range = WarHammerAssistant.MasterData.Shared.WeaponModeValueTypes.Range;

namespace WarHammerAssistant.MasterData.Command;

public abstract class WeaponMode
{
    public Name? Name { get; set; }
    public required Range Range { get; set; }
    public required Attacks Attacks { get; set; }
    public required S S { get; set; }
    public required DS DS { get; set; }
    public required SW SW { get; set; }
    public List<WeaponKeyword> Keywords { get; } = new();
}

public class MeeleWeaponMode : WeaponMode
{
    public KG KG { get; set; }

}
public class RangedWeaponMode : WeaponMode
{
    public BF BF { get; set; }

}