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

        public List<Personal> GetAllPersonal()
        {
            return repositoryFacade.personalRepository.GetAllPersonal();
        }

        public void RemoveKund(string kundId)
        {
            repositoryFacade.kundRepository.RemoveKund(kundId);
        }

        public List<Personal> GetPersonalByPersNr(string persNr)
        {
            return repositoryFacade.personalRepository.GetPersonalByPersNr(persNr);
        }

        public void RemovePersonal(Personal personal)
        {
            repositoryFacade.personalRepository.RemovePersonal(personal);
        }

        public void AddPersonal(Personal personal)
        {
            repositoryFacade.personalRepository.AddPersonal(personal);
        }

        public List<KundDTO> GetKunderByID(string id)
        {
            return repositoryFacade.kundRepository.GetKunderByID(id);
        }

        public List<KundDTO> GetKunderByNamn(string namn)
        {
            return repositoryFacade.kundRepository.GetKunderByNamn(namn);
        }

        public List<Personal> GetPersonalByNamn(string namn)
        {
            return repositoryFacade.personalRepository.GetPersonalByNamn(namn);
        }

        public void UpdatePersonal(Personal personal)
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

        public void AddProdukt(string produktKod, string namn, string kategori, string grupp)
        {
            //repositoryFacade.produktRepository.AddProdukt(produktKod, namn, kategori, grupp);
        }
    }
}
