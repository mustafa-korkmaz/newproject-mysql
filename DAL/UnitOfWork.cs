using System;
using System.Collections.Generic;
using DAL.Models;

namespace DAL
{
    public class UnitOfWork : IDisposable
    {
        private readonly SporComplexDbContext _context;
        private bool _disposed;
        private Dictionary<string, object> _repositories;

        public UnitOfWork(SporComplexDbContext context)
        {
            _context = context;
        }

        public UnitOfWork()
        {
            _context = new SporComplexDbContext();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        //public void SaveAsync()
        //{
        //    _context.SaveChangesAsync();
        //}

        public virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }

        public IRepository<T> Repository<T>() where T : EntityBase
        {
            if (_repositories == null)
            {
                _repositories = new Dictionary<string, object>();
            }

            var type = typeof(T).Name;

            if (!_repositories.ContainsKey(type))
            {
                var repositoryType = typeof(EntityFrameworkRepository<>);
                var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(T)), _context);
                _repositories.Add(type, repositoryInstance);
            }

            return (IRepository<T>)_repositories[type];
        }
    }
}
