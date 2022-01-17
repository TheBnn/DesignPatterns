using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
	/// <summary>
	/// Создатель кораблей шахтеров
	/// </summary>
	public class MinerBuilder : IShipBuilder
	{
		/// <summary>
		/// Создать корабль
		/// </summary>
		/// <param name="shipName">Название корабля</param>
		/// <returns></returns>
		public Ship CreateShip(string shipName)
		{
			if (String.IsNullOrEmpty(shipName))
			{
				throw new NotImplementedException(nameof(shipName));
			}
			return new Ship(shipName);
		}
	}
}
