using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoredProc.Models.DB
{
    public class DynamicEngine_DatapackUpdateFieldTemplate
    {
        public int TplFileID { get; set; }
        public int TplFldID { get; set; }
        public string FldName { get; set; }
        public string FldNameSrc { get; set; }
        public string FldNameDst { get; set; }
        public string FldStatement { get; set; }
        public string FldDescription { get; set; }
        public int FldOrder { get; set; }
        public int isActive { get; set; }
    }
}
