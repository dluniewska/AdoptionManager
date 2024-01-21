using AdoptionManager.Domain.Entities.Animals;
using AutoMapper;

namespace AdoptionManager.Application.Animals.Queries.GetAnimals
{
    public class AnimalsVm
    {
        public ICollection<AnimalDto> Animals { get; set; } = new List<AnimalDto>();
    }
}
