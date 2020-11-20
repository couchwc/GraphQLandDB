using System;
using System.Collections.Generic;
using System.Text;

namespace GraphApp.Infrastructure.GQL.Schemas
{

    /// <summary>
    /// 
    /// </summary>
    public class Application : GraphQL.Types.Schema
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
        /// <param name="resolver"></param>
        public Application(IServiceProvider resolver) //IDependencyResolver resolver
            : base(resolver)
        {
            //ToDo
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
