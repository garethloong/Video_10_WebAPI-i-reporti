﻿using System.Collections.Generic;
using System.Web.Mvc;
using eUniverzitet.Data.Models;

namespace eUniverzitet.Web.Areas.ModulAdministracija.Models
{
    public class AngaziranNaPredmetuUrediVM
    {
        public int Id { get; set; }

        public int? NastavnoOsobljeId { get; set; }
        public List<SelectListItem> NastavnoOsobljeStavke { get; set; }


        public AngaziranNaPredmetTip? AngaziranNaPredmetTip { get; set; }
        public List<SelectListItem> AngaziranNaPredmetTipStavke { get; set; }


        public int IzvodjenjePredmetaId { get; set; }
    }
}