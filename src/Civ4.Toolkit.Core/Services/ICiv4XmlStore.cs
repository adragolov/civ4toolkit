using System.Threading;
using System.Threading.Tasks;
using Civ4.Toolkit.Model;

namespace Civ4.Toolkit.Services;

public interface ICiv4XmlStore<TXmlAssetFile> where TXmlAssetFile : Civ4AssetFile
{
    Task<TXmlAssetFile> LoadAsync(
        string xmlPath,
        CancellationToken cancellationToken = default);
}