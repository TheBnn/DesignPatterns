using System;

namespace Command.Receivers
{
	/// <summary>
	/// Скорости вентилятора
	/// </summary>
	public class CeilingFan
	{
		
		public const int HIGH = 3;
		public const int MEDIUM = 2;
		public const int LOW = 1;
		public const int OFF = 0;

		private string _room;
		private int _speed;

		public CeilingFan(string room)
		{
			if (String.IsNullOrEmpty(room))
			{
				throw new ArgumentException(nameof(room));
			}

			_room = room;
			_speed = OFF;
		}

		/// <summary>
		/// Установить высокую скорость
		/// </summary>
		public void High()
		{
			_speed = HIGH;
			Console.WriteLine($"{_room} ceiling fan is High");
		}

		/// <summary>
		/// Установить среднюю скорость
		/// </summary>
		public void Medium()
		{
			_speed = MEDIUM;
			Console.WriteLine($"{_room} ceiling fan is Medium");
		}

		/// <summary>
		/// Установить низкую скорость
		/// </summary>
		public void Low()
		{
			_speed = LOW;
			Console.WriteLine($"{_room} ceiling fan is Low");
		}

		/// <summary>
		/// Выключить
		/// </summary>
		public void Off()
		{
			_speed = OFF;
			Console.WriteLine($"{_room} ceiling fan is Off");
		}

		/// <summary>
		/// Получить текущую скорость
		/// </summary>
		/// <returns></returns>
		public int GetSpeed() => _speed;
	}
}