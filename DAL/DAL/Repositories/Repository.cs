﻿using DAL.Abstarction;
using DAL.EF;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    class Repository<T> : IRepository<T>, IDisposable, IDisposableFromUoW where T : Entity
    {
        private readonly GameStoreContext _db;
        private readonly DbSet<T> _dbSet;
        public Repository(GameStoreContext context)
        {
            _db = context;
            _dbSet = context.Set<T>();
        }

        public void Delete(int id)
        {
            var item = _dbSet.Find(id);
            if (item != null)
                _dbSet.Remove(item);
        }
       
        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public void Insert(T item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            if (_dbSet.Find(item.Id) == null)
                _dbSet.Add(item);
        }

        public async Task InsertAsync(T item)
        {     //add brackets
            //style code
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            if (await _dbSet.FindAsync(item.Id) == null)
            {
                await _dbSet.AddAsync(item);
            }
        }

        public void Update(T item)
        {
            var itemToModify = _dbSet.Find(item.Id);
            if (itemToModify == null)
                throw new ArgumentException(nameof(item));
            _db.Entry(itemToModify).CurrentValues.SetValues(item);
            _db.Entry(itemToModify).State = EntityState.Modified;
        }

        public async Task UpdateAsynk(T item)
        {
            var itemToModify = await _dbSet.FindAsync(item.Id);
            if (itemToModify == null)
                throw new ArgumentException(nameof(item));
            _db.Entry(itemToModify).CurrentValues.SetValues(item);
            _db.Entry(itemToModify).State = EntityState.Modified;
        }
        private bool _disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _db.Dispose();
                }           
            }
            this._disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        public void DispousedFromUoW()
        {
            Dispose(false);
        }
    }

    internal interface IDisposableFromUoW
    {
        void DispousedFromUoW();
    }
}
