using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LivestockAuction.Services
{
    public class AnimalDataService
    {
        public Task<List<AuctionDate>> GetAuctionDatesAsync()
        {
            return Task.FromResult(new List<AuctionDate>
            {
                new AuctionDate { Value = "2023-05-20", Display = "20 de Mayo, 2023" },
                new AuctionDate { Value = "2023-05-27", Display = "27 de Mayo, 2023" },
                new AuctionDate { Value = "2023-06-03", Display = "3 de Junio, 2023" }
            });
        }

        public Task<List<string>> GetBreedsAsync()
        {
            return Task.FromResult(new List<string> { "Angus", "Hereford", "Brahman", "Charolais" });
        }

        public Task<List<string>> GetAnimalTypesAsync()
        {
            return Task.FromResult(new List<string> { "Vacuno", "Equino", "Ovino" });
        }

        public Task<List<string>> GetAgeSexOptionsAsync()
        {
            return Task.FromResult(new List<string> { "Becerro", "Vaquilla", "Novillo", "Vaca", "Toro" });
        }
    }

    public class AuctionDate
    {
        public string Value { get; set; }
        public string Display { get; set; }
    }
}
