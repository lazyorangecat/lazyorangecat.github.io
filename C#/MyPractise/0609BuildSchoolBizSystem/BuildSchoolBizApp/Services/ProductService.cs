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
    internal class ProductService
    {
        //public static List<ProductViewModel> fakeProducts=new List<ProductViewModel>();
        public OperationResult Create(ProductViewModel input)
        {
            var result=new OperationResult();
            try
            {
                var repository = new BizRepository(new BizModel());
                var entity = new Product
                { PartNo=input.PartNo,PartName=input.PartName};
                repository.Create(entity);
                repository.SaveChanges();
                result.IsSuccessful=true;
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
            catch(Exception ex)
            {
                result.IsSuccessful=false;
                result.Exception=ex;
            }
            return result;
        }
        public IEnumerable<ProductViewModel> GetProducts()
        {
            var repository = new BizRepository(new BizModel());
            foreach (var item in repository.GetAll<Product>().OrderBy((x) => x.PartNo))
            {
                yield return new ProductViewModel()
                {
                    PartNo = item.PartNo,
                    PartName = item.PartName
                };
            }
        }
    }
}
