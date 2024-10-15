using System.Collections.Generic;

namespace LivestockAuction.Services
{
    public class AnimalRegistrationService
    {
        private List<Animal> _registrations = new List<Animal>();

        public void RegisterAnimal(Animal animal)
        {
            _registrations.Add(animal);
        }

        public List<Animal> GetRegisteredAnimals() => _registrations;
    }

    public class Animal
    {
        public string AuctionDate { get; set; }
        public string AnimalType { get; set; }
        public string Breed { get; set; }
        public string AgeSex { get; set; }
        public decimal Weight { get; set; }
        public bool IsTested { get; set; }
        public bool HasInvoice { get; set; }
    }
}