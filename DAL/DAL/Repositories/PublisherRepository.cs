using DAL.Abstarction;
using DAL.EF;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories
{
    class PublisherRepository : IPublisherRepository
    {
        private readonly GameStoreContext _db;
        private readonly DbSet<Publisher> _dbSet;

        public PublisherRepository(GameStoreContext context)
        {
            _db = context;
            _dbSet = context.Set<Publisher>();
        }
    }
}
