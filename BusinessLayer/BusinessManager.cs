using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using DataLayer.DTO;
using Excel = Microsoft.Office.Interop.Excel;

namespace BusinessLayer
{
    public class BusinessManager
    {
        RepositoryFacade repositoryFacade = RepositoryFacade.Instance();

        //Personal
        public Personal Login(string användarnamn, string lösenord)
        {
            return repositoryFacade.personalRepository.Login(användarnamn, lösenord);
        }

        public List<PlaceringsDTO> GetAllAvdelningarFördelning()
        {
            return repositoryFacade.personalRepository.GetAllAVdelningarFördelning();
        }

        //Kunder
        public List<KundDTO> GetAllKunder()
        {
            //repositoryFacade.kundRepository.AddKund();   för testning//Leo
            return repositoryFacade.kundRepository.GetAllKunder();
        }

        public void LäggTillPlaceringAktivitet(int pers, string aktivitet, string andel)
        {
            repositoryFacade.kostnadsbudgetRepository.LäggTillPlaceringAktivitet(pers, aktivitet, andel);
        }

        public List<DirektkostnadProduktDTO> GetAllDirektKostnadProdukt()
        {
            return repositoryFacade.kostnadsbudgetRepository.GetAllDirektKostnadProdukt();
        }

        public List<DirektkostnadAktivitetDTO> GetAllDirektKostnadAktivitet()
        {
            return repositoryFacade.kostnadsbudgetRepository.GetAllDirektkostnadAktivitet();
        }

        public List<PersonalAktivitetDTO> GetAllPersonalAktivitet()
        {
            return repositoryFacade.kostnadsbudgetRepository.GetAllPersonalAktivitet();
        }

        public void AddDirektkostnadProdukt(string prod, string konto, string belopp)
        {
            repositoryFacade.kostnadsbudgetRepository.AddDirektkostnadProdukt(prod, konto, belopp);
        }

        public void RemoveDirektKostnadAktivitet(DirektkostnadAktivitetDTO direktkostnad)
        {
            repositoryFacade.kostnadsbudgetRepository.RemoveDirektKostnadAktivitet(direktkostnad);
        }

        public void RemoveDirektKostnadProdukt(DirektkostnadProduktDTO direktkostnad)
        {
            repositoryFacade.kostnadsbudgetRepository.RemoveDirektKostnadProdukt(direktkostnad);
        }

        public List<KonstnadsbudgetPersonalDTO> GetPersonalByAvdelning(string avdelning)
        {
            return repositoryFacade.personalRepository.GetPersonalByAvdelning(avdelning);
        }

        public void AddDirektkostnadAktivitet(string akti, string konto, string belopp)
        {
            repositoryFacade.kostnadsbudgetRepository.AddDirektkostnadAktivitet(akti, konto, belopp);
        }

        public List<KonstnadsbudgetPersonalDTO> GetKostnadsbudgetPersonal()
        {
            return repositoryFacade.kostnadsbudgetRepository.GetKostnadsbudgetPersonal();
        }

        public List<BudgetKontoDTO> GetAllKonton()
        {
            return repositoryFacade.kostnadsbudgetRepository.GetAllKonton();
        }

        public List<KostnadsbudgetProduktDTO> GetKostnadsbudgetProdukt()
        {
            return repositoryFacade.kostnadsbudgetRepository.GetKostnadsbudgetProdukt();
        }

        public List<BehörighetDTO> GetAllBehörighet()
        {
            return repositoryFacade.behörighetRepository.GetAllBehörighet();
        }

        public decimal GetProduktKostnaderAvdelning(int avdelningsID)
        {
            return repositoryFacade.budgeteratResultatRepository.GetProduktKostnaderAvdelning(avdelningsID);
        }

        public decimal GetProduktKostnader(string produkt)
        {
            return repositoryFacade.budgeteratResultatRepository.GetProduktKostnader(produkt);
        }

        public void AddSchablon(string kostnad, SchablonDTO schablon)
        {
            repositoryFacade.schablonRepository.AddSchablon(kostnad, schablon);
        }

        public void RemovePlaceringAktivitet(string pers, string aktivitet, int andel)
        {
            repositoryFacade.kostnadsbudgetRepository.RemovePlaceringAktivitet(pers, aktivitet, andel);
        }

        public List<VisaBehörighetDTO> GetBehörighet(string persnr)
        {
            return repositoryFacade.behörighetRepository.GetBehörighet(persnr);
        }

        public List<Produkt> GetProduktByProduktGrupp(ProduktgruppDTO produktgruppDTO)
        {
           return repositoryFacade.kostnadsbudgetRepository.GetProduktByProduktGrupp(produktgruppDTO);
        }

        public void ExportToFile()
        {
            repositoryFacade.intäktsRepository.ExportTillFil();
        }

        public List<SchablonDTO> GetAllSchablon()
        {
            return repositoryFacade.schablonRepository.GetAllSchablon();
        }


        public List<PrognosDTO> GetAllPrognoser()
        {
            return repositoryFacade.prognosRepository.GetAllPrognoser();
        }

        public void RemoveAktivitet(AktivitetDTO aktivitet)
        {
            repositoryFacade.aktivitetRepository.RemoveAktivitet(aktivitet);
        }

        public List<AktivitetDTO> GetAllAktiviteter()
        {
            return repositoryFacade.aktivitetRepository.GetAllAktiviteter();
        }

        public List<IntäktsbudgetProduktDTO> GetAllProduktKunder(string produktId)
        {
            return repositoryFacade.intäktsRepository.GetAllProduktKunder(produktId);
        }

        public List<KontorDTO> GetKontor()
        {
            KontorDTO kontor = new KontorDTO() { Kontor = "Stockholmskontoret", KontorID = 1 };
            List<KontorDTO> kontors = new List<KontorDTO>();
            kontors.Add(kontor);
            return kontors;
        }

        public void AddAktivitet(string aktvitetsId, string namn, string avdelning)
        {
            repositoryFacade.aktivitetRepository.AddAktivitet(aktvitetsId, namn, avdelning);
        }

        public bool CheckAvdelning(string avdelning)
        {
            return repositoryFacade.produktRepository.CheckAvdelning(avdelning);
        }

        public decimal GetProduktIntäkter(ProduktDTO produkt)
        {
            decimal budget = 0;
            
            var list = repositoryFacade.budgeteratResultatRepository.GetProduktIntäkter(produkt);
            foreach (var item in list)
            {
                budget = budget + item.Budget;
            }
            return budget;
        }

        public void CreateAvdelning(string avdelning)
        {
            repositoryFacade.produktRepository.CreateAvdelning(avdelning);
        }

        public void AddKundProdukt(ProduktDTO produkt, decimal avtal, decimal tillägg, bool gradT, bool gradA, int tim, string kommentar, string kundId)
        {
            repositoryFacade.intäktsRepository.AddKundProdukt(produkt, avtal, tillägg, gradT, gradA, tim, kommentar, kundId);
        }

        public decimal GetGruppIntäkter(ProduktgruppDTO produktgruppDTO)
        {
            decimal budget = 0;

            var list = repositoryFacade.budgeteratResultatRepository.GetGruppIntäkter(produktgruppDTO);
            foreach (var item in list)
            {
                budget = budget + item.Budget;
            }
            return budget;
        }

        public List<PersonalProduktDTO> GetAllPersonalProdukt()
        {
            return repositoryFacade.kostnadsbudgetRepository.GetAllPersonalProdukt();
        }

        public void LäggTillPlaceringProdukt(int personal, string produkt, string andel)
        {
            repositoryFacade.kostnadsbudgetRepository.LäggTillPlaceringProdukt(personal, produkt, andel);
        }

        public void AddBehörighet(string tempBehör, string tempPersnr)
        {
            repositoryFacade.behörighetRepository.Addbehörighet(tempBehör, tempPersnr);
        }

        public void RemovePlaceringProdukt(string pers, string produkt, int andel)
        {
            repositoryFacade.kostnadsbudgetRepository.RemovePlaceringsProdukt(pers, produkt, andel);
        }

        public decimal GetAvdelningIntäkter(AvdelningDTO avdelningDTO)
        {
            decimal budget = 0;

            var list = repositoryFacade.budgeteratResultatRepository.GetAvdelningIntäkter(avdelningDTO);
            foreach (var item in list)
            {
                budget = budget + item.Budget;
            }
            return budget;
        }

        public void RemoveBehörighet(string tempBehör, string tempPersnr)
        {
            repositoryFacade.behörighetRepository.RemoveBehörighet(tempBehör, tempPersnr);
        }

        public decimal GetKontorIntäkter()
        {
            decimal budget = 0;

            var list = repositoryFacade.budgeteratResultatRepository.GetKontorIntäkter();
            foreach (var item in list)
            {
                budget = budget + item.Budget;
            }
            return budget;
        }

        public List<ProduktDTO> GetProduktWithoutIntäkt()
        {
            return repositoryFacade.intäktsRepository.GetProduktWithoutIntäkt();
        }

        

        public List<KundIntäktsbudget> GetAllKundID(string kundId)
        {
            return repositoryFacade.intäktsRepository.GetAllKundID(kundId);
        }

        public List<BehörighetDTO> GetBehörighetByPersnr(string persnr)
        {
            return repositoryFacade.behörighetRepository.GetBehörighetByPersnr(persnr);
        }

        public void RemoveProduktKund(IntäktsbudgetProduktDTO kunden, string ProduktID)
        {
            repositoryFacade.intäktsRepository.RemoveProduktKund(kunden, ProduktID);
        }

        public void AddProduktKund(KundDTO kund, decimal avtal, decimal tillägg, bool gradT, bool gradA, int tim, string kommentar, string produktID)
        {
            repositoryFacade.intäktsRepository.AddProduktKund(kund, avtal, tillägg, gradT, gradA, tim, kommentar, produktID);
        }

        public List<PersonalDTO> GetAllPersonal()
        {
            return repositoryFacade.personalRepository.GetAllPersonal();
        }

        public List<ProduktDTO> GetProduktByNamn(string produktnamn)
        {
            return repositoryFacade.produktRepository.GetProduktByNamn(produktnamn);
        }

        public object GetSchablonById(int id)
        {
            return repositoryFacade.schablonRepository.GetSchablonById(id);
        }

        public List<BehörighetDTO> GetBehörighetByNamn(string namn)
        {
            return repositoryFacade.behörighetRepository.GetBehörighetByNamn(namn);
        }

        public void RemoveKund(string kundId)
        {
            repositoryFacade.kundRepository.RemoveKund(kundId);
        }

        public void UpdateAktivitet(string aktiId, string aktinamn, string aktiAvdelning)
        {
            repositoryFacade.aktivitetRepository.UpdateAktivitet(aktiId, aktinamn, aktiAvdelning);
        }

        public void UpdateKonto(SchablonDTO oldSchablon, int konto, string benämning )
        {
            repositoryFacade.schablonRepository.UpdateKonto(oldSchablon, konto, benämning );
        }
        
        public void CreateKonto(int konto, string benämning)
        {
            repositoryFacade.schablonRepository.CreateKonto(konto, benämning);
        }

        public void RemoveKundProdukt(IntäktsbudgetKundDTO produkten, string kundId)
        {
            repositoryFacade.intäktsRepository.RemoveKundProdukt(produkten, kundId);
        }

        public void CreateAvkastning(int avkastning)
        {
            repositoryFacade.schablonRepository.CreateAvkastning(avkastning);
        }

        public object GetSchablonByBenämning(string benämning)
        {
            return repositoryFacade.schablonRepository.GetSchablonByBenämning(benämning);
        }

        public List<IntäktsbudgetKundDTO> GetAllKundProdukter(string KundID)
        {
            return repositoryFacade.intäktsRepository.GetAllKundProdukter(KundID);
        }

        public List<AktivitetDTO> GetAktivitetById(string aktivitetId)
        {
            return repositoryFacade.aktivitetRepository.GetAktivitetById(aktivitetId);
        }

        public List<PersonalDTO> GetPersonalByPersNr(string persNr)
        {
            return repositoryFacade.personalRepository.GetPersonalByPersNr(persNr);
        }

        public void RemovePersonal(PersonalDTO personal)
        {
            repositoryFacade.personalRepository.RemovePersonal(personal);
        }

        public void AddPersonal(int sysselsättningsgrad, string namn, string personNr, int vakansavdrag, string lösenord, int månadslön, string roll)
        {
            repositoryFacade.personalRepository.AddPersonal(sysselsättningsgrad, namn, personNr, vakansavdrag, lösenord, månadslön, roll);
        }

        public List<AktivitetDTO> GetAktivitetByNamn(string aktivitetNamn)
        {
            return repositoryFacade.aktivitetRepository.GetAktivitetByNamn(aktivitetNamn);
        }

        public List<KundDTO> GetKunderByID(string id)
        {
            return repositoryFacade.kundRepository.GetKunderByID(id);
        }
        public List<KundDTO> GetKunderByNamn(string namn)
        {
            return repositoryFacade.kundRepository.GetKunderByNamn(namn);
        }
        public List<AktivitetDTO> GetAktivitetByAvdelning(string avdelning)
        {
            return repositoryFacade.aktivitetRepository.GetAktivitetByAvdelning(avdelning);
        }
        public List<PersonalDTO> GetPersonalByNamn(string namn)
        {
            return repositoryFacade.personalRepository.GetPersonalByNamn(namn);
        }
        public void UpdatePersonal(PersonalDTO personal)
        {
            repositoryFacade.personalRepository.UpdatePersonal(personal);
        }
        public List<KundDTO> GetKunderByKategori(string kategori)
        {
            return repositoryFacade.kundRepository.GetKunderByKategori(kategori);
        }
        public List<KundDTO> GetKunderBySearch(string id, string namn, string kategori)
        {
            return repositoryFacade.kundRepository.GetKunderBySearch(id, namn, kategori);
        }
        public void UpdateKund(KundDTO oldKund, string kundId, string kundNamn, string kundKategori)
        {
            repositoryFacade.kundRepository.UpdateKund(oldKund, kundId, kundNamn, kundKategori);
        }
        public void AddKund(string id, string namn, string kategori)
        {
            repositoryFacade.kundRepository.AddKund(id, namn, kategori);
        }
        public void AddKundKategori(string namn)
        {
            repositoryFacade.kundRepository.AddKundKategori(namn);
        }
        public List<KundKategoriDTO> GetAllKundKategori()
        {
            return repositoryFacade.kundRepository.GetAllKundKategori();
        }
        public List<ProduktDTO> GetAllProdukter()
        {
            return repositoryFacade.produktRepository.GetAllProdukter();
        }
        public List<ProduktKategoriDTO> GetProduktByKategori()
        {
            return repositoryFacade.produktRepository.GetProduktByKategori();
        }
        public List<ProduktgruppDTO> GetProduktByGrupp()
        {
            return repositoryFacade.produktRepository.GetProduktByGrupp();
        }
        public List<AvdelningDTO> GetProduktByAvdelning()
        {
            return repositoryFacade.produktRepository.GetProduktByAvdelning();
        }
        public void AddProduktGrupp(string namn)
        {
            repositoryFacade.produktRepository.AddProduktGrupp(namn);
        }
        public void AddProduktKategori(string namn)
        {
            repositoryFacade.produktRepository.AddProduktKategori(namn);
        }
        public void AddAvdelning(string namn)
        {
            repositoryFacade.aktivitetRepository.AddAvdelning(namn);
        }

        public List<AvdelningDTO> GetAllAvdelningar()
        {
            return repositoryFacade.aktivitetRepository.GetAllAvdelningar();
        }
        public void AddProdukt(string produktID, string namn, string kategori, string grupp, string avdelning)
        {
            repositoryFacade.produktRepository.AddProdukt(produktID, namn, kategori, grupp, avdelning);
        }

        public void RemoveProdukt(ProduktDTO produkt)
        {
            repositoryFacade.produktRepository.RemoveProdukt(produkt);
        }

        public void RemoveKonto(SchablonDTO schablon)
        {
            repositoryFacade.schablonRepository.RemoveKonto(schablon);
        }

        public void UpdateProdukt(ProduktDTO oldProdukt, string produktID, string namn, string produktKategori, string produktGrupp, string produktAvdelning)
        {
            repositoryFacade.produktRepository.UpdateProdukt(oldProdukt, produktID, namn, produktKategori, produktGrupp, produktAvdelning);
        }

        public List<ProduktDTO> GetProdukterBySearch(string produktID, string namn, string produktKategori, string produktGrupp, string produktAvdelning)
        {
            return repositoryFacade.produktRepository.GetProdukterBySearch(produktID, namn, produktKategori, produktGrupp, produktAvdelning);
        }

        public string SkapaID(string namn, string Kategori)
        {
            string idEnd;
            if (Kategori == "Administrativa avdelningen")
            {
                idEnd = "AO";
            }
            else if (Kategori == "Försäljnings- och marknadsavdelningen")
            {
                idEnd = "FO";
            }
            else
            {
                idEnd = Kategori.Substring(0, 2).ToUpper();
            }

            Random r = new Random();
            var indext = r.Next(2, namn.Trim().Length - 1);
            var IdStart = namn.Substring(0, 3) + (namn.Trim()[indext]);
            string id = IdStart + idEnd;

            return id.ToUpper();
        }

        public void Exportera(DataGridView dgv, string filename)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            for (int x = 1; x < dgv.Columns.Count + 1; x++)
            {
                xlWorkSheet.Cells[1, x] = dgv.Columns[x - 1].HeaderText;
            }

            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                for (int j = 0; j < dgv.Columns.Count; j++)
                {
                    xlWorkSheet.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value.ToString();
                }
            }


            xlWorkBook.SaveAs(filename, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);
        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
        public bool GetIntäktsLås()
        {
            return repositoryFacade.låsRepository.GetIntäktsLås();
        }
        public void SetIntäktsLås(bool boolean)
        {
            repositoryFacade.låsRepository.SetIntäktsLås(boolean);
        }
        public bool GetAffoLås()
        {
            return repositoryFacade.låsRepository.GetAffoLås();
        }
        public void SetAffoLås(bool boolean)
        {
            repositoryFacade.låsRepository.SetAffoLås(boolean);
        }

        public bool GetDriftLås()
        {
            return repositoryFacade.låsRepository.GetDriftLås();
        }
        public void SetDriftLås(bool boolean)
        {
            repositoryFacade.låsRepository.SetDriftLås(boolean);
        }
        public bool GetUtvFörvLås()
        {
            return repositoryFacade.låsRepository.GetUtvFörvLås();
        }
        public void SetUtvFörvLås(bool boolean)
        {
            repositoryFacade.låsRepository.SetUtvFörvLås(boolean);
        }

        public bool GetProgLås()
        {
            return repositoryFacade.låsRepository.GetProgLås();
        }
        public void SetProgLås(bool boolean)
        {
            repositoryFacade.låsRepository.SetProgLås(boolean);
        }

        public void SparaFilMetod(List<LästFilPrognos> prognoser)
        {
            repositoryFacade.prognosRepository.SparaFilMetod(prognoser);
        }

        public List<LästFilPrognos> LaddaRegister()
        {
            List<LästFilPrognos> lästFilPrognoser = repositoryFacade.prognosRepository.LaddaRegister();
            return lästFilPrognoser;
        }

        public LästFilPrognos RäknaUtBudgetPrognos(List<LästFilPrognos> prognoser)
        {
            LästFilPrognos lästFilPrognoser = repositoryFacade.prognosRepository.RäknaUtBudgetPrognos(prognoser);
            return lästFilPrognoser;
        }

        public List<LästFilPrognos> FörberedaExport(LästFilPrognos transfer, List<LästFilPrognos> prognoser)
        {
            List<LästFilPrognos> förberdaPrognoser = repositoryFacade.prognosRepository.FörberedaExport(transfer, prognoser);
            return förberdaPrognoser;
        }

        public List<KonstnadsbudgetPersonalDTO> Kalkylering(List<KonstnadsbudgetPersonalDTO> personals)
        {
            List<KonstnadsbudgetPersonalDTO> kalkylLista = repositoryFacade.kostnadsbudgetRepository.Kalkylering(personals);
            return kalkylLista;
        }

        public void SetPlacering(string avdelningsnamn, string personNr, int placering)
        {
            repositoryFacade.avdelningPersonalRepository.SetAvdelningPersonal(avdelningsnamn, personNr, placering);
        }

        public decimal GetDiff(List<KonstnadsbudgetPersonalDTO> personals)
        {
            decimal Diffen = repositoryFacade.kostnadsbudgetRepository.GetDiff(personals);
            return Diffen;
        }
    }
}
