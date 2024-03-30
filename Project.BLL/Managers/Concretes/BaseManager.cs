using Project.BLL.Managers.Abstracts;
using Project.DAL.Repositories.Abstracts;
using Project.ENTITIES.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.Managers.Concretes
{
    public class BaseManager<T> : IManager<T> where T : class, IEntity
    {
        protected readonly IRepository<T> _iRep;

        //Todo : BaseManager imp edilip bırakıldı..

        public BaseManager(IRepository<T> iRep)
        {
            _iRep = iRep;
        }
        public string Add(T item)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(T item)
        {
            throw new NotImplementedException();
        }

        public string AddRange(List<T> list)
        {
            throw new NotImplementedException();
        }

        public Task<string> AddRangeAsync(List<T> list)
        {
            throw new NotImplementedException();
        }

        public bool Any(Expression<Func<T, bool>> exp)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AnyAsync(Expression<Func<T, bool>> exp)
        {
            throw new NotImplementedException();
        }

        public void Delete(T item)
        {
            throw new NotImplementedException();
        }

        public void DeleteRange(List<T> list)
        {
            throw new NotImplementedException();
        }

        public string Destroy(T item)
        {
            throw new NotImplementedException();
        }

        public string DestroyRange(List<T> list)
        {
            throw new NotImplementedException();
        }

        public List<string> DestroyRangeWithText(List<T> list)
        {
            throw new NotImplementedException();
        }

        public Task<T> FindAsync(int id)
        {
            throw new NotImplementedException();
        }

        public T FirstOrDefault(Expression<Func<T, bool>> exp)
        {
            throw new NotImplementedException();
        }

        public Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> exp)
        {
            throw new NotImplementedException();
        }

        public List<T> GetActives()
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> GetActivesAsync()
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<T> GetFirstDatas(int count)
        {
            throw new NotImplementedException();
        }

        public List<T> GetLastDatas(int count)
        {
            throw new NotImplementedException();
        }

        public List<T> GetModifieds()
        {
            throw new NotImplementedException();
        }

        public List<T> GetPassives()
        {
            throw new NotImplementedException();
        }

        public object Select(Expression<Func<T, object>> exp)
        {
            throw new NotImplementedException();
        }

        public IQueryable<X> Select<X>(Expression<Func<T, X>> exp)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T item)
        {
            throw new NotImplementedException();
        }

        public Task UpdateRangeAsync(List<T> list)
        {
            throw new NotImplementedException();
        }

        public List<T> Where(Expression<Func<T, bool>> exp)
        {
            throw new NotImplementedException();
        }
    }
}
