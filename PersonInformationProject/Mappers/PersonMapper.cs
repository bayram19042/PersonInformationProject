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
            CreateMap<Person, PersonList>()
                .ForMember(x => x.AdressesContent, opt => opt.MapFrom(x => x.Adresses.Select(x => x.Content)))
                .ForMember(x=>x.AdressesCity, opt=>opt.MapFrom(x=>x.Adresses.Select(x=>x.City)))
                .ForMember(x => x.AdressesDistrict, opt => opt.MapFrom(x => x.Adresses.Select(x => x.District)))
                .ForMember(x => x.AdressesPostcode, opt => opt.MapFrom(x => x.Adresses.Select(x => x.Postcode)))
                ;
            
            
        }
    }
}
