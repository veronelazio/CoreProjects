using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoredProc.Models.DB
{
    public class DynamicEngine_DatapackCopyTemplate
    {
        public int TplFileID { get; set; }
        public string CountryCode { get; set; }
        public string FileDescription { get; set; }
        public int CountryCode_To { get; set; }
        public string FileDescription_To { get; set; }
        public int TplFileID_To { get; set; }
    }
}
