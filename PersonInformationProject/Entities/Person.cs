using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonInformationProject.Entities
{
    public class Person
    {
        public Person()
        {
            var adress= new List<Adress>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public int Telephone { get; set; }
        public List<Adress> Adresses { get; set; }

    }
}
