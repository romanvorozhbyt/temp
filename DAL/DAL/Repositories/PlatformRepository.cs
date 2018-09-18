using DAL.Abstarction;
using DAL.EF;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories
{
    class PlatformRepository : IPlatformRepository
    {
        private readonly GameStoreContext _db;
        private readonly DbSet<PlatformType> _dbSet;

        public PlatformRepository(GameStoreContext context)
        {
            _db = context;
            _dbSet = context.Set<PlatformType>();
        }
    }
}
