using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonInformationProject.Models
{
    public class PersonList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public int Telephone { get; set; }
        public List<string> Content { get; set; }
        public List<string> City { get; set; }
        public List<string> District { get; set; }
        public List<int> Postcode { get; set; }
       

    }
}
