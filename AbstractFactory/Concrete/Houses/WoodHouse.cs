using System;
using System.Linq;
using System.Collections.Generic;
using Patterns.AbstractFactory.Interfaces;

namespace Patterns.AbstractFactory.Concrete.Houses
{

	/// <summary>
	/// Деревянный дом
	/// </summary>
	public class WoodHouse : IHouse
	{
		/// <summary>
		/// Коллекция стен
		/// </summary>
		private ICollection<IHouseWall> _walls;

		/// <summary>
		/// Коллекция крыш
		/// </summary>
		private ICollection<IHouseRoof> _roofs;

		public WoodHouse()
		{
			_walls = new List<IHouseWall>();
			_roofs = new List<IHouseRoof>();
		}

		/// <summary>
		/// Параметризированный конструктор дома по стенам и крыше
		/// </summary>
		/// <param name="walls">Коллекция стен</param>
		/// <param name="roofs">Коллекция крыш</param>
		public WoodHouse(IEnumerable<IHouseWall> walls,
			 IEnumerable<IHouseRoof> roofs)
		{
			_walls = walls.ToList();
			_roofs = roofs.ToList();
		}

		/// <summary>
		/// Добавить стену
		/// </summary>
		/// <param name="wall"></param>
		public void AddWall(IHouseWall wall) => _walls.Add(wall);

		/// <summary>
		/// Добавить крышу
		/// </summary>
		/// <param name="roof"></param>
		public void AddRoof(IHouseRoof roof) => _roofs.Add(roof);

		/// <summary>
		/// Возврат построенного дома в текстовом виде
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			var s = "";
			foreach (var w in _walls)
			{
				s += $"{w.ToString()} {Environment.NewLine}";
			}
			
			foreach (var r in _roofs)
			{
				s += $"{r.ToString()} {Environment.NewLine}";
			}

			return $"Wood house with: {Environment.NewLine}{s}";
		}
	}
}
