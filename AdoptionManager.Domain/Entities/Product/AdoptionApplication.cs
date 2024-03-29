﻿using AdoptionManager.Domain.Common;
using AdoptionManager.Domain.Entities.Shipping;
using AdoptionManager.Domain.Entities.Users;

namespace AdoptionManager.Domain.Entities.Product
{
    public enum ApplicationStatus
    {
        ACCEPTED = 1,
        PENDING = 2,
        PROCESSED = 3,
        COMPLETED = 4,
        DECLINED = 5
    }

    public class AdoptionApplication : AuditableEntity
    {
        public int SiteUserId { get; set; }
        public SiteUser SiteUser { get; set; }

        public ApplicationStatus ApplicationStatus { get; set; }

        public int OrganizationId { get; set; }
        public Organization Organization { get; set; }

        public int ShippingId { get; set; }
        public ShippingData Shipping { get; set; }

        public DateTime OrderDate { get; set; }

    }
}
