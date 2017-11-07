﻿using System.Linq;
using IndependentReserve.DotNetClientApi.Data;
using NUnit.Framework;

namespace UnitTest
{
    partial class ClientFixture
    {
        [Test]
        public void GetBrokerageFees()
        {
            using (var client = CreatePrivateClient())
            {
                var brokerageFees = client.GetBrokerageFees();

                Assert.IsNotNull(brokerageFees);
                Assert.AreEqual(4, brokerageFees.Count());

                var xbtFee = brokerageFees.FirstOrDefault(f => f.CurrencyCode == CurrencyCode.Xbt);
                Assert.IsNotNull(xbtFee);

                var ethFee = brokerageFees.FirstOrDefault(f => f.CurrencyCode == CurrencyCode.Eth);
                Assert.IsNotNull(ethFee);

                var bchFee = brokerageFees.FirstOrDefault(f => f.CurrencyCode == CurrencyCode.Bch);
                Assert.IsNotNull(bchFee);

                var b2xFee = brokerageFees.FirstOrDefault(f => f.CurrencyCode == CurrencyCode.B2x);
                Assert.IsNotNull(bchFee);
            }
        }
    }
}
