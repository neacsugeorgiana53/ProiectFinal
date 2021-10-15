using ProiectMaster.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProiectMaster.Dataaccess.Interfaces
{
    public interface IRepository<T,G> where T: class, IEntity<G> where G : IEquatable<G>
    {
        IEnumerable<T> GetAll();
        //intoarce toate inregistrarile din baza de date
        T GetInstance(G id);
        //preluare dupa id
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        bool IsUnique(Expression<Func<T, bool>> predicate);
    }
}
