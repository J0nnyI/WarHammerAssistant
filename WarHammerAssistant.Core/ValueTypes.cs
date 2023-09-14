using JLib;

namespace WarHammerAssistant.Core;
public interface IDiceValue
{

}
public interface IConstantValue
{

}
public enum GameValueMode
{
    Dice,
    Constant
}
public record GameValue(int Value, GameValueMode Mode) : IntValueType(Value), IDiceValue, IConstantValue;
public record DiceValue(int Value) : IntValueType(Value), IDiceValue;
public record ConstantValue(int Value) : IntValueType(Value), IConstantValue;