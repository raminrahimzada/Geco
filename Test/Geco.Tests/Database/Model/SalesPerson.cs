// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable UnusedMember.Global
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Geco.Tests.Database.Model
{
    [GeneratedCode("Geco", "1.0.5.0")]
    public partial class SalesPerson
    {
        // Key Properties
        public int BusinessEntityID { get; set; }

        // Scalar Properties
        public int? TerritoryID { get; set; }
        public decimal? SalesQuota { get; set; }
        public decimal Bonus { get; set; }
        public decimal CommissionPct { get; set; }
        public decimal SalesYTD { get; set; }
        public decimal SalesLastYear { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        // Foreign keys
        public Employee Employee { get; set; }
        public SalesTerritory SalesTerritory { get; set; }

        // Reverse navigation
        public List<SalesOrderHeader> SalesOrderHeaders { get; set; }
        public List<SalesPersonQuotaHistory> SalesPersonQuotaHistories { get; set; }
        public List<SalesTerritoryHistory> SalesTerritoryHistories { get; set; }
        public List<Store> Stores { get; set; }

        public SalesPerson()
        {
            SalesOrderHeaders = new List<SalesOrderHeader>();
            SalesPersonQuotaHistories = new List<SalesPersonQuotaHistory>();
            SalesTerritoryHistories = new List<SalesTerritoryHistory>();
            Stores = new List<Store>();
        }
    }
}