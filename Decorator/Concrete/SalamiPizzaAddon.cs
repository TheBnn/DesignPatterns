using Patterns.Decorator.Abstraction;

namespace Patterns.Decorator.Concrete
{
	public class SalamiPizzaAddon : PizzaAddon
	{
		/// <summary>
		/// Получить стоимость Пиццы
		/// </summary>
		/// <returns></returns>
		public override decimal GetCost()
		{
			return Pizza.GetCost() + 2m;
		}

		public SalamiPizzaAddon(IPizza baseComponent)
		   : base(baseComponent)
		{ }
	}
}
