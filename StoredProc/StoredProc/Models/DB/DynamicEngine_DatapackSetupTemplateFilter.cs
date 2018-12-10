using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoredProc.Models.DB
{
    public class DynamicEngine_DatapackSetupTemplateFilter
    {
        public int TplFileID { get; set; }
        public string FldNameSrc { get; set; }
        public string OperatorExp { get; set; }
        public string FilterValue { get; set; }
    }
}
