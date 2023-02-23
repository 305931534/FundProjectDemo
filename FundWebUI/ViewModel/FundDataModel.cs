using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FundWebUI.ViewModel
{
    public class FundDataModel
    {
        public DateTime date { get; set; }
        public String SEDOL { get; set; }
        public int NumShares { get; set; }
        public double Price_USD { get; set; }
        public double Tol_Weight { get; set; }
    }
}