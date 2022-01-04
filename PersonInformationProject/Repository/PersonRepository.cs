using Microsoft.EntityFrameworkCore;
using PersonInformationProject.Contexts;
using PersonInformationProject.Entities;
using PersonInformationProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonInformationProject.Repository
{
    public class PersonRepository : GenericRepository<Person>, IPersonRepository
    {
        private readonly AppDbContext _context;
        public PersonRepository(AppDbContext context):base(context)
        {
            _context = context;
        }
        public async Task<Person> GetAllWithAdress(int personId)
        {
            return await _context.Persons.Include(x => x.Adresses).SingleOrDefaultAsync(x => x.Id == personId);
        }

        public async Task<List<Person>> GetAllWithAdress()
        {
            return await _context.Persons.Include(x => x.Adresses)
                .Include(x=>x.Products)
                .AsNoTracking().ToListAsync();
        }



    }
}
