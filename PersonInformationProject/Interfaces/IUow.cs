using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonInformationProject.Interfaces
{
    public  interface IUow
    {
        
        
        Task Commit();
    }
}
