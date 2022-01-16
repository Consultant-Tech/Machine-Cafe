
using System;
using Modeles.DataBaseDAO;
using Modeles.Modele;

namespace Service
{
    public class PersonneService
    {
        private readonly PersonnelDAO _personnelDao = new PersonnelDAO();
        private readonly Personnel _personnel = new Personnel();
        public bool AjouterPersonnel(string matricule, string nom, string prenom)
        {
            try
            {
                _personnel.Matricule = matricule;
                _personnel.Nom = nom;
                _personnel.Prenom = prenom;
                _personnelDao.AjouterPersonnel(_personnel);
            }
            catch (Exception EX)
            {
                return false;
            }
            return true;
        }

        public Personnel RecupererPersonnel(string matricule)
        {
           return _personnelDao.GetPersonnel(matricule);
        }
    }
}
