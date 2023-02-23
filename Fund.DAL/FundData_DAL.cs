using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Fund.Entity;

namespace Fund.DAL
{
    public class FundData_DAL
    {
        public static List<Fund.Entity.FundData> GetAllFundData() {
            string sqlFundData = "select a.SEDOL,a.NumShares,c.`Price USD` as Price_USD,(a.NumShares)*round(c.`Price USD`,2) as Tol_weight\r\n from funddata a left join identifiers b on a.SEDOL=b.SEDOL left join prices c on b.ID_BPL_MARKET=c.ID_BPL_MARKET ";
            DataTable dt = SQLHelper.ExecuteDataTable(sqlFundData);
            return LoadListFromDataView(dt.DefaultView);
        }

        private static List<FundData> LoadListFromDataView(DataView dv) {
            List<FundData> list = new List<FundData>();
            for (int index = 0; index <= dv.Count - 1; index++) {
                list.Add(GetEntity(dv[index].Row));
            }
            return list;
        
        }

        /// <summary>
        /// 从行中读取数据映射到实体类的属性中
        /// </summary>
        /// <remarks></remarks>
        private static Fund.Entity.FundData GetEntity(DataRow row)
        {
            FundData _obj = new FundData();
            if (!row["SEDOL"].Equals(DBNull.Value))
                _obj.SEDOL1= Convert.ToString(row["SEDOL"]);
            if (!row["NumShares"].Equals(DBNull.Value))
                _obj.NumShares1 = Convert.ToInt32(row["NumShares"]);
            if (!row["Price_USD"].Equals(DBNull.Value))
                _obj.Price_USD1 = Convert.ToDouble(row["Price_USD"]);
            if (!row["Tol_Weight"].Equals(DBNull.Value))
                _obj.Tol_Weight1 = Convert.ToDouble(row["Tol_Weight"]);
            return _obj;
        }

    }
}
