using System.Collections.Generic;
using eUniverzitet.Data.DAL;

namespace eUniverzitet.Data.Models
{
    public enum KorisnickaUloga
    {
        SuperAdministrator,
        AdministratorInstitucije,
        Edukator,
        StudentskaSluzba,
        RadnikOpste,
        Rektor,
        ProrektorZaNastavu,
        ProrektorNIR,
        Dekan,
        ProdekanNastava,
        ProdekanNIR,
        DirektorInstituta,
        BezPrivilegije
    }
    public class Zaposlenik:IEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public int KorisnikId { get; set; }
        // Marking property as 'virtual' is necessary for lazy loading.
        // Lazy loading is a nice feature of many ORMs because it allows you to dynamically access related data from a model. It will not
        // unnecessarily fetch the data until it is actually accessed, thus reducing the up-front querying of data from the database.
        public virtual Korisnik Korisnik { get; set; }
        public virtual List<Zaposlenje> Zaposlenja { get; set; }
    }
}