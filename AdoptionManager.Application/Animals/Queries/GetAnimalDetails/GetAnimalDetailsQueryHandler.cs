using AdoptionManager.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace AdoptionManager.Application.Animals.Queries.GetAnimalDetails
{
    public class GetAnimalDetailsQueryHandler : IRequestHandler<GetAnimalDetailsQuery, AnimalDetailsVm>
    {
        private readonly IAdoptionDbContext _adoptionDbContext;
        public GetAnimalDetailsQueryHandler(IAdoptionDbContext adoptionDbContext)
        {
            _adoptionDbContext = adoptionDbContext;
        }

        public async Task<AnimalDetailsVm> Handle(GetAnimalDetailsQuery request, CancellationToken cancellationToken)
        {
            var animal = await _adoptionDbContext.Animals
                .Where(a => a.Id == request.AnimalId)
                .Select(a => new AnimalDetailsVm
                {
                    Name = a.Name,
                    Species = a.Species,
                    Breed = a.Breed,
                    BirthDate = a.BirthDate,
                    DateOfArrival = a.DateOfArrival,
                    HealthStatus = a.HealthStatus,
                    Created = a.Created,
                    Modified = a.Modified
                })
                .FirstOrDefaultAsync(cancellationToken);
            return animal;
        }
    }
}
