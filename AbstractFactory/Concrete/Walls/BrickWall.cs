using Patterns.AbstractFactory.Interfaces;

namespace Patterns.AbstractFactory.Concrete.Walls
{
	public class BrickWall : IHouseWall
	{
		/// <summary>
		/// Переопределение ToString на получение кирпичной стены строкой
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return "Brick wall";
		}
	}
}
