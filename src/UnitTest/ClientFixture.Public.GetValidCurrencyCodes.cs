using System.Collections.Generic;
using System.Linq;
using IndependentReserve.DotNetClientApi.Data;
using NUnit.Framework;

namespace UnitTest
{
    partial class ClientFixture
    {
        [Test]
        public void GetValidPrimaryCurrencyCodes()
        {
            using (var client = CreatePublicClient())
            {
                IEnumerable<CurrencyCode> currencyCodes = client.GetValidPrimaryCurrencyCodes();

                Assert.AreEqual(currencyCodes.Count(),4);
                Assert.IsTrue(currencyCodes.Any(c => c == CurrencyCode.Xbt));
                Assert.IsTrue(currencyCodes.Any(c => c == CurrencyCode.Eth));
                Assert.IsTrue(currencyCodes.Any(c => c == CurrencyCode.Bch));
                Assert.IsTrue(currencyCodes.Any(c => c == CurrencyCode.B2x));
            }
        }

        [Test]
        public void GetValidSecondaryCurrencyCodes()
        {
            using (var client = CreatePublicClient())
            {
                IEnumerable<CurrencyCode> currencyCodes = client.GetValidSecondaryCurrencyCodes();

                Assert.AreEqual(currencyCodes.Count(), 3);
                Assert.IsTrue(currencyCodes.Any(c=> c== CurrencyCode.Aud));
                Assert.IsTrue(currencyCodes.Any(c=> c== CurrencyCode.Usd));
                Assert.IsTrue(currencyCodes.Any(c=> c== CurrencyCode.Nzd));
            }
        }
    }
}
