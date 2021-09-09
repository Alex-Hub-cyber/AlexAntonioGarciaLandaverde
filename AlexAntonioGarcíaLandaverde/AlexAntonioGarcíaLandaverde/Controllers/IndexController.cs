using AlexAntonioGarcíaLandaverde.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlexAntonioGarcíaLandaverde.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {

            ClsSimuladorAutomatico Monto = new ClsSimuladorAutomatico() ;


            
            int Multiplo;
            int Divisible;
            int v = 5;
            int c = 5;

            Multiplo = v * c;

            Divisible = v / c;


            return View(Monto);



        }

        public ActionResult Error()
        {
            return View();
        }

        public ActionResult MontoRetirar()
        {
            return View();
        }
    }


    
}