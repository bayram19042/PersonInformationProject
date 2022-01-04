using AutoMapper;
using FluentValidation;
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
    { // test

        private readonly IValidator<Person> _validator;
        private readonly IMapper _mapper;
        private readonly IRepository<Person> _repository;
        private readonly IPersonRepository _personRepository;
        private readonly IUow _uow;
        public HomeController(IPersonRepository personRepository, IUow uow, IRepository<Person> repository, IMapper mapper, IValidator<Person> validator)
        {
            _repository = repository;
            _personRepository = personRepository;
            _uow = uow;
            _mapper = mapper;
            _validator = validator;
        }

        public async Task<IActionResult> Index()
        {
         

             var list = await _personRepository.GetAllWithAdress();
            var dto = _mapper.Map<List<PersonList>>(list);

            return View(dto);

        }

        public IActionResult Create()
        {


            return View(new Person());

        }

        [HttpPost]
        public async Task<IActionResult> Create(Person person)
        {
            var validate = _validator.Validate(person);
            if (validate.IsValid)
            {
                await _personRepository.CreateAsync(person);
                await _uow.Commit();
                return RedirectToAction("Index");
            }
            else
            {
                return View(person);
            }


        }

    }
}
