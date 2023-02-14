using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        public DbSet<Profil> Profils { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}
