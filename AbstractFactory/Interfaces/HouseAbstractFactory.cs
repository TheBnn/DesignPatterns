namespace Patterns.AbstractFactory.Interfaces
{
	public abstract class HouseAbstractFactory
	{
		/// <summary>
		/// Получить дом
		/// </summary>
		/// <returns></returns>
		public abstract IHouse GetHouse();

		/// <summary>
		/// Получить станлартный дом
		/// </summary>
		/// <returns></returns>
		public abstract IHouse GetDefaultHouse();

		/// <summary>
		/// Получить Стену
		/// </summary>
		/// <returns></returns>
		public abstract IHouseWall GetWall();

		/// <summary>
		/// Получить крышу
		/// </summary>
		/// <returns></returns>
		public abstract IHouseRoof GetRoof();
	}
}