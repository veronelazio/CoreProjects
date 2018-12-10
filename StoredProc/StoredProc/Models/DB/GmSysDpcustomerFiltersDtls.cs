using System;
using System.Collections.Generic;

namespace StoredProc.Models.DB
{
    public partial class GmSysDpcustomerFiltersDtls
    {
        public int? FilterId { get; set; }
        public string FldNameSrc { get; set; }
        public int OperatorId { get; set; }
        public string FilterValue { get; set; }
        public int? FilterDtlId { get; set; }
        public int RowId { get; set; }
    }
}
