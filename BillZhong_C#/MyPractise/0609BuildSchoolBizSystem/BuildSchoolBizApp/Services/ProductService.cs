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
        public static List<ProductViewModel> fakeProducts=new List<ProductViewModel>();
        public OperationResult Create(ProductViewModel input)
        {
            var result=new OperationResult();
            try
            {
                if(fakeProducts.Any(x=>x.PartNo==input.PartNo))
                {
                    throw new ArgumentException($"PartNo:{input.PartNo}exists");
                }
                else
                {
                    fakeProducts.Add(input);
                    result.IsSuccessful=true;
                }
            }
            catch(Exception ex)
            {
                result.IsSuccessful=false;
                result.Exception=ex;
            }
            return result;
        }
    }
}
