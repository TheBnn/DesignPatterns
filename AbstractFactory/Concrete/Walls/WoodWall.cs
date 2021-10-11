using Patterns.AbstractFactory.Interfaces;

namespace Patterns.AbstractFactory.Concrete.Walls
{
	public class WoodWall : IHouseWall
	{
		/// <summary>
		/// Переопределение ToString на получение деревянной стены строкой
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return "Wood wall";
		}
	}
}
