﻿namespace AdoptionManager.Domain.Common
{
    public class AuditableEntity
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Created { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? Modified { get; set; }
        public int Status { get; set; }
        public string? InactivatedBy { get; set; }
        public DateTime? Inactivated { get; set; }
    }
}
