using System;
using System.Collections.Generic;
using System.Text;

namespace GraphApp.Infrastructure.Contexts.Factories
{
    
    /// <summary>
    /// 
    /// </summary>
    public class Application : DbContextFactory<ApplicationContext>
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
        /// <param name="provider"></param>
        public Application(IServiceProvider provider) : base(provider)
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
        //No Methods
        #endregion

        #region Event Handlers
        //No Event Handlers
        #endregion

    }

}
