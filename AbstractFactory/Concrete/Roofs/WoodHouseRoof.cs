using Patterns.AbstractFactory.Interfaces;

namespace Patterns.AbstractFactory.Concrete.Roofs
{
	public class WoodHouseRoof : IHouseRoof
	{
		/// <summary>
		/// Переопределение toString на получение крыши деревянного дома строкой
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return "Wood house roof";
		}
	}
}
