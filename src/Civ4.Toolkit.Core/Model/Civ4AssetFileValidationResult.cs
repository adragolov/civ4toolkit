using System.Xml;

namespace Civ4.Toolkit.Model;

public class Civ4AssetFileValidationResult
{
    public string? XdrFile { get; set; }
    
    public ValidationType? ValidationType { get; set; }

    public IEnumerable<string> Warnings { get; set; } = Array.Empty<string>();
    
    public IEnumerable<string> Errors { get; set; } = Array.Empty<string>();
    
    public bool IsValid => !Errors.Any();
}
