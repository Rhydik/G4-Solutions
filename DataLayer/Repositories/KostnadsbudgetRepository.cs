﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class KostnadsbudgetRepository
    {
        public List<KonstnadsbudgetPersonalDTO> GetKostnadsbudgetPersonal()
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Personal
                            select new KonstnadsbudgetPersonalDTO { Namn = x.Namn, Sysselsättningsgrad = x.Sysselsättningsgrad, Vakansavdrag = x.Vakansavdrag, Årsarbetare = x.Sysselsättningsgrad - x.Vakansavdrag };

                return query.ToList();
            }
        }

        public List<KostnadsbudgetProduktDTO> GetKostnadsbudgetProdukt()
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Produkt
                            select new KostnadsbudgetProduktDTO { Produkt = x.Namn, ProduktID = x.ProduktID, Avdelning_AvdelningID = x.Avdelning_AvdelningID };

                return query.ToList();
            }

        }


        /// <summary>
        /// I kalkyleringen skall vi genomföra algoritmen för att räkna ut de följande värdena : andel,diff, totalt etc...
        /// Kolla gärna KostnadsBudgetPersonalDTO samt prototyp/dokumentation för vidare förklaring av vad variablerna står för.
        /// 
        /// </summary>
        /// <param name="personals"></param>
        /// <returns></returns>
        public List<KonstnadsbudgetPersonalDTO> Kalkylering(List<KonstnadsbudgetPersonalDTO> personals)
        {
            foreach (var item in personals)
            {

                //vi ska uppdatera logiken här, detta är bara tillfälligt
                item.Vakansavdrag = 100 - item.Årsarbetare; //100% - hur mkt de jobbat = hur mycket de behöver i vakans
                item.Andel = 0;
                item.Diff = 0;
                item.Totalt = 0;
                item.GemAdm = 0;
                item.Fpp = 0;
            }
            return personals;

        }

        public List<DTO.KostnadsbudgetKontoDTO> GetAllKonton()
        {
            using (var db = new DataContext())
            {
                var query = from x in db.Konto
                            select new DTO.KostnadsbudgetKontoDTO {Benämning = x.Benämning , Konto = x.konto1, KontoID = x.KontoID };
                        return query.ToList();
            }
        }
    }
}
