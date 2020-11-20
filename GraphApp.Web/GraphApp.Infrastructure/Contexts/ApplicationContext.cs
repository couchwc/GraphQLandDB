using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraphApp.Infrastructure.Contexts
{

    /// <summary>
    /// 
    /// </summary>
    public class ApplicationContext : Microsoft.EntityFrameworkCore.DbContext
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
        /// <param name="options"></param>
        public ApplicationContext(Microsoft.EntityFrameworkCore.DbContextOptions options)
            : base(options)
        {
            // ToDo
        }

        #endregion

        #region Destructors
        //No Destructors
        #endregion

        #region Properties

        /// <summary>
        /// 
        /// </summary>
        public DbSet<Core.Entities.Account> Accounts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<Core.Entities.Owner> Owners { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //base.OnModelCreating(modelBuilder);

            var ownerIds = new List<Guid> { Guid.NewGuid(), Guid.NewGuid() };

            modelBuilder.ApplyConfiguration(new Configurations.Owner(ownerIds));
            modelBuilder.ApplyConfiguration(new Configurations.Account(ownerIds));

        }

        #endregion

        #region Event Handlers
        //No Event Handlers
        #endregion

    }

}
