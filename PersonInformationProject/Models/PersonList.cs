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
        public string ProductsName { get; set; }
        public string ProductsDestinition { get; set; }
        public List<string> AdressesContent { get; set; }
        public List<string> AdressesCity { get; set; }
        public List<string> AdressesDistrict { get; set; }
        public List<int> AdressesPostcode { get; set; }




    }
}
