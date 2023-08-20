using AdoptionManager.Application.Common.Interfaces;

namespace AdoptionManager.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime UtcNow => DateTime.UtcNow;
    }
}
