using System.Collections.Generic;
using Patterns.AbstractFactory.Interfaces;
using Patterns.AbstractFactory.Concrete.Houses;
using Patterns.AbstractFactory.Concrete.Roofs;
using Patterns.AbstractFactory.Concrete.Walls;

namespace Patterns.AbstractFactory.Concrete
{
	public class BrickHouseFactory : HouseAbstractFactory
	{
		/// <summary>
		/// Вернуть дом
		/// </summary>
		/// <returns></returns>
		public override IHouse GetHouse()
		{
			return new BrickHouse();
		}

		/// <summary>
		/// Вернуть стандартный дом
		/// </summary>
		/// <returns></returns>
		public override IHouse GetDefaultHouse()
		{
			var walls = new List<IHouseWall>
			{
				new BrickWall(),
				new BrickWall(),
				new BrickWall(),
				new BrickWall()
			};

			var roofs = new List<IHouseRoof>
			{
				new BrickHouseRoof()
			};

			return new BrickHouse(walls, roofs);
		}


		/// <summary>
		/// Получить крышу
		/// </summary>
		/// <returns></returns>
		public override IHouseRoof GetRoof()
		{
			return new BrickHouseRoof();
		}

		/// <summary>
		/// Получить стену 
		/// </summary>
		/// <returns></returns>
		public override IHouseWall GetWall()
		{
			return new BrickWall();
		}
	}
}