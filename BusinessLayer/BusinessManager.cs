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
        RepositoryFacade repositoryFacade = new RepositoryFacade();

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

        public List<AktivitetDTO> GetAllAktiviteter()
        {
            return repositoryFacade.aktivitetRepository.GetAllAktiviteter();
        }

        public void AddAktivitet(string aktvitetsId, string namn, string avdelning)
        {
            repositoryFacade.aktivitetRepository.AddAktivitet(aktvitetsId, namn, avdelning);
        }

        public List<Personal> GetAllPersonal()
        {
            return repositoryFacade.personalRepository.GetAllPersonal();
        }

        public void RemoveKund(string kundId)
        {
            repositoryFacade.kundRepository.RemoveKund(kundId);
        }

        public object GetAktivitetById(string aktivitetId)
        {
            return repositoryFacade.aktivitetRepository.GetAktivitetById(aktivitetId);
        }

        public List<Personal> GetPersonalByPersNr(string persNr)
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

        public object GetAktivitetByNamn(string aktivitetNamn)
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

        public object GetAktivitetByAvdelning(string avdelning)
        {
            return repositoryFacade.aktivitetRepository.GetAktivitetByAvdelning(avdelning);
        }

        public List<Personal> GetPersonalByNamn(string namn)
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

        public void AddProdukt(string produktID, string namn, string kategori, string grupp, string avdelning)
        {
            repositoryFacade.produktRepository.AddProdukt(produktID, namn, kategori, grupp, avdelning);
        }
    }
}
