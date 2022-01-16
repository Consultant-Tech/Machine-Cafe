
using System;
using Modeles.DataBaseDAO;
using Modeles.Modele;

namespace Service
{
    public class CafeService
    {
        private readonly CafeDAO _cafeDao = new CafeDAO();
        private readonly Ordre _cafe = new Ordre();
        public bool AjouterOrdre(string typecafe, string _niveauintensite, int lait, int sucre, int mug, string matricule)
        {
            try
            {
                _cafe.Type = typecafe;
                _cafe.Intensite = _niveauintensite;
                _cafe.Lait = lait;
                _cafe.Sucre = sucre;
                _cafe.Mug = mug;
                _cafe.Matricule = matricule;
                _cafeDao.AjouterCafe(_cafe);
            }
            catch (Exception EX)
            {
                return false;
            }
            return true;
        }

        public Ordre RecupererOrdre(string matricule)
        {
           return _cafeDao.GetCafeByMat(matricule);
        }
    }
}
