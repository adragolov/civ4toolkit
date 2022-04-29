using System.Threading;
using System.Threading.Tasks;
using Civ4.Toolkit.Model;

namespace Civ4.Toolkit.Services;

public interface ICiv4XmlValidator
{
    Task<Civ4AssetFileValidationResult> ValidateUsingXdrAsync(
        string xmlFile,
        string targetNamespace,
        string xdrFile,
        CancellationToken cancellationToken = default);
}
