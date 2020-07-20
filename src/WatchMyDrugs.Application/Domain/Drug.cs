using System;
namespace WatchMyDrugs.Application.Domain
{
    // Препарат (не конкретный бутыль с лекарством, а препарат в целом)
    public class Drug
    {
        // Наименования препарата
        public string Name {get; private set;}

        // время через которое препарат приходит в негодность
        public TimeSpan ExpireAfter {get; private set;}
    }
}