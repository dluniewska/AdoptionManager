using AdoptionManager.Application.Common.Mappings;
using AdoptionManager.Domain.Entities.Animals;
using AutoMapper;

namespace AdoptionManager.Application.Animals.Queries.GetAnimals
{
    public class AnimalDto : IMapFrom<Animal>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public string? Breed { get; set; }


        public void Mapping(Profile profile)
        {
            profile.CreateMap<Animal, AnimalDto>();
        }
    }
}
