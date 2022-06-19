using BizDataLibrary.Models;
using BizDataLibrary.Repositories;
using BuildSchoolBizApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildSchoolBizApp.Services
{
    internal class SellingService
    {
        private Selling CreateSelling(BizRepository repository, SellingViewModel input)
        {
            Selling entity = new Selling()
            {
                PartNo = input.PartNo,
                Quantity = input.Quantity,
                SalesJobNumber = input.SalesJobNumber,
                SellingDay = input.SellingDay,
                UnitPrice = input.UnitPrice
            };
            repository.Create(entity);
            // 要先 SaveChanges 才能拿到新的 Selling.SellingId
            repository.SaveChanges();
            return entity;
        }
        private void CreateSellingSource(BizRepository repository, int sellingId,int procurementId, int sellCount)
        {
            SellingSource sellingSource = new SellingSource()
            {
                ProcurementId = procurementId,
                SellingId = sellingId,
                Quantity = sellCount
            };
            repository.Create(sellingSource);
        }
        private void ComputeInvetory(BizRepository repository, SellingViewModel input)
        {
            Selling entity = CreateSelling(repository, input);
            var sellCount = input.Quantity;
            var products = repository.GetAll<Procurement>()
            .Where((x) => x.PartNo == input.PartNo && x.InvetoryQuantity > 0)
            .OrderBy((x) => x.PurchasingDay);
            foreach (var p in products)
            {
                if (sellCount <= 0)
                {
                    break;
                }
                else
                {
                    //throw new Exception("test");
                    if (p.InvetoryQuantity >= sellCount)
                    {
                        p.InvetoryQuantity = p.InvetoryQuantity - sellCount;
                        CreateSellingSource(repository, entity.SellingId, p.ProcurementId, sellCount);
                        sellCount = 0;
                    }
                    else
                    {
                        sellCount = sellCount - p.InvetoryQuantity;
                        CreateSellingSource(repository, entity.SellingId, p.ProcurementId, p.InvetoryQuantity);
                        p.InvetoryQuantity = 0;
                    }
                }
            }
        }
        public OperationResult Create(SellingViewModel input)
        {
            var result = new OperationResult();
            DbContext context = new BizModel();
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    var repository = new BizRepository(context);
                    ComputeInvetory(repository, input);
                    repository.SaveChanges();
                    result.IsSuccessful = true;
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    result.IsSuccessful = false;
                    result.Exception = ex;
                    transaction.Rollback();
                }
            }
            return result;
        }
        public IEnumerable<SellingQueryViewModel> GetSellingBySalesAndDay(int jobNumber, DateTime begin, DateTime end)
        {
            var repository = new BizRepository(new BizModel());
            return from selling in repository.GetAll<Selling>()
                   join sales in repository.GetAll<SalesMan>()
                   on selling.SalesJobNumber equals sales.JobNumber
                   where selling.SalesJobNumber == jobNumber
                   && selling.SellingDay >= begin
                   && selling.SellingDay < end
                   select new SellingQueryViewModel
                   {
                       PartNo = selling.PartNo,
                       Quantity = selling.Quantity,
                       SalesJobNumber = selling.SalesJobNumber,
                       SalesName = sales.Name,
                       SellingDay = selling.SellingDay,
                       SellingId = selling.SellingId,
                       UnitPrice = selling.UnitPrice,
                       TotalPrice = selling.UnitPrice * selling.Quantity
                   };
        }
    }
}
