using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class RepositoryFacade
    {
        public KundRepository kundRepository { get; set; }
        public AktivitetRepository aktivitetRepository { get; set; }
        public PersonalRepository personalRepository { get; set; }
        public ProduktRepository produktRepository { get; set; }
        public SchablonRepository schablonRepository { get; set; }

        public RepositoryFacade()
        {
            kundRepository = new KundRepository();
            aktivitetRepository = new AktivitetRepository();
            personalRepository = new PersonalRepository();
            produktRepository = new ProduktRepository();
            schablonRepository = new SchablonRepository();
        }
    }
}
