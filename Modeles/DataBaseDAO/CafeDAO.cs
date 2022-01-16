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

    public class CafeDAO : AbstractDAO<Ordre>
    {
        public CafeDAO()
        {
        }
        //=========================================
        public bool AjouterCafe(Ordre p)
        {
            using (var context = new MachineCafeEntities())
            {
                context.Ordre.Add(p);
                context.SaveChanges();

            }
            return true;

        }
        public Ordre GetCafeByMat(string p)
        {
            using (var context = new MachineCafeEntities())
            {
                Ordre ordre = context.Ordre
                    .Where(b => b.Matricule == p)
                    .OrderByDescending(b => b.Id)
                    .FirstOrDefault();
                return ordre;
            }

        }
    }
}
