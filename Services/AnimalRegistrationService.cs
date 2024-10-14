using System.Collections.Generic;

namespace LivestockAuction.Services
{
    public class AnimalRegistrationService
    {
        private List<AnimalRegistration> _registrations = new List<AnimalRegistration>();

        public void RegisterAnimal(Animal animal)
        {
            _registrations.Add(new AnimalRegistration { SellerName = "Unknown", Animal = animal });
        }

        public void RegisterAnimals(string sellerName, List<Animal> animals)
        {
            foreach (var animal in animals)
            {
                _registrations.Add(new AnimalRegistration { SellerName = sellerName, Animal = animal });
            }
        }

        public List<AnimalRegistration> GetRegisteredAnimals() => _registrations;
    }

    public class AnimalRegistration
    {
        public string SellerName { get; set; }
        public Animal Animal { get; set; }
    }

    public class Animal
    {
        public string AnimalType { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }
        public decimal Weight { get; set; }
        public string HealthCondition { get; set; }
        public decimal BasePrice { get; set; }
    }
}