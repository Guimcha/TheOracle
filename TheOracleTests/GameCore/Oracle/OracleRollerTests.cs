﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using TheOracle.Core;

namespace TheOracle.GameCore.Oracle.Tests
{
    [TestClass()]
    public class OracleRollerTests
    {
        [TestMethod()]
        [TestCategory("Integration")]
        public void BuildRollResultsTest()
        {
            var oracleService = new OracleService();

            oracleService.RandomRow("Action", GameName.Ironsworn);
            oracleService.RandomRow("Theme", GameName.Ironsworn);

            Assert.ThrowsException<ArgumentException>(() => oracleService.RandomRow("Action"));
        }

        [TestMethod()]
        public void BuildRollResultsTest1()
        {
            var services = new ServiceCollection().AddSingleton<OracleService>().BuildServiceProvider();

            for (int i = 0; i < 100; i++)
            {
                var rand = new Random(i);
                var roller = new OracleRoller(services, GameName.Starforged, rand).BuildRollResults("sso");
                Console.WriteLine(string.Join(", ", roller.RollResultList.Select(rr => rr.Result.Description)));
            }
        }
    }
}