using MediatR;

namespace AdoptionManager.Application.Animals.Commands.DeleteAnimal
{
    public class DeleteAnimalCommand : IRequest
    {
        public int AnimalId { get; set; }
    }
}
