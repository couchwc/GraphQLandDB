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
    class OwnerContextConfiguration : Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<Core.Entities.Owner>
    {

        #region Fields

        /// <summary>
        /// 
        /// </summary>
        private IList<Guid> _ids;

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
        /// <param name="ids"></param>
        public OwnerContextConfiguration(IList<Guid> ids)
        {

            // Check parameters
            if (ids is null)
                throw new ArgumentNullException(paramName: nameof(ids));

            // Capture Ids
            _ids = ids;

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
        public void Configure(EntityTypeBuilder<Owner> builder)
        {

            for (int index = 0; index < _ids.Count() - 1; index++)
            {

                builder.HasData(new Owner()
                {
                    Address = "John Doe's Address",
                    Id = _ids[index],
                    Name = "John Doe"
                }
                );

            }

        }

        #endregion

        #region Event Handlers
        //No Event Handlers
        #endregion

    }

}
