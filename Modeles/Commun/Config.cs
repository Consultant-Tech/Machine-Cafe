namespace Modeles.Commun
{
    using System;
    using System.IO;

    public static class Config
    {
        #region Fields

        public static readonly string hibernateConfigFile;

        #endregion Fields

        #region Constructors

        static Config()
        {
            // Verify if hibernate.cfg.xml exists
            hibernateConfigFile = GetDefaultConfigurationFilePath();
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Standar Configuration for tests.
        /// </summary>
        /// <returns>The configuration using merge between App.Config and hibernate.cfg.xml if present.</returns>
        public static NHibernate.Cfg.Configuration GetDefaultConfiguration()
        {
            NHibernate.Cfg.Configuration result = new NHibernate.Cfg.Configuration();
            if (hibernateConfigFile != null)
                result.Configure(hibernateConfigFile);
            return result;
        }

        public static string GetDefaultConfigurationFilePath()
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string relativeSearchPath = AppDomain.CurrentDomain.RelativeSearchPath;
            string binPath = relativeSearchPath == null ? baseDir : Path.Combine(baseDir, relativeSearchPath);
            string fullPath = Path.Combine(binPath, NHibernate.Cfg.Configuration.DefaultHibernateCfgFileName);
            return File.Exists(fullPath) ? fullPath : null;
        }

        #endregion Methods
    }
}