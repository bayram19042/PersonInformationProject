using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonInformationProject.Entities
{
    public class Product
    {
        public Product()
        {
            var person = new Person();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Destinition { get; set; }
        public Person Person  { get; set; }
        public int PersonId { get; set; }
    }
}
