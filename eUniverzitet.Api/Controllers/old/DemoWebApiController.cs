using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

using eUniverzitet.Data.DAL;
using eUniverzitet.Data.Models;

namespace eUniverzitet.Api.Controllers
{
    public class DemoWebApiController : ApiController
    {
        // GET:  nece raditi jer nema [HttpGet] anotaciju
        public List<Student> Get()
        {
           MojContext ctx = new MojContext();

            List<Student> students = ctx.Students.ToList();
            return students;
        }

        // GET: http://localhost:51880/demowebapi/nesto
        [HttpGet]
        public List<UseriVM> Nesto()
        {
            MojContext ctx = new MojContext();

            var model = ctx.Students
                .Select(a => new UseriVM
                {
                    Ime = a.Korisnik.Ime,
                    Prezime = a.Korisnik.Prezime,
                    DatumRodjenja = a.DatumRodjenja
                }).ToList();

            return model;

        }
        // prirucni VM, koristi se u funkciji Nesto()
        public class UseriVM
        {
            public string Ime { get; set; }
            public string Prezime { get; set; }
            public DateTime DatumRodjenja { get; set; }

        }

    }
}