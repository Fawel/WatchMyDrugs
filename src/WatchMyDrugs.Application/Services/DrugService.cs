using System;
using System.Threading;
using System.Threading.Tasks;
using WatchMyDrugs.Application.Infrastructure;
using WatchMyDrugs.Application.Services.Models;

namespace WatchMyDrugs.Application.Services
{
    public interface IDrugService
    {
        ///<summary> Получаем список всех лекарств всех типов</summary>
        Task<DrugListResponse> GetDrugListAsync(CancellationToken token = default);

        // Добавляет новый тип лекарств
        Task AddNewDrugTypeAsync(
            CreateNewDrugTypeRequest request,
            CancellationToken token = default);
        
        // Убираем тип лекарст. Операция возможна только если к данному типу не привязано никаких лекарств
        Task RemoveDrugTypeAsync(string drugTypeName, CancellationToken token = default);
        
        // Добавляем новое лекарство определённого типа
        Task AddNewDrugAsync(
            CreateNewDrugRequest request,
            CancellationToken token = default);

        // Убираем лекарство
        Task RemoveDrugAsync(RemoveDrugRequest request, CancellationToken token = default);

        // Получаем список лекарств с истёкшим сроком годности
        Task<ExpiredDrugsResponse> GetExpiredDrugsAsync(CancellationToken token = default);
    }

    public class DrugService : IDrugService
    {
        private readonly IDrugRepository _drugRepository;

        public Task AddNewDrugAsync(CreateNewDrugRequest request, CancellationToken token = default)
        {
            throw new NotImplementedException();
        }

        public Task AddNewDrugTypeAsync(CreateNewDrugTypeRequest request, CancellationToken token = default)
        {
            throw new NotImplementedException();
        }

        public Task<DrugListResponse> GetDrugListAsync(CancellationToken token = default)
        {
            throw new NotImplementedException();
        }

        public Task<ExpiredDrugsResponse> GetExpiredDrugsAsync(CancellationToken token = default)
        {
            throw new NotImplementedException();
        }

        public Task RemoveDrugAsync(RemoveDrugRequest request, CancellationToken token = default)
        {
            throw new NotImplementedException();
        }

        public Task RemoveDrugTypeAsync(string drugTypeName, CancellationToken token = default)
        {
            throw new NotImplementedException();
        }
    }
}