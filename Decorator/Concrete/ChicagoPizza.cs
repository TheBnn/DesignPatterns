using Patterns.Decorator.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Decorator.Concrete
{
	public class ChicagoPizza : IPizza
	{
		/// <summary>
		/// Получить стоимость Пиццы
		/// </summary>
		/// <param name="cost"></param>
		/// <returns></returns>
		public decimal GetCost()
		{
			return 10m;
		}
	}
}
