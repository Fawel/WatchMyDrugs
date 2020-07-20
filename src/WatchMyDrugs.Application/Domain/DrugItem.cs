using System;

namespace WatchMyDrugs.Application.Domain
{
    // Конкретная упаковка некоего препарата
    public class DrugItem
    {
        // Препарат к которому относится данное лекарство
        public readonly Drug Drug;

        // Дата изготовления лекарства
        public DateTime Created { get; private set; }

        // Уникальный идентификатор упаковки лекарства
        public string ExtId { get; private set; }
    }
}