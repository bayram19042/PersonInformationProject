using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonInformationProject.Interfaces
{
    public interface IRepository<T> where T:class
    {
        Task<List<T>> GetAll();
        Task CreateAsync(T entity);
    }
}
