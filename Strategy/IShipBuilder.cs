using System;

namespace Strategy
{
	/// <summary>
	/// Интерфейс создания кораблей
	/// </summary>
	public interface IShipBuilder
	{
		/// <summary>
		/// Создать корабль
		/// </summary>
		/// <param name="shipName"></param>
		/// <returns></returns>
		Ship CreateShip(string shipName);
	}
}
