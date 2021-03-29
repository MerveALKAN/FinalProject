using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAcces
{
    //generic constraint
    //class:referans tip olabilir
    //IEntity: IEntity olabilir veya IEntity implemente eden bir nesne olabilir.
    //new(): new'lenebilir olmalı
    public interface IEntityRepository<T> where T : class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity); //interface metotları default publictir. Kendi değildir.
        void Update(T entity);
        void Delete(T entity);

        //Core katmanı diğer katmanları referans almaz. Alırsa o katmana bağımlısın demektir. 
      
    }
}
