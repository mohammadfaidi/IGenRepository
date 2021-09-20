using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.models;

namespace WebApplication1.Repo
{
  public  interface IGenRepo <T> where T :class, IModelBase
    {
        T Get(int id);
        IEnumerable<T> Get();
        void Add(T obj);
        void update(T obj);
    }


    public class GenRepo<T>:IGenRepo <T> where T : class , IModelBase
    {
        public readonly AppDBContext _dbContext;
        public GenRepo(AppDBContext dBContext)
        {
            _dbContext = dBContext;
        }

        public void Add(T obj)
        {
            _dbContext.Set<T>().Add(obj);
            _dbContext.SaveChanges();
        }

        public T Get(int id)
        {
            //  return _dbcontext.Set<T>().FirstOrDefault(x => x.id == id);
            return _dbContext.Set<T>().FirstOrDefault(i=>i.id== id);
            


        }

        public IEnumerable<T> Get()
        {
         return _dbContext.Set<T>().ToList();
        }

        public void update(T obj)
        {
            ///
        }
    }
}
