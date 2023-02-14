using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProfilManager : IProfilService
    {
        IProfilDal _profilDal;

        public ProfilManager(IProfilDal profilDal)
        {
            _profilDal = profilDal;
        }

        public Profil GetByID(int id)
        {
            return _profilDal.Get(x => x.ProfilID == id);
        }

        public List<Profil> GetList()
        {
            return _profilDal.List();
        }

        public void ProfilAdd(Profil profil)
        {

            _profilDal.Add(profil);
        }

        public void ProfilDelete(Profil profil)
        {
            _profilDal.Delete(profil);
        }

        public void ProfilUpdate(Profil profil)
        {
            _profilDal.Update(profil);
        }
    }
}
