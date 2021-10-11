using Patterns.Decorator.Abstraction;
using System;

namespace Patterns.Decorator.Concrete
{
	public class HamPizzaAddon : PizzaAddon
	{
		/// <summary>
		/// Получить стоимость пиццы 
		/// </summary>
		/// <returns></returns>
		public override decimal GetCost()
		{
			return Pizza.GetCost() + 1m;
		}

		public HamPizzaAddon(IPizza baseComponent)
		   : base(baseComponent)
		{ }
	}
}
