using AdoptionManager.Application.Common.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace AdoptionManager.Application.Animals.Queries.GetAnimals
{
    public class GetAnimalsQueryHandler : IRequestHandler<GetAnimalsQuery, AnimalsVm>
    {
        private readonly IAdoptionDbContext _adoptionDbContext;
        private readonly IMapper _mapper;

        public GetAnimalsQueryHandler(IAdoptionDbContext adoptionDbContext, IMapper mapper)
        {
            _adoptionDbContext = adoptionDbContext;
            _mapper = mapper;
        }

        public async Task<AnimalsVm> Handle(GetAnimalsQuery request, CancellationToken cancellationToken)
        {
            var animals = await _adoptionDbContext.Animals
                .AsNoTracking()
                .ProjectTo<AnimalDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            var animalVm = new AnimalsVm() { Animals = animals };
            return animalVm;
        }
    }
}
