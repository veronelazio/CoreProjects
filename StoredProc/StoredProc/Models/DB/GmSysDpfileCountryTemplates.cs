using System;
using System.Collections.Generic;

namespace StoredProc.Models.DB
{
    public partial class GmSysDpfileCountryTemplates
    {
        public int TplFileId { get; set; }
        public bool? IsActive { get; set; }
        public string FileName { get; set; }
        public string FileDescription { get; set; }
        public string FileStatement { get; set; }
        public bool RowHeader { get; set; }
        public short FileFormat { get; set; }
        public short ColDelimId { get; set; }
        public short RowDelimiter { get; set; }
        public bool? Zip { get; set; }
        public string DesiredFileName { get; set; }
        public int? FileGpId { get; set; }
        public string DaysNotRequired { get; set; }
        public int? FilterId { get; set; }
        public DateTime RecCreateDate { get; set; }
        public DateTime? RecModifyDate { get; set; }
        public int? CountryCode { get; set; }
        public string FileOrder { get; set; }
        public int? GtplFileId { get; set; }
    }
}
