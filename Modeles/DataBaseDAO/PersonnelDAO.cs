using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Modeles.Commun;
using Modeles.Commun.DAO;
using Modeles.Modele;
using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Driver;

namespace Modeles.DataBaseDAO
{

    public class PersonnelDAO : AbstractDAO<Personnel>
    {
        public PersonnelDAO()
        {
        }
        //=========================================
        public bool AjouterPersonnel(Personnel p)
        {
            using (var context = new MachineCafeEntities())
            {
                context.Personnel.Add(p);
                context.SaveChanges();

            }
            return true;

        }
        public Personnel GetPersonnel(string p)
        {
            using (var context = new MachineCafeEntities())
            {
                Personnel personnel = context.Personnel
                    .Where(b => b.Matricule == p)
                    .FirstOrDefault();
                return personnel;
            }

        }
    }
}
