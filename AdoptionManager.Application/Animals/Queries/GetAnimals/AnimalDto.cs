using AdoptionManager.Domain.Entities.Animals;
using AutoMapper;

namespace AdoptionManager.Application.Animals.Queries.GetAnimals
{
    public class AnimalDto
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public string? Breed { get; set; }


        public void Mapping(Profile profile)
        {
            profile.CreateMap<Animal, AnimalDto>();
        }
    }
}
