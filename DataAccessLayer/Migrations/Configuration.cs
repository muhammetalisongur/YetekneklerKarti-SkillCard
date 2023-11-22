namespace DataAccessLayer.Migrations
{
    using EntityLayer.Concrete;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataAccessLayer.Concrete.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(DataAccessLayer.Concrete.Context context)
        {

            context.Profils.AddOrUpdate(x => x.ProfilID,
                new EntityLayer.Concrete.Profil()
                {
                    UserName = "Muhammet Ali",
                    SurName = "Songur",
                    Message = "“Tereddüt edersen bacakların seni taşımaz. Yürüyeceğim de, bas ve yürü!”",
                    Image = "/Images/MAS.jpg"
                });

            context.Skills.AddOrUpdate(x => x.SkillID,
            new EntityLayer.Concrete.Skill()
            {
                SkillName = "C#",
                SkillValue = 50,
            },
            new Skill()
            {
                SkillName = "HTML",
                SkillValue = 100,
            },
            new Skill()
            {
                SkillName = "CSS",
                SkillValue = 70,
            },
            new Skill()
            {
                SkillName = "Javascript",
                SkillValue = 60,
            },
            new Skill()
            {
                SkillName = "Jquery",
                SkillValue = 50,
            },
            new Skill()
            {
                SkillName = "Bootstrap",
                SkillValue = 80,
            });



        }
    }
}
