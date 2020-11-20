using GraphApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphApp.Infrastructure.Repositories
{

    /// <summary>
    /// 
    /// </summary>
    public class AccountRepository : 
        BaseCRUDRepository<Core.Entities.Account, Guid>, 
        Core.Interfaces.IAccountRepository
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
        public AccountRepository(Contexts.Factories.Application factory)
            : base(factory)
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
