using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GraphApp.Infrastructure.Repositories
{

    /// <summary>
    /// 
    /// </summary>
    public abstract class BaseCRUDRepository<T, TId> : 
        BaseCRURepository<T, TId>,
        Core.Interfaces.ICRUDRepository<T, TId>
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
        public BaseCRUDRepository(Contexts.Factories.Application factory) :
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
        public virtual void Delete(
            T entity)
        {

            using (var context = Factory.CreateDbContext())
            {

                context.Set<T>().Remove(entity);
                context.SaveChanges();

            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async virtual Task DeleteAsync(
            T entity)
        {

            using (var context = Factory.CreateDbContext())
            {

                context.Set<T>().Remove(entity);
                await context.SaveChangesAsync();

            }

        }

        #endregion

        #region Event Handlers
        //No Event Handlers
        #endregion

    }

}
