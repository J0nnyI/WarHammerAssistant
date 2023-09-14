using static WarHammerAssistant.MasterData.Shared.NationValueTypes;

namespace WarHammerAssistant.MasterData.Command;

public class Nation
{
    public required Name Name { get; set; }
    public required Description Description { get; set; }
    public required Keyword Keyword { get; set; }
}
