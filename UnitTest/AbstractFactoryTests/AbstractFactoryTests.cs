using NUnit.Framework;
using Patterns.AbstractFactory.Concrete;
using Patterns.AbstractFactory.Concrete.Houses;
using Patterns.AbstractFactory.Concrete.Roofs;
using Patterns.AbstractFactory.Concrete.Walls;
using System.Collections.Generic;

namespace Patterns.Tests
{
	/// <summary>
	/// Тесты абстрактной фабрики
	/// </summary>
	[TestFixture]
	public class AbstractFactoryTests
	{
		/// <summary>
		/// Должен вернуть валидный дом
		/// </summary>
		[Test]
		public void WoodFactoryReturnValidProducts()
		{

			var s = new List<Child> { 
				new Child { } 
			};
			Method(s);

			var factory = new WoodHouseFactory();
			var house = factory.GetDefaultHouse();
			var wall = factory.GetWall();
			var roof = factory.GetRoof();

			Assert.IsTrue(house is WoodHouse);
			Assert.IsTrue(wall is WoodWall);
			Assert.IsTrue(roof is WoodHouseRoof);
		}


		private void Method<T>(ICollection<T> collection)
			where T : Parent
		{

		}
	}
}
