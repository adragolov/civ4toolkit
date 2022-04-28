using System.Xml.Serialization;

namespace Civ4.Toolkit.Model.Assets.Xml.Art;

public class Civ4UnitArtInfo
{
    [XmlElement("Type", Order = 1)]
    public string? Type { get; set; }
    
    [XmlElement("Button", Order = 2)]
    public string? Button { get; set; }
    
    [XmlElement("fScale", Order = 3)]
    public float? Scale { get; set; }
    
    [XmlElement("fInterfaceScale", Order = 4)]
    public float? InterfaceScale { get; set; }
    
    [XmlElement("bActAsLand", Order = 5)]
    public byte? ActAsLand { get; set; }
    
    [XmlElement("bActAsAir", Order = 6)]
    public byte? ActAsAir { get; set; }
    
    [XmlElement("NIF", Order = 7)]
    public string? NIF { get; set; }
    
    [XmlElement("KFM", Order = 8)]
    public string? KFM { get; set; }
    
    [XmlElement("SHADERNIF", Order = 9)]
    public string? ShaderNif { get; set; }
    
    [XmlElement("ShadowDef", Order = 10)]
    public Civ4ShadowDef? ShadowDef { get; set; }
    
    [XmlElement("iDamageStates", Order = 11)]
    public int? DamageStates { get; set; }
    
    [XmlElement("TrailDefinition", Order = 12)]
    public Civ4TrailDefinition? TrailDefinition { get; set; }
    
    [XmlElement("fBattleDistance", Order = 13)]
    public float? BattleDistance { get; set; }
    
    [XmlElement("fRangedDeathTime", Order = 14)]
    public float? RangedDeathTime { get; set; }
    
    [XmlElement("bSmoothMove", Order = 15)]
    public byte? SmoothMove { get; set; }
    
    [XmlElement("fAngleInterpRate", Order = 16)]
    public float? AngleInterpretationRate { get; set; }
    
    [XmlElement("fBankRate", Order = 17)]
    public float? BankRate { get; set; }
    
    [XmlElement("fExchangeAngle", Order = 18)]
    public float? ExchangeAngle { get; set; }
    
    [XmlElement("bCombatExempt", Order = 19)]
    public byte? CombatExempt { get; set; }
    
    [XmlElement("bActAsRanged", Order = 20)]
    public byte? ActAsRanged { get; set; }
    
    [XmlElement("TrainSound", Order = 21)]
    public string? TrainSound { get; set; }
    
    [XmlElement("AudioRunSounds", Order = 22)]
    public Civ4AudioRunSounds? AudioRunSounds { get; set; }
    
    [XmlElement("PatrolSound", Order = 23)]
    public string? PatrolSound { get; set; }
    
    [XmlElement("SelectionSound", Order = 24)]
    public string? SelectionSound { get; set; }
    
    [XmlElement("ActionSound", Order = 25)]
    public string? ActionSound { get; set; }
    
    public override string ToString()
    {
        return $"UnitArtInfo = {Type}";
    }
}
