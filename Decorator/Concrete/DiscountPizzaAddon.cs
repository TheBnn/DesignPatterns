using Patterns.Decorator.Abstraction;
using System;

namespace Patterns.Decorator.Concrete
{
	public class DiscountPizzaAddon : PizzaAddon
	{
		private decimal DiscountAmount => 2.5m;

		/// <summary>
		/// Получить стоимость Пиццы
		/// </summary>
		/// <returns></returns>
		public override decimal GetCost()
		{

			return Pizza.GetCost() - (Pizza.GetCost() * DiscountAmount / 100);
		}

		public DiscountPizzaAddon(IPizza baseComponent)
		   : base(baseComponent)
		{ }
	}
}
