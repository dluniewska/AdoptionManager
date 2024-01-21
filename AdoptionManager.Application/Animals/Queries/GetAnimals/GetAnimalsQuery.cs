using MediatR;

namespace AdoptionManager.Application.Animals.Queries.GetAnimals
{
    public class GetAnimalsQuery : IRequest<AnimalsVm>
    {
    }
}
