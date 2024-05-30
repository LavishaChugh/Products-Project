﻿using Products.Models;

namespace Products.Services.Purchase
{
    public interface IPurchaseService
    {

        public Task<List<Puchase>> GetAll();

        public Task<Puchase> GetById(Guid id);

        public Task<List<Puchase>> Delete(Guid id);

    }
}
