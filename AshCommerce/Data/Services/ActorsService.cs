using AshCommerce.Data.Base;
using AshCommerce.Models;
using System;

namespace AshCommerce.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        public ActorsService(ApplicationDbContext context) : base(context) { }
    }
}
