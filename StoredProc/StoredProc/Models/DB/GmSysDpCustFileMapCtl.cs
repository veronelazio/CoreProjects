using System;
using System.Collections.Generic;

namespace StoredProc.Models.DB
{
    public partial class GmSysDpCustFileMapCtl
    {
        public string CountryCode { get; set; }
        public string Common { get; set; }
        public int Fileid { get; set; }
        public string FileDescription { get; set; }
        public string GroupType { get; set; }
        public short? DeliveryType { get; set; }
        public string DestinationAddress { get; set; }
        public string Uid { get; set; }
        public string Pwd { get; set; }
        public string RemoteDir { get; set; }
        public int? Ftpport { get; set; }
        public bool? PassiveMode { get; set; }
        public string CustModule { get; set; }
        public string CustModuleDescription { get; set; }
        public string GpPriority { get; set; }
        public string IsActive { get; set; }
        public string DesiredFileName { get; set; }
        public string MailFrom { get; set; }
        public string MailBody { get; set; }
        public string MailSub { get; set; }
        public string DaysNotRequired { get; set; }
        public bool? RowHeader { get; set; }
        public short? RowDelimiter { get; set; }
        public short? ColDelimId { get; set; }
        public bool? GroupZip { get; set; }
        public string GroupFileName { get; set; }
        public string DesiredGroupFileName { get; set; }
    }
}
