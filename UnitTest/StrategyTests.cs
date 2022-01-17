using NUnit.Framework;
using Strategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest
{
	/// <summary>
	/// Тестирование стратегии
	/// </summary>
	[TestFixture]
	public class StrategyTests
	{
		/// <summary>
		/// Должен создать верные сущности кораблей.
		/// </summary>
		[Test]
		public void ShouldGenerateValidShips()
		{
			var engeneerBuilder = new EngeneerBuilder();
			var fighterBuilder = new FighterBuilder();
			var minerBuilder = new MinerBuilder();

			var reportService = new MotherCoreShip(minerBuilder);

			var report = reportService.CreateShip("Miner");
			Assert.AreEqual(new Ship("Miner").ShipName, report.ShipName);


			reportService.Builder = fighterBuilder;
			report = reportService.CreateShip("Fighter");
			Assert.AreEqual(new Ship("Fighter").ShipName, report.ShipName);

			reportService.Builder = engeneerBuilder;
			report = reportService.CreateShip("Engeneer");
			Assert.AreEqual(new Ship("Engeneer").ShipName, report.ShipName);
		}
	}
}
