using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GraphApp.Core.Entities
{

    /// <summary>
    /// 
    /// </summary>
    public class Account : BaseEntity<Guid>
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
        [Required(ErrorMessage = "Type is required.")]
        public Enums.TypeOfAccount Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ForeignKey("OwnerId")]
        public Guid OwnerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Owner Owner { get; set; }

        #endregion

        #region Methods
        //No Methods
        #endregion

        #region Event Handlers
        //No Event Handlers
        #endregion

    }

}
