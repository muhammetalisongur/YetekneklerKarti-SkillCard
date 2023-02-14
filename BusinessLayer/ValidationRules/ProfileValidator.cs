using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Internal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ProfileValidator : AbstractValidator<Profil>
    {
        
        public ProfileValidator() 
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Adinizi bos gecemezsiniz...");
            RuleFor(x => x.SurName).NotEmpty().WithMessage("Soyadi bos gecemezsiniz...");
            RuleFor(x => x.Message).NotEmpty().WithMessage("Aciklamai bos birakamazsiniz...");

            RuleFor(x => x.UserName).MinimumLength(3).WithMessage("Lutfen en az 3 karekter girisi yapiniz...");
            RuleFor(x => x.SurName).MinimumLength(3).WithMessage("Lutfen en az 3 karekter girisi yapiniz...");
            RuleFor(x => x.Message).MinimumLength(3).WithMessage("Lutfen en az 3 karekter girisi yapiniz...");


            RuleFor(x => x.UserName).MaximumLength(50).WithMessage("Lutfen 50 karekterden fazla deger girisi yapmayiniz...");
            RuleFor(x => x.SurName).MaximumLength(50).WithMessage("Lutfen 50 karekterden fazla deger girisi yapmayiniz...");
            RuleFor(x => x.Message).MaximumLength(250).WithMessage("Lutfen 250 karekterden fazla deger girisi yapmayiniz...");

            //RuleFor(x => x.Image).n.WithMessage("Profil resmi Ekleyiniz...");



        }



    }
}
