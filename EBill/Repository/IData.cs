using EBill.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EBill.Repository
{
    internal interface IData
    {
        void saveBillDetails(BillDetail details);

        void saveBillItems(List<Items> items, SqlConnection con, int id);

        List<BillDetail> GetAllDetail();
    }
}
