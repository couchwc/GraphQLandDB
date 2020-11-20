using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GraphApp.Infrastructure.Repositories
{

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="TId"></typeparam>
    public class BaseCRURepository<T, TId> :
        BaseRepository<T, TId>,
        Core.Interfaces.ICRURepository<T, TId>
        where T : Core.Entities.BaseEntity<TId>
    {

        #region Fields
        //No Fields
        #endregion

        #region Events
        //No Events
        #endregion

        #region Enums
        //No Enums
        #endregion

        #region Constructors

        /// <summary>
        /// 
        /// </summary>
        /// <param name="factory"></param>
        public BaseCRURepository(Contexts.Factories.Application factory) :
            base(factory)
        {
            //
        }

        #endregion

        #region Destructors
        //No Destructors
        #endregion

        #region Properties
        //No Properties
        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual T Add(
            T entity)
        {

            using (var context = Factory.CreateDbContext())
            {

                context.Set<T>().Add(entity);
                context.SaveChanges();

                return entity;

            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async virtual Task<T> AddAsync(
            T entity)
        {

            using (var context = Factory.CreateDbContext())
            {

                await context.Set<T>().AddAsync(entity);
                await context.SaveChangesAsync();

                return entity;

            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual T Update(
            T entity)
        {

            using (var context = Factory.CreateDbContext())
            {

                context.Set<T>().Update(entity);
                context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();

                return entity;

            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async virtual Task<T> UpdateAsync(
            T entity)
        {

            using (var context = Factory.CreateDbContext())
            {

                context.Set<T>().Update(entity);
                context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                await context.SaveChangesAsync();

                return entity;

            }

        }

        #endregion

        #region Event Handlers
        //No Event Handlers
        #endregion

    }

}
