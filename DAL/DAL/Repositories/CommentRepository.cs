using System;
using System.Collections.Generic;
using System.Text;
using DAL.Abstarction;
using DAL.EF;
using Microsoft.EntityFrameworkCore;
using DAL.Models;

namespace DAL.Repositories
{
    class CommentRepository : ICommentRepository
    {
        private readonly GameStoreContext _db;
        private readonly DbSet<Comment> _dbSet;

        public CommentRepository(GameStoreContext context)
        {
            _db = context;
            _dbSet = context.Set<Comment>();
        }
    }
}
