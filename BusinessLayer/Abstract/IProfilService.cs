using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IProfilService
    {
        List<Profil> GetList();
        Profil GetByID(int id);
        void ProfilAdd(Profil profil);
        void ProfilDelete(Profil profil);
        void ProfilUpdate(Profil profil);


    }
}
