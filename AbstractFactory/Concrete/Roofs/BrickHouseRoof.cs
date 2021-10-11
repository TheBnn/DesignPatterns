using Patterns.AbstractFactory.Interfaces;

namespace Patterns.AbstractFactory.Concrete.Roofs
{
	public class BrickHouseRoof : IHouseRoof
	{
		/// <summary>
		/// Переопределение toString на возврат типа крыши кирпичного дома строкой
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return "Brick house roof";
		}
	}
}
