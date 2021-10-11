using System.Collections.Generic;
using Patterns.AbstractFactory.Interfaces;
using Patterns.AbstractFactory.Concrete.Houses;
using Patterns.AbstractFactory.Concrete.Roofs;
using Patterns.AbstractFactory.Concrete.Walls;

namespace Patterns.AbstractFactory.Concrete
{
	public class WoodHouseFactory : HouseAbstractFactory
	{
		/// <summary>
		/// Получить дом
		/// </summary>
		/// <returns></returns>
		public override IHouse GetHouse()
		{
			return new WoodHouse();
		}

		/// <summary>
		/// Получить стандартный дом
		/// </summary>
		/// <returns></returns>
		public override IHouse GetDefaultHouse()
		{
			var walls = new List<IHouseWall>
			{
				new WoodWall(),
				new WoodWall(),
				new WoodWall(),
				new WoodWall()
			};

			var roofs = new List<IHouseRoof>
			{
				new WoodHouseRoof()
			};

			return new WoodHouse(walls, roofs);
		}

		/// <summary>
		/// Получить крышу
		/// </summary>
		/// <returns></returns>
		public override IHouseRoof GetRoof()
		{
			return new WoodHouseRoof();
		}

		/// <summary>
		/// Получить стену
		/// </summary>
		/// <returns></returns>
		public override IHouseWall GetWall()
		{
			return new WoodWall();
		}
	}
}