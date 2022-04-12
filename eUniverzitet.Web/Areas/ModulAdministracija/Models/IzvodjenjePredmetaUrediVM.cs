﻿using System.Collections.Generic;
using System.Web.Mvc;

namespace eUniverzitet.Web.Areas.ModulAdministracija.Models
{
    public class IzvodjenjePredmetaUrediVM
    {
        public int Id { get; set; }

      
        public int AkademskaGodinaId { get; set; }
        public List<SelectListItem> AkademskeGodineStavke { get; set; }

        public int PredmetId { get; set; }
        public string PredmetNaziv { get; set; }
    }
}