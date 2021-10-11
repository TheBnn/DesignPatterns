using Patterns.Decorator.Abstraction;
using System;

namespace Patterns.Decorator.Concrete
{
	public class NewYorkPizza : IPizza
	{
		/// <summary>
		/// Получить стоимость Пиццы
		/// </summary>
		/// <param name="cost"></param>
		/// <returns></returns>
		public decimal GetCost()
		{
			return 12m;
		}
	}
}
