using PersonInformationProject.Entities;
using PersonInformationProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonInformationProject.Interfaces
{
    public interface IPersonRepository:IRepository<Person>
    {
        Task<Person> GetAllWithAdress(int personId);
        Task<List<Person>> GetAllWithAdress();
    }
}
