﻿using GraphApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraphApp.Infrastructure.Repositories
{

    /// <summary>
    /// 
    /// </summary>
    public class OwnerRepository : 
        BaseCRUDRepository<Core.Entities.Owner, Guid>, 
        Core.Interfaces.IOwnerRepository
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
        public OwnerRepository(Contexts.Factories.Application factory) 
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
