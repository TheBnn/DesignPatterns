using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
	public class MotherCoreShip
	{
		private IShipBuilder _builder;

		public IShipBuilder Builder
		{
			get => _builder;
			set => _builder = value ?? throw new ArgumentNullException("Отсутствует создатель");
		}

		public MotherCoreShip(IShipBuilder builder)
		{
			Builder = builder ?? throw new ArgumentNullException(nameof(builder));
		}

		/// <summary>
		/// Создать корабль. 
		/// </summary>
		/// <param name="shipName">Название корабля</param>
		/// <returns></returns>
		public Ship CreateShip(string shipName)
		{
			if (String.IsNullOrEmpty(shipName))
			{
				throw new NotImplementedException();
			}
			return _builder.CreateShip(shipName);
		}

	}
}
