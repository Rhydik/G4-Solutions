using DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public sealed class RepositoryFacade
    {
        private static RepositoryFacade instance = null;
        private static readonly object padlock = new object();

        public KundRepository kundRepository { get; set; }
        public AvdelningPersonalRepository avdelningPersonalRepository { get; set; }
        public AktivitetRepository aktivitetRepository { get; set; }
        public PersonalRepository personalRepository { get; set; }
        public ProduktRepository produktRepository { get; set; }
        public SchablonRepository schablonRepository { get; set; }
        public BehörighetRepository behörighetRepository { get; set; }
        public IntäktsRepository intäktsRepository { get; set; }
        public PrognosRepository prognosRepository { get; set; }
        public BudgeteratResultatRepository budgeteratResultatRepository { get; set; }
        public KostnadsbudgetRepository kostnadsbudgetRepository { get; set; }
        public LåsRepository låsRepository { get; set; }

        private RepositoryFacade()              /*Ny instans av respektive Repository*/
        {
            kundRepository = new KundRepository();
            aktivitetRepository = new AktivitetRepository();
            personalRepository = new PersonalRepository();
            produktRepository = new ProduktRepository();
            schablonRepository = new SchablonRepository();
            behörighetRepository = new BehörighetRepository();
            intäktsRepository = new IntäktsRepository();
            prognosRepository = new PrognosRepository();
            budgeteratResultatRepository = new BudgeteratResultatRepository();
            kostnadsbudgetRepository = new KostnadsbudgetRepository();
            låsRepository = new LåsRepository();
            avdelningPersonalRepository = new AvdelningPersonalRepository();
        }

        public static RepositoryFacade Instance()       /*Låsning*/
        {
            if (instance == null)
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new RepositoryFacade();
                    }
                }
                
            }
            return instance;
        }
    }
}
