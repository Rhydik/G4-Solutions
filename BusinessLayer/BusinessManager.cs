using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using DataLayer.DTO;

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

        //Kunder
        public List<KundDTO> GetAllKunder()
        {
            //repositoryFacade.kundRepository.AddKund();   för testning//Leo
            return repositoryFacade.kundRepository.GetAllKunder();
        }

        public List<BehörighetDTO> GetAllBehörighet()
        {
            return repositoryFacade.behörighetRepository.GetAllBehörighet();
        }

        public List<VisaBehörighetDTO> GetBehörighet(string persnr)
        {
            return repositoryFacade.behörighetRepository.GetBehörighet(persnr);
        }

        public List<SchablonDTO> GetAllSchablon()
        {
            return repositoryFacade.schablonRepository.GetAllSchablon();
        }

        public void RemoveAktivitet(AktivitetDTO aktivitet)
        {
            repositoryFacade.aktivitetRepository.RemoveAktivitet(aktivitet);
        }

        public List<AktivitetDTO> GetAllAktiviteter()
        {
            return repositoryFacade.aktivitetRepository.GetAllAktiviteter();
        }

        public void AddAktivitet(string aktvitetsId, string namn, string avdelning)
        {
            repositoryFacade.aktivitetRepository.AddAktivitet(aktvitetsId, namn, avdelning);
        }

        public void AddBehörighet(string tempBehör, string tempPersnr)
        {
            repositoryFacade.behörighetRepository.Addbehörighet(tempBehör, tempPersnr);
        }

        public void RemoveBehörighet(string tempBehör, string tempPersnr)
        {
            repositoryFacade.behörighetRepository.RemoveBehörighet(tempBehör, tempPersnr);
        }

        public List<BehörighetDTO> GetBehörighetByPersnr(string persnr)
        {
            return repositoryFacade.behörighetRepository.GetBehörighetByPersnr(persnr);
        }

        public List<PersonalDTO> GetAllPersonal()
        {
            return repositoryFacade.personalRepository.GetAllPersonal();
        }

        public object GetSchablonById(string id)
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

        public void UpdateKonto(SchablonDTO oldSchablon, string kontoId, string kontoNamn, string schablonkostnad)
        {
            repositoryFacade.schablonRepository.UpdateKonto(oldSchablon, int.Parse(kontoId), kontoNamn, int.Parse(schablonkostnad));
        }
        
        public void CreateKonto(int konto, string namn, int schablonKostnad)
        {
            repositoryFacade.schablonRepository.CreateKonto(konto, namn, schablonKostnad);
        }

        public void CreateAvkastning(int avkastning)
        {
            repositoryFacade.schablonRepository.CreateAvkastning(avkastning);
        }

        public object GetSchablonByBenämning(string benämning)
        {
            return repositoryFacade.schablonRepository.GetSchablonByBenämning(benämning);
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

        public void AddPersonal(int sysselsättningsgrad, string namn, string personNr, int vakansavdrag, string lösenord, int månadslön)
        {
            repositoryFacade.personalRepository.AddPersonal(sysselsättningsgrad, namn, personNr, vakansavdrag, lösenord, månadslön);
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

        //KundKategori
        public void AddKundKategori(string namn)
        {
            repositoryFacade.kundRepository.AddKundKategori(namn);
        }

        public List<KundKategoriDTO> GetAllKundKategori()
        {
            return repositoryFacade.kundRepository.GetAllKundKategori();
        }

        //Produkter
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

        public string SkapaID(string kundId, string kundKategori)
        {
            string idEnd = "";

            if (kundKategori.Equals("Näringsliv"))
            {
                idEnd = "NL";
            }

            if (kundKategori.Equals("Offentlig"))
            {
                idEnd = "OF";
            }

            string id = kundId + idEnd;

            return id;
        }

    }
}
