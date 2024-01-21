using AdoptionManager.Application.Common.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace AdoptionManager.Application.Animals.Queries.GetAnimalDetails
{
    public class GetAnimalDetailsQueryHandler : IRequestHandler<GetAnimalDetailsQuery, AnimalDetailsVm>
    {
        private readonly IAdoptionDbContext _adoptionDbContext;
        private readonly IMapper _mapper;
        public GetAnimalDetailsQueryHandler(IAdoptionDbContext adoptionDbContext, IMapper mapper)
        {
            _adoptionDbContext = adoptionDbContext;
            _mapper = mapper;
        }

        public async Task<AnimalDetailsVm> Handle(GetAnimalDetailsQuery request, CancellationToken cancellationToken)
        {
            var animal = await _adoptionDbContext.Animals
                .Where(a => a.Id == request.AnimalId && a.Status == 0)
                .ProjectTo<AnimalDetailsVm>(_mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(cancellationToken);
            return animal;
        }
    }
}
