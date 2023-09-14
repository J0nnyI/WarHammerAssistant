using static WarHammerAssistant.MasterData.Shared.FactionValueTypes;

namespace WarHammerAssistant.MasterData.Command;

public class Faction
{
    public required Nation Nation { get; set; }
    public required Name Name { get; set; }
}