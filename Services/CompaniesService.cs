using System;
using System.Collections.Generic;
using contracted2.Models;
using contracted2.Repositories;

namespace contracted2.Services
{
    public class CompaniesService
    {
        private readonly CompaniesRepository _repo;

        public CompaniesService(CompaniesRepository repo)
        {
            _repo = repo;
        }
        internal List<Companies> Get()
        {
            List<Companies> companies = _repo.GetAll();
            return companies;
        }
    }
}