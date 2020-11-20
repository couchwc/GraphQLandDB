using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphApp.Core.Interfaces
{

    /// <summary>
    /// 
    /// </summary>
    public interface IRepository<T, TId> where T : Core.Entities.BaseEntity<TId>
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
        //No Constructors
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
        /// <param name="id"></param>
        /// <returns></returns>
        T GetItem(
            TId id);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        T GetItem(
            TId id,
            Func<IQueryable<T>, IQueryable<T>> func);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<T> GetItemAsync(
            TId id);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        Task<T> GetItemAsync(
            TId id,
            Func<IQueryable<T>, IQueryable<T>> func);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> GetItems();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="func"></param>
        /// <returns></returns>
        IEnumerable<T> GetItems(
            Func<IQueryable<T>, IQueryable<T>> func);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<T>> GetItemsAsync();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="func"></param>
        /// <returns></returns>
        Task<IEnumerable<T>> GetItemsAsync(
            Func<IQueryable<T>, IQueryable<T>> func);

        #endregion

        #region Event Handlers
        //No Event Handlers
        #endregion

    }

}
