using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Profil
    {
        [Key] public int ProfilID { get; set; }
        [StringLength(50)] public string UserName { get; set; }
        [StringLength(50)] public string SurName { get; set; }
        [StringLength(250)] public string Message { get; set; }
        [StringLength(250)] public string Image { get; set; }
        //[DefaultValue(true)] public bool isActive { get; set; }

    }
}
