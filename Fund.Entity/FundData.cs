using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fund.Entity
{
    public class FundData
    {
        private DateTime date;
        private String SEDOL;
        private int NumShares;
        private double Price_USD;
        private double Tol_Weight;

        public DateTime Date { get => date; set => date = value; }
        public string SEDOL1 { get => SEDOL; set => SEDOL = value; }
        public int NumShares1 { get => NumShares; set => NumShares = value; }
        public double Tol_Weight1 { get => Tol_Weight; set => Tol_Weight = value; }
        public double Price_USD1 { get => Price_USD; set => Price_USD = value; }
    }
}
