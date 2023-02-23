using FundWebUI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FundWebUI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Default() {
            List<Fund.Entity.FundData> list = Fund.BLL.FundData_BLL.getAllFundData();
            List<FundWebUI.ViewModel.FundDataModel> funddatalist = new List<FundWebUI.ViewModel.FundDataModel>();
            for (int i = 0; i < list.Count; i++) {
                FundDataModel model = new FundDataModel();
                model.NumShares = list[i].NumShares1;
                model.Price_USD = list[i].Price_USD1;
                model.SEDOL = list[i].SEDOL1;
                model.Tol_Weight = list[i].Tol_Weight1;
                funddatalist.Add(model);
            }
            return View(funddatalist);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}