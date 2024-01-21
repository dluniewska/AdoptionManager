using MediatR;

namespace AdoptionManager.Application.Animals.Commands.CreateAnimal
{
    public class CreateAnimalCommand : IRequest<int>
    {
        public string Name { get; set; }
        public DateOnly? BirthDate { get; set; }
        public DateOnly? DateOfArrival { get; set; }
        public string Species { get; set; }
        public string? Breed { get; set; }
        public string? HealthStatus { get; set; }
    }
}
