using System;

namespace Command.Receivers
{
	/// <summary>
	/// Светильник
	/// </summary>
	public class Light
	{
		/// <summary>
		/// Комната
		/// </summary>
		private readonly string _room;

		public Light(string room)
		{
			if (String.IsNullOrEmpty(room))
			{
				throw new ArgumentException(nameof(room));
			}

			_room = room;
		}

		/// <summary>
		/// Включить свет
		/// </summary>
		public void On()
		{
			Console.WriteLine($"{_room}: Lights is On");
		}

		/// <summary>
		/// Выключить свет
		/// </summary>
		public void Off()
		{
			Console.WriteLine($"{_room} Lights is Off");
		}
	}
}