namespace Patterns.Decorator.Abstraction
{
	/// <summary>
	/// Дополнение интерфейса
	/// </summary>
	public abstract class PizzaAddon : IPizza
	{
		/// <summary>
		/// Стоимость пиццы
		/// </summary>
		/// <param name="cost"></param>
		/// <returns></returns>
		public abstract decimal GetCost();

		/// <summary>
		/// Экземпляр пиццы
		/// </summary>
		protected readonly IPizza Pizza;

		public PizzaAddon(IPizza pizza)
		{
			Pizza = pizza;
		}
	}
}
