using System;
using Command.Commands.Abstract;
using Command.Receivers;

namespace Command.Commands
{
	/// <summary>
	/// Команды для гаражной двери
	/// </summary>
	public class GarageDoorOpenCommand : ICommand
	{
		/// <summary>
		/// Экземпляр двери
		/// </summary>
		private readonly GarageDoor _garageDoor;

		public GarageDoorOpenCommand(GarageDoor garageDoor)
		{
			_garageDoor = garageDoor;
		}

		/// <summary>
		/// Выполнить команду
		/// Поднять дверь и включить свет
		/// </summary>
		public void Execute()
		{
			_garageDoor.Up();
			_garageDoor.LightOn();

			Console.WriteLine("Garage door is open");
		}

		/// <summary>
		/// Вернуться к предыдущему состоянию
		/// Выключить свет и закрыть дверь
		/// </summary>
		public void Undo()
		{
			_garageDoor.LightOff();
			_garageDoor.Down();
		}
	}
}