namespace AdoptionManager.Domain.Entities
{
    enum ApplicationStatuses
    {
        ACCEPTED = 1,
        PENDING = 2,
        PROCESSED = 3,
        COMPLETED = 4,
        DECLINED = 5
    }

    public class ApplicationStatus
    {
        public int ApplicationStatusId { get; set; }
        public string Status { get; set; }
    }
}
