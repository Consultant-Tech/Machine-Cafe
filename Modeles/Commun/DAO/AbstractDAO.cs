using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using NHibernate;
using Modeles.Commun.BusinessObject;
using NHibernate.Criterion;

namespace Modeles.Commun.DAO
{
    public class AbstractDAO<T> : GenericDAO<T> where T : class, BO
    {
        public ITransaction Transaction { get; set; }

        public T persist(T businessObject)
        {
            SessionProperty.Persist(businessObject);

            return businessObject;
        }

        public T create(T businessObject)
        {
            return SessionProperty.Merge(businessObject);
        }

        public void delete(T businessObject)
        {
            SessionProperty.Delete(SessionProperty.Merge(businessObject));
        }
        public void Delete1(T businessObject)
        {
            SessionProperty.Delete(businessObject);
        }

        public T Detach(T businessObject)
        {
            SessionProperty.Evict(businessObject);
            return businessObject;
        }

        public List<T> Detach(List<T> list)
        {
            try
            {
                foreach (T businessObject in list)
                {

                    SessionProperty.Evict(businessObject);

                }
            }
            catch (Exception)
            {
                return list;
            }
            return list;
        }

        public T findById(object id)
        {
            return Detach(SessionProperty.Get<T>(id));
        }



        public List<T> findAll()
        {
            try
            {

                var lista = SessionProperty.CreateCriteria<T>().List<T>() as List<T>;
                return Detach(lista);
            }
            catch (Exception)
            {
                return null;
            }

        }


        public List<T> FindAllOrderBy(bool desc, params Expression<Func<T, object>>[] properties)
        {
            var result = SessionProperty.QueryOver<T>();
            result = properties.Aggregate(result, (current, property) => desc ? current.OrderBy(property).Desc : current.OrderBy(property).Asc);

            return Detach(result.List<T>() as List<T>);
        }


        public int Count()
        { return SessionProperty.QueryOver<T>().RowCount(); }

        public List<T> FindAllWhere(params Expression<Func<T, bool>>[] conditions)
        {
            var list = new List<T>();
            try
            {
                var tt = QueryOver.Of<T>();
                foreach (var item in conditions)
                {
                    tt.Where(item);
                }
                list = (List<T>)tt.GetExecutableQueryOver(SessionProperty).List<T>();
                if (list.Any())
                {
                    return Detach(list);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Impossible de trouver l'objet");
                return list;
            }
            return new List<T>();
        }


        public List<T> FindAllOrderBy(params Expression<Func<T, object>>[] properties)
        {
            return FindAllOrderBy(false, properties);
        }

        public T update(T businessObject)
        {
            SessionProperty.Update(businessObject);

            return businessObject;
        }

        public int Execute(string query)
        {
            var sqlquery = SessionProperty.CreateSQLQuery(query);
            return sqlquery.ExecuteUpdate();
        }

        public ISession SessionProperty { get; set; }

        public List<T> FindByNamedQueryCriteria(string namedQuery, Dictionary<string, object> rechercheCrtieria)
        {

            var query = SessionProperty.CreateQuery(namedQuery);
            foreach (var item in rechercheCrtieria)
            {
                query.SetParameter(item.Key, item.Value);
            }
            return Detach((List<T>)query.List<T>());

        }

        public List<T> FindByNamedQueryCriteria(string namedQuery, Dictionary<string, object> rechercheCrtieria, int limit)
        {
            var query = SessionProperty.CreateQuery(namedQuery);
            query.SetMaxResults(limit);
            foreach (var item in rechercheCrtieria)
            {
                query.SetParameter(item.Key, item.Value);
            }
            return Detach((List<T>)query.List<T>());
        }

        public void Save(T x)
        {
            SessionProperty.SaveOrUpdate(x);
        }

        public void BeginTransaction()
        {
            Transaction = SessionProperty.BeginTransaction();
        }
        public void CommitTransaction()
        {
            Transaction.Commit();
            SessionProperty.Flush();
            SessionProperty.Clear();
            Transaction.Dispose();
        }

        public List<T> FindByProprety(params Expression<Func<T, object>>[] properties)
        {
            throw new NotImplementedException();
        }
    }
}
