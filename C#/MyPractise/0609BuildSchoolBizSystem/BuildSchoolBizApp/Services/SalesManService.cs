using BizDataLibrary.Models;
using BizDataLibrary.Repositories;
using BuildSchoolBizApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildSchoolBizApp.Services
{
    internal class SalesManService
    {
        public OperationResult Create(SalesManViewModel input)
        {
            var result = new OperationResult();
            try
            {
                var repository = new BizRepository(new BizModel());
                var entity = new SalesMan
                { Name=input.Name };
                repository.Create(entity);
                repository.SaveChanges();
                result.IsSuccessful = true;
                //if(fakeProducts.Any(x=>x.PartNo==input.PartNo))
                //{
                //    throw new ArgumentException($"PartNo:{input.PartNo}exists");
                //}
                //else
                //{
                //    fakeProducts.Add(input);
                //    result.IsSuccessful=true;
                //}
            }
            catch (Exception ex)
            {
                result.IsSuccessful = false;
                result.Exception = ex;
            }
            return result;
        }
        public bool IsNameExist(SalesManViewModel input)
        {
            var repository = new BizRepository(new BizModel());
            return repository.GetAll<SalesMan>().Any((x) => x.Name == input.Name);
        }
        public IEnumerable<SalesManViewModel> GetSalesMen()
        {
            var repository = new BizRepository(new BizModel());
            foreach (var item in repository.GetAll<SalesMan>().OrderBy((x) => x.JobNumber))
            {
                yield return new SalesManViewModel()
                {
                    JobNumber = item.JobNumber,
                    Name = item.Name
                };
            }
        }
    }
}
