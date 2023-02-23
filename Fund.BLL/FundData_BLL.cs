using Fund.DAL;
using Fund.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fund.BLL
{
    public class FundData_BLL
    {
        /// <summary>
        /// get all fundData
        /// </summary>
        /// <returns></returns>
        public static List<FundData> getAllFundData() {
            return FundData_DAL.GetAllFundData();
        }
    }
}
