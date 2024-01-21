using MediatR;

namespace AdoptionManager.Application.Animals.Queries.GetAnimalDetails
{
    public class GetAnimalDetailsQuery : IRequest<AnimalDetailsVm>
    {
        public int AnimalId { get; set; }
    }
}
