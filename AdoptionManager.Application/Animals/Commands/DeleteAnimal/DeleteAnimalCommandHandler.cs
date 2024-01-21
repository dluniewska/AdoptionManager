using AdoptionManager.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace AdoptionManager.Application.Animals.Commands.DeleteAnimal
{
    public class DeleteAnimalCommandHandler : IRequestHandler<DeleteAnimalCommand>
    {
        private readonly IAdoptionDbContext _adoptionDbContext;
        public DeleteAnimalCommandHandler(IAdoptionDbContext adoptionDbContext)
        {
            _adoptionDbContext = adoptionDbContext;
        }

        public async Task Handle(DeleteAnimalCommand request, CancellationToken cancellationToken)
        {
            var animal = await _adoptionDbContext.Animals.FirstOrDefaultAsync(a => a.Id == request.AnimalId && a.Status == 0, cancellationToken);
            _adoptionDbContext.Animals.Remove(animal);
            await _adoptionDbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
