using Nop.Core;
using Nop.Core.Data;
using Nop.Core.Domain.Customers;
using Nop.Plugin.Extension.MyPortal.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Plugin.Extension.MyPortal.Service
{
    public class ParcelService : IParcelService
    {
        private IRepository<ParcelRecord> _repo;
        private IWorkContext _workContext;

        public ParcelService(IRepository<ParcelRecord> repo, IWorkContext workContext)
        {
            _repo = repo;
            _workContext = workContext;
        }

        public List<ParcelRecord> GetCustomerParcels(int id)
        {
            var query = _repo.TableNoTracking;
            return query.Where(p => p.CustomerId.Equals(id)).ToList();
        }

        public int GetCurrentCustomerId()
        {
            return _workContext.CurrentCustomer.Id;
        }

        private Customer GetCurrentCustomer()
        {
            return _workContext.CurrentCustomer;
        }

        public List<ParcelRecord> GetCurrentCustomersParcels()
        {
            return GetCustomerParcels(GetCurrentCustomerId());
        }

        public void CreateNewParcel(string parcelNumber, decimal size)
        {
            var customer = GetCurrentCustomer();
            var obj = new ParcelRecord { ParcelNumber = parcelNumber, Size = size, CustomerId = customer.Id };
            _repo.Insert(obj);
        }
    }
}
