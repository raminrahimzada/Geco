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
    public partial class BusinessEntity
    {
        // Key Properties
        public int BusinessEntityID { get; set; }

        // Scalar Properties
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        // Reverse navigation
        public List<BusinessEntityAddress> BusinessEntityAddresses { get; set; }
        public List<BusinessEntityContact> BusinessEntityContacts { get; set; }
        public List<Person> People { get; set; }
        public List<Store> Stores { get; set; }
        public List<Vendor> Vendors { get; set; }

        public BusinessEntity()
        {
            BusinessEntityAddresses = new List<BusinessEntityAddress>();
            BusinessEntityContacts = new List<BusinessEntityContact>();
            People = new List<Person>();
            Stores = new List<Store>();
            Vendors = new List<Vendor>();
        }
    }
}