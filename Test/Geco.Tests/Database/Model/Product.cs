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
    public partial class Product
    {
        // Key Properties
        public int ProductID { get; set; }

        // Scalar Properties
        public string Name { get; set; }
        public string ProductNumber { get; set; }
        public bool MakeFlag { get; set; }
        public bool FinishedGoodsFlag { get; set; }
        public string Color { get; set; }
        public short SafetyStockLevel { get; set; }
        public short ReorderPoint { get; set; }
        public decimal StandardCost { get; set; }
        public decimal ListPrice { get; set; }
        public string Size { get; set; }
        public string SizeUnitMeasureCode { get; set; }
        public string WeightUnitMeasureCode { get; set; }
        public decimal? Weight { get; set; }
        public int DaysToManufacture { get; set; }
        public string ProductLine { get; set; }
        public string Class { get; set; }
        public string Style { get; set; }
        public int? ProductSubcategoryID { get; set; }
        public int? ProductModelID { get; set; }
        public DateTime SellStartDate { get; set; }
        public DateTime? SellEndDate { get; set; }
        public DateTime? DiscontinuedDate { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        // Foreign keys
        public ProductModel ProductModel { get; set; }
        public ProductSubcategory ProductSubcategory { get; set; }
        public UnitMeasure UnitMeasureSizeUnitMeasureCode { get; set; }
        public UnitMeasure UnitMeasureWeightUnitMeasureCode { get; set; }

        // Reverse navigation
        public List<BillOfMaterial> BillOfMaterialsComponent { get; set; }
        public List<BillOfMaterial> BillOfMaterialsProductAssembly { get; set; }
        public List<ProductCostHistory> ProductCostHistories { get; set; }
        public List<ProductDocument> ProductDocuments { get; set; }
        public List<ProductInventory> ProductInventories { get; set; }
        public List<ProductListPriceHistory> ProductListPriceHistories { get; set; }
        public List<ProductProductPhoto> ProductProductPhotos { get; set; }
        public List<ProductReview> ProductReviews { get; set; }
        public List<ProductVendor> ProductVendors { get; set; }
        public List<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }
        public List<SpecialOfferProduct> SpecialOfferProducts { get; set; }
        public List<TransactionHistory> TransactionHistories { get; set; }
        public List<WorkOrder> WorkOrders { get; set; }

        public Product()
        {
            BillOfMaterialsComponent = new List<BillOfMaterial>();
            BillOfMaterialsProductAssembly = new List<BillOfMaterial>();
            ProductCostHistories = new List<ProductCostHistory>();
            ProductDocuments = new List<ProductDocument>();
            ProductInventories = new List<ProductInventory>();
            ProductListPriceHistories = new List<ProductListPriceHistory>();
            ProductProductPhotos = new List<ProductProductPhoto>();
            ProductReviews = new List<ProductReview>();
            ProductVendors = new List<ProductVendor>();
            PurchaseOrderDetails = new List<PurchaseOrderDetail>();
            ShoppingCartItems = new List<ShoppingCartItem>();
            SpecialOfferProducts = new List<SpecialOfferProduct>();
            TransactionHistories = new List<TransactionHistory>();
            WorkOrders = new List<WorkOrder>();
        }
    }
}