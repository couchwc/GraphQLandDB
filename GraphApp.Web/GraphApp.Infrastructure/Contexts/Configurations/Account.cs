using GraphApp.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace GraphApp.Infrastructure.Contexts.Configurations
{

    /// <summary>
    /// 
    /// </summary>
    class Account : Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<Core.Entities.Account>
    {

        #region Fields

        /// <summary>
        /// 
        /// </summary>
        private IList<Guid> _ownerIds;

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
        /// <param name="ownerIds"></param>
        public Account(IList<Guid> ownerIds)
        {

            // Check parameters
            if (ownerIds is null)
                throw new ArgumentNullException(paramName: nameof(ownerIds));

            // Capture Ids
            _ownerIds = ownerIds;

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
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<Core.Entities.Account> builder)
        {

            //
            for (int ownerIdsIndex = 0; ownerIdsIndex < _ownerIds.Count() - 1; ownerIdsIndex++)
            {

                //
                for (int index = 0; index < 3; index++)
                {

                    //
                    var typeOfAccount = GetTypeOfAccount(index);

                    //
                    builder.HasData(new Core.Entities.Account()
                    {
                        Id = Guid.NewGuid(),
                        Description = $"{typeOfAccount.ToString()} account for our users",
                        OwnerId = _ownerIds[ownerIdsIndex],
                        Type = typeOfAccount
                    }
                    );

                }

            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>
        /// 
        /// </returns>
        private static Core.Enums.TypeOfAccount GetTypeOfAccount(int index)
        {

            switch (index)
            {

                case 0:
                    return Core.Enums.TypeOfAccount.Cash;

                case 1:
                    return Core.Enums.TypeOfAccount.Expense;

                case 2:
                    return Core.Enums.TypeOfAccount.Income;

                case 3:
                    return Core.Enums.TypeOfAccount.Savings;

                default:
                    return Core.Enums.TypeOfAccount.Cash;

            }

        }

        #endregion

        #region Event Handlers
        //No Event Handlers
        #endregion

    }

}
