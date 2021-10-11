using System;

namespace Command.Receivers
{
	/// <summary>
	/// Дверь каража
	/// </summary>
	public class GarageDoor
	{
		/// <summary>
		/// Поднять каражную дверь
		/// </summary>
		public void Up()
		{
			Console.WriteLine("Garage: door is up");
		}

		/// <summary>
		/// Включить свет
		/// </summary>
		public void LightOn()
		{
			Console.WriteLine("Garage: light is on");
		}

		/// <summary>
		/// Выключить свет
		/// </summary>
		public void LightOff()
		{
			Console.WriteLine("Garage: light is off");
		}

		/// <summary>
		/// Опустить дверь
		/// </summary>
		public void Down()
		{
			Console.WriteLine("Garage: door is down");
		}
	}
}