using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonInformationProject.Entities
{
    public class Adress
    {
        public Adress()
        {
            var person = new Person();
        }
        public int Id { get; set; }
        public string Content { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public int Postcode { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}
