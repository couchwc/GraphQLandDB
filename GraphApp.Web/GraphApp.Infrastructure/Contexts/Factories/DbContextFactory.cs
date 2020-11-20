using System;
using System.Collections.Generic;
using System.Text;

namespace GraphApp.Infrastructure.Contexts.Factories
{

    /// <summary>
    /// 
    /// </summary>
    public abstract class DbContextFactory<TContext> :
        Microsoft.EntityFrameworkCore.IDbContextFactory<TContext>
        where TContext : Microsoft.EntityFrameworkCore.DbContext
    {

        #region Fields

        /// <summary>
        /// 
        /// </summary>
        private readonly IServiceProvider _provider;

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
        /// <param name="provider"></param>
        public DbContextFactory(IServiceProvider provider)
        {

            //
            if (provider is null)
                throw new ArgumentNullException(nameof(provider), $"Must configure an instance of {nameof(IServiceProvider)}");

            //
            _provider = provider;

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
        /// <returns></returns>
        public TContext CreateDbContext()
        {
         
            //    
            return Microsoft.Extensions.DependencyInjection.ActivatorUtilities.CreateInstance<TContext>(_provider);

        }

        #endregion

        #region Event Handlers
        //No Event Handlers
        #endregion

    }

}
