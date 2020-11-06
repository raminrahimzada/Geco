#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace Geco.Tests.Database.Model
{
    [GeneratedCode("Geco", "1.0.5.0")]
    public partial class Currency
    {
        // Key Properties
        public string CurrencyCode { get; set; }

        // Scalar Properties
        public string Name { get; set; }
        public DateTime ModifiedDate { get; set; }

        // Reverse navigation
        public List<CountryRegionCurrency> CountryRegionCurrencies { get; set; }
        public List<CurrencyRate> CurrencyRatesFromCurrencyCode { get; set; }
        public List<CurrencyRate> CurrencyRatesToCurrencyCode { get; set; }

        public Currency()
        {
            CountryRegionCurrencies = new List<CountryRegionCurrency>();
            CurrencyRatesFromCurrencyCode = new List<CurrencyRate>();
            CurrencyRatesToCurrencyCode = new List<CurrencyRate>();
        }
    }
}