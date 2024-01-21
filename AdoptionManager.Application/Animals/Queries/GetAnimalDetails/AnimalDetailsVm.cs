using AdoptionManager.Application.Common.Mappings;
using AdoptionManager.Domain.Entities.Animals;
using AutoMapper;

namespace AdoptionManager.Application.Animals.Queries.GetAnimalDetails
{
    public class AnimalDetailsVm : IMapFrom<Animal>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateOnly? BirthDate { get; set; }
        public DateOnly? DateOfArrival { get; set; }
        public string Species { get; set; }
        public string? Breed { get; set; }
        public string? HealthStatus { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Modified { get; set; }


        public void Mapping(Profile profile)
        {
            profile.CreateMap<Animal, AnimalDetailsVm>();
        }
    }
}
