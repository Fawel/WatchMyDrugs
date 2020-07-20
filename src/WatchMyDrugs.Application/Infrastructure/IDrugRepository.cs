using System.Threading;
using System.Threading.Tasks;

namespace WatchMyDrugs.Application.Infrastructure
{
    public interface IDrugRepository
    {
        Task GetDrugTypesAsync(CancellationToken token = default);
        Task GetDrugItemsAsync(CancellationToken token = default);
    }
}