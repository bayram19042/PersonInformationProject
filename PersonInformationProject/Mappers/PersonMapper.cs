using AutoMapper;
using PersonInformationProject.Entities;
using PersonInformationProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonInformationProject.Mappers
{
    public class PersonMapper:Profile
    {
        public PersonMapper()
        {
            CreateMap<Adress, PersonList>();
            CreateMap<Person, PersonList>().IncludeMembers(x=>x.Adresses);
            
        }
    }
}
