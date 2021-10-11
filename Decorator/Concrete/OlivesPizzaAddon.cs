using Patterns.Decorator.Abstraction;

namespace Patterns.Decorator.Concrete
{
	public class OlivesPizzaAddon : PizzaAddon
	{

		/// <summary>
		/// Получить стоимость Пиццы
		/// </summary>
		/// <param name="cost"></param>
		/// <returns></returns>
		public override decimal GetCost()
		{
			return Pizza.GetCost() + 1m;
		}

		public OlivesPizzaAddon(IPizza baseComponent)
		   : base(baseComponent)
		{ }
	}
}
