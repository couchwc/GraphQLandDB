using System;
using System.Collections.Generic;
using System.Text;

namespace GraphApp.Infrastructure.Repositories
{

    /// <summary>
    /// 
    /// </summary>
    public class AccountRepository : BaseRepository, Core.Interfaces.IAccountRepository
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
        public AccountRepository(Contexts.ApplicationContext context) :
            base(context)
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
