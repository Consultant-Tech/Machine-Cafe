namespace Modeles.Commun.DAO
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using NHibernate;
    using Modeles.Commun.BusinessObject;

    /// <summary>
    /// Interface Générique pour les Operations de la base des données
    /// </summary>
    /// <typeparam name="T">BusinessObject</typeparam>
    public interface GenericDAO<T> where T : class, BO
    {
        /// <summary>
        /// Ajoute l'instance businessObject à la base de données
        /// </summary>
        /// <param name="businessObject"></param>
        /// <returns>businessObject</returns>

        T persist(T businessObject);

        /// <summary>
        /// Creation d'objet : Ajouter ou Modifier 
        /// </summary>
        /// <param name="businessObject"></param>
        /// <returns>businessObject</returns>

        T create(T businessObject);

        /// <summary>
        /// Supprimer l'objet
        /// </summary>
        /// <param name="businessObject"></param>

        void delete(T businessObject);

        /// <summary>
        /// Recherche d'une instance depuis la base des données
        /// </summary>
        /// <param name="id">Id de l'objet</param>
        /// <returns>businessObject</returns>

        T findById(Object id);

        /// <summary>
        /// Retourner la liste des Objets
        /// </summary>
        /// <returns>Liste des businessObject</returns>

        List<T> findAll();

        /// <summary>
        /// Modifier l'objet
        /// </summary>
        /// <param name="businessObject"></param>
        /// <returns>businessObject</returns>

        T update(T businessObject);

        /// <summary>
        /// Session Factory Property : 
        /// Instance d'objet SessionFactory Pour la communication avec la base des données configurée.
        /// </summary>
        /// <returns>ISessionFactory</returns>

        ISession SessionProperty { get; set; }

        /// <summary>
        /// Recherche des Objets avec critères
        /// </summary>
        /// <param name="namedQuery">requete à executer</param>
        /// <param name="rechercheCrtieria">Parametres de la requete</param>
        /// <returns>Liste des BusinessObject</returns>

        List<T> FindByNamedQueryCriteria(String namedQuery, Dictionary<String, Object> rechercheCrtieria);

        /// <summary>
        /// début transaction
        /// </summary>
        void BeginTransaction();

        /// <summary>
        /// end transaction 
        /// </summary>
        void CommitTransaction();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="businessObject"></param>
        void Save(T businessObject);

        /// <summary>
        /// Recherche des Objets avec order by order croisante un seul critère
        /// </summary>
        /// <param name="properties"></param>
        /// <returns></returns>
        List<T> FindAllOrderBy(params Expression<Func<T, object>>[] properties);
        /// <summary>
        ///  Recherche des Objets avec order by order décroisante un seul critère
        /// 
        /// </summary>
        /// <param name="desc"></param>
        /// <param name="properties"></param>
        /// <returns></returns>
        List<T> FindAllOrderBy(bool desc, params Expression<Func<T, object>>[] properties);


        /// <summary>
        /// Recherche des Objets avec filtre d'objet
        /// </summary>
        /// <param name="properties"></param>
        /// <returns></returns>
        List<T> FindByProprety(params Expression<Func<T, object>>[] properties);

    }
}
