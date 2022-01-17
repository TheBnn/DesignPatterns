namespace Strategy
{
	/// <summary>
	/// Корабль
	/// </summary>
	public class Ship
	{
		/// <summary>
		/// Название корабля
		/// </summary>
		public string ShipName { get; set; }

		/// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="shipName">Название корабля</param>
		public Ship(string shipName)
		{
			ShipName = shipName;
		}
	}
}