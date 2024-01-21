using AdoptionManager.Application.Common.Interfaces;
using AdoptionManager.Domain.Entities.Animals;
using MediatR;

namespace AdoptionManager.Application.Animals.Commands.CreateAnimal
{
    public class CreateAnimalCommandHandler : IRequestHandler<CreateAnimalCommand, int>
    {
        private readonly IAdoptionDbContext _adoptionDbContext;
        public CreateAnimalCommandHandler(IAdoptionDbContext adoptionDbContext)
        {
            _adoptionDbContext = adoptionDbContext;
        }

        public async Task<int> Handle(CreateAnimalCommand request, CancellationToken cancellationToken)
        {
            var animal = new Animal()
            {
                Name = request.Name,
                Breed = request.Breed,
                HealthStatus = request.HealthStatus,
                Species = request.Species,
                BirthDate = request.BirthDate,
                DateOfArrival = request.DateOfArrival
            };

            await _adoptionDbContext.Animals.AddAsync(animal);
            await _adoptionDbContext.SaveChangesAsync(cancellationToken);

            return animal.Id;
        }
    }
}
