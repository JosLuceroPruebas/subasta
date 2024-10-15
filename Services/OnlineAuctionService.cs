using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;

namespace LivestockAuction.Services
{
    public class OnlineAuctionService
    {
        private string _auctionNumber = "A-2023-056";
        private DateTime _auctionDate = new DateTime(2023, 5, 15);
        private List<CurrentBid> _currentBids;
        private List<Purchase> _purchases;
        private LotInfo _currentLotInfo;

        public OnlineAuctionService()
        {
            InitializeData();
        }

        private void InitializeData()
        {
            _currentBids = new List<CurrentBid>
            {
                new CurrentBid { BidderName = "Juan Pérez", BidderNumber = "No-1598", Amount = 5100 },
                new CurrentBid { BidderName = "María González", BidderNumber = "No-2345", Amount = 5200 },
                new CurrentBid { BidderName = "Carlos Rodríguez", BidderNumber = "No-3712", Amount = 5300 },
                new CurrentBid { BidderName = "Ana Martínez", BidderNumber = "No-4089", Amount = 5400 },
                new CurrentBid { BidderName = "Luis Sánchez", BidderNumber = "No-5234", Amount = 5500 }
            };

            _purchases = new List<Purchase>
            {
                new Purchase { Raza = "Angus Negro", Descripcion = "Lote de 10 novillos Angus Negro de alta calidad.", NoCabezas = 10, KilosLote = 4500, PrecioPorKilo = 120.50m },
                new Purchase { Raza = "Hereford", Descripcion = "Lote de 8 vaquillas Hereford para cría.", NoCabezas = 8, KilosLote = 3200, PrecioPorKilo = 115.75m },
                new Purchase { Raza = "Brahman", Descripcion = "Lote de 12 toros Brahman para reproducción.", NoCabezas = 12, KilosLote = 7200, PrecioPorKilo = 130.25m },
                new Purchase { Raza = "Charolais", Descripcion = "Lote de 15 novillos Charolais para engorde.", NoCabezas = 15, KilosLote = 6750, PrecioPorKilo = 118.90m },
                new Purchase { Raza = "Simmental", Descripcion = "Lote de 6 vacas Simmental con cría al pie.", NoCabezas = 6, KilosLote = 3600, PrecioPorKilo = 125.50m }
            };

            foreach (var purchase in _purchases)
            {
                purchase.Total = purchase.KilosLote * purchase.PrecioPorKilo;
            }
            _currentLotInfo = new LotInfo
            {
                Vendedor = "Rancho Los Alamos",
                TipoGanado = "Novillos de engorda",
                Probado = "Sí",
                ConFactura = "Sí",
                Raza = "Angus Negro",
                Cantidad = 10,
                PesoPromedio = 450,
                PrecioSalida = 55000,
                Descripcion = "Lote de 10 novillos Angus Negro de alta calidad"
            };
        }

        public string GetAuctionNumber() => _auctionNumber;
        public DateTime GetAuctionDate() => _auctionDate;
        public List<CurrentBid> GetCurrentBids() => _currentBids;
        public List<Purchase> GetPurchases() => _purchases;

        public void AddBid(string bidderName, string bidderNumber, decimal amount)
        {
            _currentBids.Add(new CurrentBid { BidderName = bidderName, BidderNumber = bidderNumber, Amount = amount });
            _currentBids = _currentBids.OrderByDescending(b => b.Amount).Take(5).ToList();
        }
        public LotInfo GetCurrentLotInfo() => _currentLotInfo;
    }

    public class CurrentBid
    {
        public string BidderName { get; set; }
        public string BidderNumber { get; set; }
        public decimal Amount { get; set; }
    }

    public class Purchase
    {
        public string Raza { get; set; }
        public string Descripcion { get; set; }
        public int NoCabezas { get; set; }
        public int KilosLote { get; set; }
        public decimal PrecioPorKilo { get; set; }
        public decimal Total { get; set; }
    }
    public class LotInfo
    {
        public string Vendedor { get; set; }
        public string TipoGanado { get; set; }
        public string Probado { get; set; }
        public string ConFactura { get; set; }
        public string Raza { get; set; }
        public int Cantidad { get; set; }
        public int PesoPromedio { get; set; }
        public decimal PrecioSalida { get; set; }
        public string Descripcion { get; set; }
    }
}