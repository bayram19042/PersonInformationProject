using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PersonInformationProject.Entities;
using PersonInformationProject.Interfaces;
using PersonInformationProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonInformationProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Person> _repository;
        private readonly IPersonRepository _personRepository;
        private readonly IUow _uow;
        public HomeController(IPersonRepository personRepository, IUow uow, IRepository<Person> repository, IMapper mapper)
        {
            _repository = repository;
            _personRepository = personRepository;
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var list = _mapper.Map<PersonList>(await _personRepository.GetAllWithAdress());
            return View(list);
        }
    }
}
