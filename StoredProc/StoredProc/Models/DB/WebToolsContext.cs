using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace StoredProc.Models.DB
{
    public partial class WebToolsContext : DbContext
    {
        public WebToolsContext()
        {
        }

        public WebToolsContext(DbContextOptions<WebToolsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<GmSysDpCustFileMapCtl> GmSysDpCustFileMapCtl { get; set; }
        public virtual DbSet<GmSysDpcustomerFiltersDtls> GmSysDpcustomerFiltersDtls { get; set; }
        public virtual DbSet<GmSysDpfieldCountryTemplates> GmSysDpfieldCountryTemplates { get; set; }
        public virtual DbSet<GmSysDpfileCountryTemplates> GmSysDpfileCountryTemplates { get; set; }
        public virtual DbSet<get_Check_DP> Get_Check_DP { get; set; }


        // Moved to Statup.cs using public StoredProcContext(DbContextOptions<StoredProcContext> options): base(options) below

        //        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //        {
        //            if (!optionsBuilder.IsConfigured)
        //            {
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
        //                optionsBuilder.UseSqlServer("server=usdevsqdb05;Database=WebTools;Trusted_Connection=True;user id=SQLADMIN;password='1234';");
        //            }
        //        }
        public partial class StoredProcContext : DbContext
        {
            public StoredProcContext(DbContextOptions<StoredProcContext> options)
                : base(options)
            {
            }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<GmSysDpCustFileMapCtl>(entity =>
                {
                    entity.HasKey(e => e.Fileid);

                    entity.ToTable("Gm_SYS_DpCustFileMap_Ctl");

                    entity.Property(e => e.Fileid).ValueGeneratedNever();

                    entity.Property(e => e.ColDelimId).HasColumnName("ColDelimID");

                    entity.Property(e => e.Common)
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    entity.Property(e => e.CountryCode)
                        .HasMaxLength(4)
                        .IsUnicode(false);

                    entity.Property(e => e.CustModule)
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    entity.Property(e => e.CustModuleDescription)
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    entity.Property(e => e.DaysNotRequired)
                        .HasMaxLength(13)
                        .IsUnicode(false);

                    entity.Property(e => e.DesiredFileName)
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    entity.Property(e => e.DesiredGroupFileName).HasMaxLength(100);

                    entity.Property(e => e.DestinationAddress)
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    entity.Property(e => e.FileDescription)
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    entity.Property(e => e.Ftpport).HasColumnName("FTPPort");

                    entity.Property(e => e.GpPriority)
                        .HasMaxLength(2)
                        .IsUnicode(false);

                    entity.Property(e => e.GroupFileName).HasMaxLength(100);

                    entity.Property(e => e.GroupType)
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    entity.Property(e => e.GroupZip).HasDefaultValueSql("((0))");

                    entity.Property(e => e.IsActive)
                        .HasColumnName("isActive")
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    entity.Property(e => e.MailBody).HasMaxLength(2200);

                    entity.Property(e => e.MailFrom)
                        .HasMaxLength(300)
                        .IsUnicode(false);

                    entity.Property(e => e.MailSub).HasMaxLength(300);

                    entity.Property(e => e.Pwd)
                        .HasColumnName("PWD")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    entity.Property(e => e.RemoteDir)
                        .HasColumnName("RemoteDIR")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    entity.Property(e => e.Uid)
                        .HasColumnName("UID")
                        .HasMaxLength(50)
                        .IsUnicode(false);
                });

                modelBuilder.Entity<GmSysDpcustomerFiltersDtls>(entity =>
                {
                    entity.HasKey(e => e.RowId);

                    entity.ToTable("GM_Sys_DPCustomerFiltersDtls");

                    entity.HasIndex(e => new { e.FilterId, e.FilterDtlId })
                        .HasName("UQ_GM_Sys_DPCustomersFiltersDtls_FilterID_FilterDtlID")
                        .IsUnique();

                    entity.Property(e => e.RowId).HasColumnName("RowID");

                    entity.Property(e => e.FilterId).HasColumnName("FilterID");

                    entity.Property(e => e.FilterValue).HasMaxLength(2000);

                    entity.Property(e => e.FldNameSrc)
                        .IsRequired()
                        .HasMaxLength(200);

                    entity.Property(e => e.OperatorId).HasColumnName("OperatorID");
                });

                modelBuilder.Entity<GmSysDpfieldCountryTemplates>(entity =>
                {
                    entity.HasKey(e => new { e.TplFileId, e.TplFldId })
                        .ForSqlServerIsClustered(false);

                    entity.ToTable("GM_Sys_DPFieldCountryTemplates");

                    entity.Property(e => e.TplFileId).HasColumnName("TplFileID");

                    entity.Property(e => e.TplFldId).HasColumnName("TplFldID");

                    entity.Property(e => e.DateFormatId).HasColumnName("DateFormatID");

                    entity.Property(e => e.FldDecimalSymbol)
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    entity.Property(e => e.FldDescription).HasMaxLength(1000);

                    entity.Property(e => e.FldName)
                        .IsRequired()
                        .HasMaxLength(200);

                    entity.Property(e => e.FldNameDst).HasMaxLength(200);

                    entity.Property(e => e.FldNameSrc).HasMaxLength(200);

                    entity.Property(e => e.FldPadSymbol)
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    entity.Property(e => e.FldPadType)
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    entity.Property(e => e.FldStatement)
                        .IsRequired()
                        .HasMaxLength(2000);

                    entity.Property(e => e.FormatTypeId).HasColumnName("FormatTypeID");

                    entity.Property(e => e.IsActive).HasColumnName("isActive");

                    entity.Property(e => e.IsMandatory).HasColumnName("isMandatory");

                    entity.Property(e => e.RecCreateDate)
                        .HasColumnName("recCreateDate")
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    entity.Property(e => e.RecModifyDate)
                        .HasColumnName("recModifyDate")
                        .HasColumnType("datetime");

                    entity.Property(e => e.TextQualifier)
                        .HasMaxLength(1)
                        .IsUnicode(false);
                });

                modelBuilder.Entity<GmSysDpfileCountryTemplates>(entity =>
                {
                    entity.HasKey(e => e.TplFileId);

                    entity.ToTable("GM_Sys_DPFileCountryTemplates");

                    entity.Property(e => e.TplFileId).HasColumnName("TplFileID");

                    entity.Property(e => e.ColDelimId).HasColumnName("ColDelimID");

                    entity.Property(e => e.DaysNotRequired)
                        .HasMaxLength(13)
                        .IsUnicode(false);

                    entity.Property(e => e.DesiredFileName).HasMaxLength(550);

                    entity.Property(e => e.FileDescription).HasMaxLength(500);

                    entity.Property(e => e.FileGpId).HasColumnName("FileGpID");

                    entity.Property(e => e.FileName)
                        .IsRequired()
                        .HasMaxLength(200);

                    entity.Property(e => e.FileOrder)
                        .HasMaxLength(1000)
                        .IsUnicode(false);

                    entity.Property(e => e.FileStatement)
                        .IsRequired()
                        .HasMaxLength(2000)
                        .IsUnicode(false);

                    entity.Property(e => e.FilterId).HasColumnName("FilterID");

                    entity.Property(e => e.GtplFileId).HasColumnName("GTplFileID");

                    entity.Property(e => e.IsActive).HasColumnName("isActive");

                    entity.Property(e => e.RecCreateDate)
                        .HasColumnName("recCreateDate")
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    entity.Property(e => e.RecModifyDate)
                        .HasColumnName("recModifyDate")
                        .HasColumnType("datetime");

                    entity.Property(e => e.Zip).HasColumnName("zip");

                });

                modelBuilder.Query<get_Check_DP>();

            }

        }
        #region Get product by ID store procedure method.  

        /// <summary>  
        /// Get FileGpID by ID store procedure method.  
        /// </summary>  
        ///// <param name="FileGpID">Product ID value parameter</param>  
        /// <returns>Returns - List of product by ID</returns>  
        //public async Task<List<get_Check_DP>> Get_Check_DPAsync(string CustomerID)
        //{
        //    // Initialization.  
        //    List<get_Check_DP> lst = new List<get_Check_DP>();

        //    try
        //    {
        //        // Settings.  
        //        SqlParameter customeridParam = new SqlParameter("@CustomerID", CustomerID.ToString() ?? (object)DBNull.Value);

        //        // Processing.  
        //        string sqlQuery = "EXEC [dbo].[get_Check_DP] " +
        //                            "@CustomerID";

        //        lst = await this.Query<get_Check_DP>().FromSql(sqlQuery, usernameParam).ToListAsync();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

        //    // Info.  
        //    return lst;
        //}

        #endregion
    }
}
  

