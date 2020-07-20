using System;

namespace WatchMyDrugs.Application.Services.Models
{
    public class CreateNewDrugRequest
    {
        public readonly string DrugType;
        public readonly string ExtId;
        public readonly DateTime DateOfCreation;

        public CreateNewDrugRequest(
            string drugType,
            string extId,
            DateTime dateOfCreation)
        {
            if (string.IsNullOrWhiteSpace(drugType))
            {
                throw new ArgumentException($"'{nameof(drugType)}' cannot be null or whitespace", nameof(drugType));
            }

            if (string.IsNullOrWhiteSpace(extId))
            {
                throw new ArgumentException($"'{nameof(extId)}' cannot be null or whitespace", nameof(extId));
            }

            DrugType = drugType;
            ExtId = extId;
            DateOfCreation = dateOfCreation;
        }
    }
}