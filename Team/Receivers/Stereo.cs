using System;

namespace Command.Receivers
{
	/// <summary>
	/// Магнитола
	/// </summary>
	public class Stereo
	{
		/// <summary>
		/// Комната
		/// </summary>
		private readonly string _room;

		public Stereo(string room)
		{
			if (String.IsNullOrEmpty(room))
			{
				throw new ArgumentException(nameof(room));
			}

			_room = room;
		}

		/// <summary>
		/// Включить магнитолу
		/// </summary>
		public void On()
		{
			Console.WriteLine($"{_room} Stereo is On");
		}

		/// <summary>
		/// Выключить магнитолу
		/// </summary>
		public void Off()
		{
			Console.WriteLine($"{_room} Stereo is Off");
		}

		/// <summary>
		/// Поставить диск
		/// </summary>
		public void SetCD()
		{
			Console.WriteLine($"{_room} Stereo - set CD");
		}

		/// <summary>
		/// Установить громкость магнитолы
		/// </summary>
		/// <param name="volume"></param>
		public void SetVolume(int volume)
		{
			if(volume <= 0)
			{
				throw new ArgumentOutOfRangeException("More or equal than 0");
			}

			Console.WriteLine($"{_room} Stereo - set volume {volume}");
		}
	}
}