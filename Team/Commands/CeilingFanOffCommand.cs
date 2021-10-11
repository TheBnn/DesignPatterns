using Command.Commands.Abstract;
using Command.Receivers;

namespace Command.Commands
{
	/// <summary>
	/// Команда на выключение вентилятора
	/// </summary>
	public class CeilingFanOffCommand : ICommand
	{
		/// <summary>
		/// Вентилятор
		/// </summary>
		private readonly CeilingFan _ceilingFan;
		
		/// <summary>
		/// Предыдущая скорость
		/// </summary>
		private int _prevSpeed;

		public CeilingFanOffCommand(CeilingFan ceilingFan)
		{
			_ceilingFan = ceilingFan;
		}

		/// <summary>
		/// Выполнить команду
		/// </summary>
		public void Execute()
		{
			_prevSpeed = _ceilingFan.GetSpeed();
			_ceilingFan.Off();
		}

		/// <summary>
		/// Вернуться к предыдущей команде
		/// </summary>
		public void Undo()
		{
			switch (_prevSpeed)
			{
				case CeilingFan.HIGH:
					_ceilingFan.High();
					break;
				case CeilingFan.MEDIUM:
					_ceilingFan.Medium();
					break;
				case CeilingFan.LOW:
					_ceilingFan.Low();
					break;
				case CeilingFan.OFF:
					_ceilingFan.Off();
					break;
			}
		}
	}
}