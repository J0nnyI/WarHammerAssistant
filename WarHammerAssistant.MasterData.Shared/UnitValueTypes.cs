using JLib;

using WarHammerAssistant.Core;

namespace WarHammerAssistant.MasterData.Shared;

public class NationValueTypes
{
    public record Name(string Value) : StringValueType(Value)
    {
        public static implicit operator Name(string value) => new(value);
    }
    public record Description(string Value) : StringValueType(Value)
    {
        public static implicit operator Description(string value) => new(value);
    }
}
public class FactionValueTypes
{
    public record Name(string Value) : StringValueType(Value)
    {
        public static implicit operator Name(string value) => new(value);
    }
    public record Description(string Value) : StringValueType(Value)
    {
        public static implicit operator Description(string value) => new(value);
    }
}
public class SkillValueTypes
{
    public record Name(string Value) : StringValueType(Value)
    {
        public static implicit operator Name(string value) => new(value);
    }
    public record Description(string Value) : StringValueType(Value)
    {
        public static implicit operator Description(string value) => new(value);
    }
    public record Header(string Value) : StringValueType(Value)
    {
        public static implicit operator Header(string value) => new(value);
    }
    public record Value(int Value) : IntValueType(Value)
    {
        public static implicit operator Value(int value) => new(value);
    }
    public record Condition(string Value) : StringValueType(Value)
    {
        public static implicit operator Condition(string value) => new(value);
    }
}

public class UnitValueTypes
{
    public record Name(string Value) : StringValueType(Value)
    {
        public static implicit operator Name(string value) => new(value);
    }
    /// <summary>
    /// M - Move<br/>
    /// B - Bewegung
    /// </summary>
    /// <param name="Value"></param>
    public record Move(int Value) : ConstantValue(Value)
    {
        public static implicit operator Move(int value) => new(value);
    }
    /// <summary>
    /// T - Toughness<br/>
    /// W - Wiederstand
    /// </summary>
    /// <param name="Value"></param>
    public record Toughness(int Value) : ConstantValue(Value)
    {
        public static implicit operator Toughness(int value) => new(value);
    }
    /// <summary>
    /// SV<br/>
    /// RW - Rüstwert
    /// </summary>
    /// <param name="Value"></param>
    public record SV(int Value) : ConstantValue(Value)
    {
        public static implicit operator SV(int value) => new(value);
    }
    /// <summary>
    /// W - Wounds<br/>
    /// LP - LivePoints
    /// </summary>
    /// <param name="Value"></param>
    public record Wounds(int Value) : ConstantValue(Value)
    {
        public static implicit operator Wounds(int value) => new(value);
    }
    /// <summary>
    /// Ld - Leadership<br/>
    /// Mw - Moralwert
    /// </summary>
    /// <param name="Value"></param>
    public record Leadership(int Value) : IntValueType(Value)
    {
        public static implicit operator Leadership(int value) => new(value);
    }
    /// <summary>
    /// OC - Objective Control<br/>
    /// MK - Missionskontrolle
    /// </summary>
    /// <param name="Value"></param>
    public record ObjectiveControl(int Value) : IntValueType(Value)
    {
        public static implicit operator ObjectiveControl(int value) => new(value);
    }
}
public class EquipmentValueTypes
{
    public record Name(string Value) : StringValueType(Value)
    {
        public static implicit operator Name(string value) => new(value);
    }
}
public class WeaponModeValueTypes
{
    public record Name(string Value) : StringValueType(Value)
    {
        public static implicit operator Name(string value) => new(value);
    }
    /// <summary>
    /// Reichw.
    /// </summary>
    /// <param name="Value"></param>
    public record Range(int Value) : ConstantValue(Value)
    {
        public static implicit operator Range(int value) => new(value);
    }
    public abstract record Attacks(int Value, GameValueMode mode) : GameValue(Value, mode);
    public record DiceAttacks(int Value) : Attacks(Value, GameValueMode.Dice);
    public record ConstantAttacks(int Value) : Attacks(Value, GameValueMode.Constant);
    public record KG(int Value) : ConstantValue(Value)
    {
        public static implicit operator KG(int value) => new(value);
    }
    public record BF(int Value) : ConstantValue(Value)
    {
        public static implicit operator BF(int value) => new(value);
    }
    public record S(int Value) : ConstantValue(Value)
    {
        public static implicit operator S(int value) => new(value);
    }
    public record DS(int Value) : ConstantValue(Value)
    {
        public static implicit operator DS(int value) => new(value);
    }
    public record SW(int Value) : ConstantValue(Value)
    {
        public static implicit operator SW(int value) => new(value);
    }
}