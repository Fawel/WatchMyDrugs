using System.Threading;
using System.Threading.Tasks;

namespace WatchMyDrugs.Application.Infrastructure
{
    // Репозиторий для получения инфы про лекарства и их типы
    public interface IDrugRepository
    {
        Task GetDrugTypesAsync(CancellationToken token = default);
        Task GetDrugItemsAsync(CancellationToken token = default);
    }
}