﻿using DataAccess.Core.Domain;

namespace DataAccess.Core.Repositories
{
    public interface IPaymentMethodRepository : IRepository<PaymentMethod>
    {
        PaymentMethod Get(string PaymentName);
    }
}
