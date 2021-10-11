namespace Patterns.AbstractFactory.Interfaces
{
	public interface IHouse
	{
		/// <summary>
		/// Добавить стену
		/// </summary>
		/// <param name="wall"></param>
		void AddWall(IHouseWall wall);

		/// <summary>
		/// Добавить крышу
		/// </summary>
		/// <param name="roof"></param>
		void AddRoof(IHouseRoof roof);
	}
}
