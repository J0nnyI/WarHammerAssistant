using static WarHammerAssistant.MasterData.Shared.SkillValueTypes;

namespace WarHammerAssistant.MasterData.Command;

public abstract class Skill
{
    public required Name Name { get; set; }
    public Header Header { get; set; } = "Fähigkeiten";
}
public class EquipmentSkill: Skill
{
    public required Description Description { get; set; }
}
public class CustomSkill : Skill
{
    public required Description Description { get; set; }
}
public class Rettungswurf : Skill
{
    public required Value Value { get; set; }
}
public class Leader : Skill
{
    public Description Description { get; } = "Dieses Modall kann sich den folgenden Einheiten anschließen:";
    public Header Header { get; } = "Leader";
    public List<LeaderOption> Options { get; } = new();
}
public class LeaderOption
{
    public required Unit Unit { get; set; }
    public Condition? Condition { get; set; }
}