using Nop.Plugin.Extension.MyPortal.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Plugin.Extension.MyPortal.Service
{
    public partial interface IParcelService
    {
        List<ParcelRecord> GetCustomerParcels(int id);
        int GetCurrentCustomerId();
        List<ParcelRecord> GetCurrentCustomersParcels();
        void CreateNewParcel(string parcelNumber, decimal size);
    }
}
