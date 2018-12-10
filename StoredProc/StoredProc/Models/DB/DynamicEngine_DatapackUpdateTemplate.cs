using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoredProc.Models.DB
{
    public class DynamicEngine_DatapackUpdateTemplate
    {
        public int TplFileID { get; set; }
        public string FileName { get; set; }
        public string DesiredFileName { get; set; }
        public string FileStatement { get; set; }
        public string FileOrder { get; set; }
    }
}
