namespace Patterns.Decorator.Abstraction
{

	/// <summary>
	/// Некий набор методов пиццы
	/// </summary>
	public interface IPizza
	{
		/// <summary>
		/// Стоимость пиццы
		/// </summary>
		/// <returns></returns>
		decimal GetCost();
	}
}
