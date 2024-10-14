using System.Collections.Generic;
using System.Linq;

namespace LivestockAuction.Services
{
    public class LotService
    {
        private List<Lot> _lots = new List<Lot>
        {
            new Lot { Id = 1, Description = "Vaca Lechera Holstein", CurrentBid = 1000 },
            new Lot { Id = 2, Description = "Toro Angus", CurrentBid = 1500 },
            new Lot { Id = 3, Description = "Oveja Merino", CurrentBid = 500 },
             new Lot { Id = 4, Description = "Vaca Angus", CurrentBid = 650 }
        };

        public List<Lot> GetLots() => _lots;

        public void PlaceBid(int lotId, decimal bidAmount)
        {
            var lot = _lots.FirstOrDefault(l => l.Id == lotId);
            if (lot != null && bidAmount > lot.CurrentBid)
            {
                lot.CurrentBid = bidAmount;
            }
        }
    }

    public class Lot
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal CurrentBid { get; set; }
    }
}