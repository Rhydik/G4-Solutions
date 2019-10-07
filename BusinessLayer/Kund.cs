using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Kund : DataLayer.Kund
    {
        public Kund(DataLayer.Kund kund)
        {
            KundID = kund.KundID;
            Namn = kund.Namn;
            KundKategori = kund.KundKategori;
            KundKategori_KundKategoriID = kund.KundKategori_KundKategoriID;
        }
    }
}
