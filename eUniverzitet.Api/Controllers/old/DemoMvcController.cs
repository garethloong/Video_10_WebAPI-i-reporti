using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eUniverzitet.Data.DAL;
using eUniverzitet.Data.Models;

namespace eUniverzitet.Api.Controllers
{
    public class DemoMvcController : Controller
    {
        // GET: http://localhost:51880/demomvc
        public ActionResult Index()
        {

            MojContext ctx = new MojContext();
            //List<Student> podaci = ctx.Students.ToList();
            //return Json(podaci, JsonRequestBehavior.AllowGet);

            return this.Json(from obj in ctx.Students select new { Ime = obj.Korisnik.Ime, Prezime = obj.Korisnik.Prezime, DatumRodjenja = obj.DatumRodjenja }, JsonRequestBehavior.AllowGet);
        }
    }
}