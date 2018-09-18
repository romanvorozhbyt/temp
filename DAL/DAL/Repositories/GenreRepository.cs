using System;
using System.Collections.Generic;
using DAL.Abstarction;
using System.Text;
using DAL.Models;
using DAL.EF;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    class GenreRepository : IGenreRepository
    {
        private readonly GameStoreContext _db;
        private readonly DbSet<Genre> _dbSet;

        public GenreRepository(GameStoreContext context)
        {
            _db = context;
            _dbSet = context.Set<Genre>();
        }
    }
}
