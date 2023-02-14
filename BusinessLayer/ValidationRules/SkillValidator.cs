using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class SkillValidator : AbstractValidator<Skill>
    {
        public SkillValidator() 
        {
            RuleFor(x => x.SkillName).NotEmpty().WithMessage("Yetekler kismini bos gecemezsiniz...");
            RuleFor(x => x.SkillValue).NotEmpty().WithMessage("Yetenek Yuzdesini bos gecemezsiniz...");


            RuleFor(x => x.SkillName).MinimumLength(1).WithMessage("Lutfen en az 1 karekter girisi yapiniz...");
            

            RuleFor(x => x.SkillName).MaximumLength(50).WithMessage("Lutfen 50 karekterden fazla deger girisi yapmayiniz...");

            RuleFor(x => x.SkillValue).InclusiveBetween(0, 100).WithMessage("Lutfen 0 ile 100 arasinda sayi giriniz...");
           



        }
    }
}
