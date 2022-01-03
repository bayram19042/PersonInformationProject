using PersonInformationProject.Contexts;
using PersonInformationProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonInformationProject.UnitOfWork
{
    public class Uow : IUow
    {
        private readonly AppDbContext _context;
        public Uow(AppDbContext context)
        {
            _context = context;
        }
        public async Task Commit()
        {
            await _context.SaveChangesAsync();
        }
    }
}
