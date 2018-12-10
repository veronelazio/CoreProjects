using System;
using System.Collections.Generic;

namespace StoredProc.Models.DB
{
    public partial class GmSysDpfieldCountryTemplates
    {
        public int TplFileId { get; set; }
        public int TplFldId { get; set; }
        public bool IsActive { get; set; }
        public string FldName { get; set; }
        public string FldNameSrc { get; set; }
        public string FldNameDst { get; set; }
        public string FldStatement { get; set; }
        public string FldDescription { get; set; }
        public short FldOrder { get; set; }
        public int? FldSize { get; set; }
        public short? FldScale { get; set; }
        public int? FldMaxSize { get; set; }
        public string FldDecimalSymbol { get; set; }
        public string FldPadSymbol { get; set; }
        public string FldPadType { get; set; }
        public int? DateFormatId { get; set; }
        public string TextQualifier { get; set; }
        public int? FormatTypeId { get; set; }
        public bool? IsMandatory { get; set; }
        public DateTime? RecCreateDate { get; set; }
        public DateTime? RecModifyDate { get; set; }
    }
}
