using AshCommerce.Data.Base;
using AshCommerce.Models;
using System;

namespace AshCommerce.Data.Services
{
    public class CinemasService : EntityBaseRepository<Cinema>, ICinemasService
    {
        public CinemasService(ApplicationDbContext context) : base(context)
        {
        }
    }
}
