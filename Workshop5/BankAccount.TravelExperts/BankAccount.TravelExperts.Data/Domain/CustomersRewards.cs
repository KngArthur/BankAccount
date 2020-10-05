﻿using System;
using System.Collections.Generic;

namespace BankAccount.TravelExperts.Data.Domain
{
    public partial class CustomersRewards
    {
        public int CustomerId { get; set; }
        public int RewardId { get; set; }
        public string RwdNumber { get; set; }

        public virtual Customers Customer { get; set; }
        public virtual Rewards Reward { get; set; }
    }
}
