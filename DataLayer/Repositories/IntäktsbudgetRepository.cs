using DataLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class IntäktsbudgetRepository
    {
        public void AddNewIntäktsbudget(int kundid, int prognosid, int intäktsbudgetID, bool låst, decimal avtal, bool gradA, decimal tillägg, bool gradT, decimal budget, int tim, string kommentar )
        {
            using (var db = new DataContext())
            {
                var hämtakund  = (from x in db.Intäktsbudget
                                       where x.Kund_KundID == kundid
                                       select x).FirstOrDefault();

                var hämtaprognos = (from x in db.Intäktsbudget
                                    where x.Prognos_PrognosID == prognosid
                                    select x).FirstOrDefault();

                var intäktsbudget = new Intäktsbudget {IntäktsbudgetID = intäktsbudgetID, Prognos_PrognosID = prognosid, Låst = låst, Avtal = avtal, GradA = gradA, Tillägg = tillägg, GradT = gradT, Budget = budget, Tim = tim, Kommentar = kommentar};

                db.Intäktsbudget.Add(intäktsbudget);

                db.SaveChanges();
            }
        }
    }
}
