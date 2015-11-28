using GW2CSharp;
using GW2CSharp.V2.Authenticated.Account;
using NUnit.Framework;
using System;
using System.Linq;

namespace Tests.V2.Authenticated
{
    [TestFixture]
    public class AccountUnitTest
    {
        [Test]
        public void ShouldReturnCorrectAccount()
        {
            Account account = GW2Api.V2.Account.Get("D0F26FAD-FAC1-E649-A177-CFEC0297C5B49AF875D9-CFC7-434B-8FF1-DC11D0B4A65D");

            Assert.AreEqual(account.Access, AccountType.GuildWars2);
            Assert.AreEqual(account.Created, new DateTime(2015, 8, 5, 21, 51, 00));
            Assert.GreaterOrEqual(account.FractalLevel, 7);
            Assert.GreaterOrEqual(account.Guilds.Count(), 1);
            Assert.GreaterOrEqual(account.Id, Guid.Parse("907e7008bc3be511a22a78e7d1936ef0"));
            Assert.GreaterOrEqual(account.Name, "Pantsu.1537");
            Assert.GreaterOrEqual(account.World.Name, "Vizunah Sqaure [FR]");
        }
    }
}
