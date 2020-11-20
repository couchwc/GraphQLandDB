using System;
using System.Collections.Generic;
using System.Text;

namespace GraphApp.Infrastructure.GQL.Types
{

    /// <summary>
    /// 
    /// </summary>
    public class Owner : GraphQL.Types.ObjectGraphType<Core.Entities.Owner>
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
        public Owner()
        {

            Field(item => item.Id, type: typeof(GraphQL.Types.IdGraphType)).Description($"{nameof(Core.Entities.Owner.Id)} property from the {nameof(Core.Entities.Owner)} object.");
            Field(item => item.Name).Description($"{nameof(Core.Entities.Owner.Name)} property from the {nameof(Core.Entities.Owner)} object.");
            Field(item => item.Address).Description($"{nameof(Core.Entities.Owner.Address)} property from the {nameof(Core.Entities.Owner)} object.");

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
