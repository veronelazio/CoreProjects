using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using StoredProc.Models;
using StoredProc.Models.DB;

namespace StoredProc.Models
{
    public class DataPackViewModel
    {

        #region Properties  

        /// <summary>  
        /// Gets or sets FileGpIDproperty.  
        /// </summary>  
        [Required]
        [Display(Name = "FileGpID")]
        public int FileGpID { get; set; }

      
        /// <summary>  
        /// Gets or sets to product detail by product Id property.  
        /// </summary>  
        [Display(Name = "File Group Detail")]
        public get_Check_DP FileGpIDDetail { get; set; }

        #endregion

    }

}
