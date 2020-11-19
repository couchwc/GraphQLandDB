using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GraphApp.Core.Entities
{

    /// <summary>
    /// 
    /// </summary>
    public class Owner : BaseEntity<Guid>
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
        //No Constructors
        #endregion

        #region Destructors
        //No Destructors
        #endregion

        #region Properties
        
        /// <summary>
        /// 
        /// </summary>
        public ICollection<Account> Accounts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        #endregion

        #region Methods
        //No Methods
        #endregion

        #region Event Handlers
        //No Event Handlers
        #endregion

    }

}
