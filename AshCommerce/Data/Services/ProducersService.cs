using AshCommerce.Data.Base;
using AshCommerce.Models;
using System;

namespace AshCommerce.Data.Services
{
    public class ProducersService : EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(ApplicationDbContext context) : base(context)
        {
        }
    }
}
