using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphApp.Infrastructure.Repositories
{

    /// <summary>
    /// 
    /// </summary>
    public abstract class BaseRepository<T, TId> :
        Core.Interfaces.IRepository<T, TId>
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
        public BaseRepository(
            Contexts.Factories.Application factory)
        {

            // Check parameters
            if (factory is null)
                throw new ArgumentNullException(paramName: nameof(factory));

            _factory = factory;

        }

        #endregion

        #region Destructors
        //No Destructors
        #endregion

        #region Properties

        /// <summary>
        /// 
        /// </summary>
        public Contexts.Factories.Application Factory => _factory;
        private Contexts.Factories.Application _factory;

        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual T GetItem(
            TId id)
        {

            using (var context = Factory.CreateDbContext())
            {

                var result = context.Set<T>().SingleOrDefault(item => item.Id.Equals(id));
                return result;

            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public virtual T GetItem(
            TId id,
            Func<IQueryable<T>, IQueryable<T>> func)
        {

            using (var context = Factory.CreateDbContext())
            {

                var result = func(context.Set<T>()).SingleOrDefault(item => item.Id.Equals(id));
                return result;

            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async virtual Task<T> GetItemAsync(
            TId id)
        {

            using (var context = Factory.CreateDbContext())
            {

                return await context.Set<T>().SingleOrDefaultAsync(item => item.Id.Equals(id));

            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public async virtual Task<T> GetItemAsync(
            TId id,
            Func<IQueryable<T>, IQueryable<T>> func)
        {

            using (var context = Factory.CreateDbContext())
            {

                return await func(context.Set<T>()).SingleOrDefaultAsync(item => item.Id.Equals(id));

            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual IEnumerable<T> GetItems()
        {

            using (var context = Factory.CreateDbContext())
            {

                var results = context.Set<T>().ToList();
                return results.AsEnumerable<T>();

            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="func"></param>
        /// <returns></returns>
        public virtual IEnumerable<T> GetItems(
            Func<IQueryable<T>, IQueryable<T>> func)
        {

            using (var context = Factory.CreateDbContext())
            {

                var results = func(context.Set<T>()).ToList();
                return results.AsEnumerable<T>();

            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async virtual Task<IEnumerable<T>> GetItemsAsync()
        {

            using (var context = Factory.CreateDbContext())
            {

                var task = context.Set<T>().ToListAsync();
                
                await task;

                return task.Result.AsEnumerable<T>();

            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="func"></param>
        /// <returns></returns>
        public async virtual Task<IEnumerable<T>> GetItemsAsync(
            Func<IQueryable<T>, IQueryable<T>> func)
        {

            using (var context = Factory.CreateDbContext())
            {

                var task = func(context.Set<T>()).ToListAsync();

                await task;

                return task.Result.AsEnumerable<T>();

            }

        }

        #endregion

        #region Event Handlers
        //No Event Handlers
        #endregion

    }

}
