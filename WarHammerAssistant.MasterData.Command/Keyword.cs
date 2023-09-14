using JLib;

using static WarHammerAssistant.MasterData.Command.KeywordValueTypes;

namespace WarHammerAssistant.MasterData.Command;

public abstract class Keyword
{
    public required Name Name { get; set; }
    public required Description Description { get; set; }
}
public abstract class WeaponKeyword : Keyword
{

}
public class RangedWeaponKeyword : WeaponKeyword
{

}

public class MeeleWeaponKeyword : WeaponKeyword
{

}
public class FractionKeyword : Keyword
{

}

public abstract class KeywordValueTypes
{
    public record Name(string Value) : StringValueType(Value)
    {
        public static implicit operator Name(string value)
            => new(value);
    }
    public record Description(string Value) : StringValueType(Value)
    {
        public static implicit operator Description(string value)
            => new(value);
    }
}