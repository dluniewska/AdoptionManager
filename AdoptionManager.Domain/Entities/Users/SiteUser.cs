﻿using AdoptionManager.Domain.Common;
using AdoptionManager.Domain.Entities.Product;
using AdoptionManager.Domain.Entities.Surveys;
using AdoptionManager.Domain.Entities.Users.Addressess;
using AdoptionManager.Domain.ValueObjects;

namespace AdoptionManager.Domain.Entities.Users
{
    public class SiteUser : AuditableEntity
    {
        public SiteUserName SiteUserName { get; set; }
        public Email Email { get; set; }
        public int Phone { get; set; }
        public List<SiteUserAddress> SiteUserAddresses { get; set; } = new List<SiteUserAddress>();
        public List<AdoptionApplication> AdoptionApplications { get; set; } = new List<AdoptionApplication>();
        public List<UserResponse> UserResponses { get; set; } = new List<UserResponse>();
    }
}
