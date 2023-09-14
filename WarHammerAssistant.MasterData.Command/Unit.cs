using static WarHammerAssistant.MasterData.Shared.UnitValueTypes;

namespace WarHammerAssistant.MasterData.Command;

public class Unit
{
    public required Name Name { get; set; }
    public required Move Move { get; set; }
    public required Toughness Toughness { get; set; }
    public required SV SV { get; set; }
    public required Wounds Wounds { get; set; }
    public required Leadership Leadership { get; set; }
    public required ObjectiveControl ObjectiveControl { get; set; }
    public List<ItemOption> EquipmentOptions { get; } = new();
    public List<Keyword> Keywords { get; } = new();
    public List<Skill> Skills { get; } = new();
}
public class ItemOption
{
    public List<Item> Items { get; } = new();
    public List<ItemOption> NestedOptions { get; } = new();
}
public class BasicRule
{

}
