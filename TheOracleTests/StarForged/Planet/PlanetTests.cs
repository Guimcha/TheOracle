﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheOracle.StarForged;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using TheOracle.Core;
using TheOracle.StarForged.Planets;
using TheOracle.GameCore.Oracle;
using System.Linq;

namespace TheOracle.StarForged.Tests
{
    [TestClass()]
    public class PlanetTests
    {
        [TestMethod()]
        public void GeneratePlanetTest()
        {
            var services = new ServiceCollection().AddSingleton( new OracleService().Load()).BuildServiceProvider();

            for (int i = 0; i < 1000; i++)
            {
                var planet = Planet.GeneratePlanet("P-" + i.ToString(), SpaceRegion.Expanse, services, 0);

                planet = planet.RevealCloserLook().RevealCloserLook().RevealLife();

                var embed = planet.GetEmbedBuilder();
            }
        }
    }
}