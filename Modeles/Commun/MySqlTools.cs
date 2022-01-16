using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using NHibernate;
using NHibernate.Cache;
using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Driver;

namespace Modeles.Commun
{
    public static class MySqlTools
    {


        public static SqlConnection machineconnexion;

        public static bool MysqlDtabaseConnection()
        {
            try
            {
                machineconnexion = new SqlConnection(@"Server=(.\SQL2K19);Database=MachineCafe;Trusted_Connection=Yes;");
                machineconnexion.Open();
                return true;
            }
            catch
            {
                MessageBox.Show("db error");
                return false;

            }
        }
        public static ISession GetCurrentSession()
        {
            try
            {
                machineconnexion = new SqlConnection(@"Server=HDEBA-PC\SQL2K19;Database=MachineCafe;Trusted_Connection=Yes;");
                machineconnexion.Open();
            }
            catch
            {
                MessageBox.Show("db error");

            }
            Configuration cfg = new Configuration();
            cfg = Config.GetDefaultConfiguration();
        ISessionFactory sessions = cfg.Configure().BuildSessionFactory();
            var session = sessions.OpenSession(machineconnexion);
            return session;
        }
    }

}

