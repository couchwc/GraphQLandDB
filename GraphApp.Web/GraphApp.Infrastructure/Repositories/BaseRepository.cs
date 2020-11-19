using System;
using System.Collections.Generic;
using System.Text;

namespace GraphApp.Infrastructure.Repositories
{

    /// <summary>
    /// 
    /// </summary>
    public abstract class BaseRepository
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

        //
        public BaseRepository(Contexts.ApplicationContext context)
        {

            // Check parameters
            if (context is null)
                throw new ArgumentNullException(paramName: nameof(context));

            _applicationContext = context;

        }

        #endregion

        #region Destructors
        //No Destructors
        #endregion

        #region Properties

        /// <summary>
        /// 
        /// </summary>
        public Contexts.ApplicationContext ApplicationContext => _applicationContext;
        private Contexts.ApplicationContext _applicationContext;

        #endregion

        #region Methods
        //No Methods
        #endregion

        #region Event Handlers
        //No Event Handlers
        #endregion

    }

}
