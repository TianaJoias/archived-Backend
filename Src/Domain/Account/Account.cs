﻿using System.Collections.Generic;

namespace Domain.Account
{
    public class Account : BaseEntity
    {
        public IEnumerable<Roles> Roles { get; set; }
        public IEnumerable<IdentityProvider> ExternalProviders { get; set; }
        public User User { get; set; }
    }
}