using AdoptionManager.Application.Animals.Queries.GetAnimalDetails;
using AdoptionManager.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace AdoptionManager.Application.Animals.Queries.GetAnimals
{
    public class GetAnimalsQueryHandler : IRequestHandler<GetAnimalsQuery, AnimalsVm>
    {
        private readonly IAdoptionDbContext _adoptionDbContext;
        public GetAnimalsQueryHandler(IAdoptionDbContext adoptionDbContext)
        {
            _adoptionDbContext = adoptionDbContext;
        }

        public async Task<AnimalsVm> Handle(GetAnimalsQuery request, CancellationToken cancellationToken)
        {
            var animals = await _adoptionDbContext.Animals
                .AsNoTracking()
                .Select(a => new AnimalDto
                {
                    Name = a.Name,
                    Species = a.Species,
                    Breed = a.Breed
                })
                .ToListAsync(cancellationToken);

            var animalVm = new AnimalsVm() { Animals = animals };
            return animalVm;
        }
    }
}
