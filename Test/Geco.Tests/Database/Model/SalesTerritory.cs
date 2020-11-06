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
    public partial class SalesTerritory
    {
        // Key Properties
        public int TerritoryID { get; set; }

        // Scalar Properties
        public string Name { get; set; }
        public string CountryRegionCode { get; set; }
        public string Group { get; set; }
        public decimal SalesYTD { get; set; }
        public decimal SalesLastYear { get; set; }
        public decimal CostYTD { get; set; }
        public decimal CostLastYear { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        // Foreign keys
        public CountryRegion CountryRegion { get; set; }

        // Reverse navigation
        public List<Customer> Customers { get; set; }
        public List<SalesOrderHeader> SalesOrderHeaders { get; set; }
        public List<SalesPerson> SalesPeople { get; set; }
        public List<SalesTerritoryHistory> SalesTerritoryHistories { get; set; }
        public List<StateProvince> StateProvinces { get; set; }

        public SalesTerritory()
        {
            Customers = new List<Customer>();
            SalesOrderHeaders = new List<SalesOrderHeader>();
            SalesPeople = new List<SalesPerson>();
            SalesTerritoryHistories = new List<SalesTerritoryHistory>();
            StateProvinces = new List<StateProvince>();
        }
    }
}