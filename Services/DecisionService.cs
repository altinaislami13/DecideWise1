using System;
using System.Collections.Generic;
using System.Linq;
using DecideWise.Models;
using DecideWise.Data;

namespace DecideWise.Services
{
    public class DecisionService
    {
        private readonly IRepository<Option> _repository;

        public DecisionService(IRepository<Option> repository)
        {
            _repository = repository;
        }

        public Option ChooseBest()
        {
            var options = _repository.GetAll();

            if (options == null || options.Count == 0)
                return null;

            return options.OrderByDescending(o => o.Score).First();
        }

        public void AddScore(int optionId, int value)
        {
            var option = _repository.GetById(optionId);

            if (option == null)
                throw new Exception("Option not found");

            option.Score += value;

            _repository.Save();
        }
    }
}