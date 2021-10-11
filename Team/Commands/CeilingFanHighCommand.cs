using Command.Commands.Abstract;
using Command.Receivers;

namespace Command.Commands
{
	/// <summary>
	/// Команда на повышений скорости вентилятора на максимум
	/// </summary>
	public class CeilingFanHighCommand : ICommand
	{
		/// <summary>
		/// Вентилятор
		/// </summary>
		private readonly CeilingFan _ceilingFan;

		/// <summary>
		/// Предыдущая скорость
		/// </summary>
		private int _prevSpeed;

		public CeilingFanHighCommand(CeilingFan ceilingFan)
		{
			_ceilingFan = ceilingFan;
		}

		/// <summary>
		/// Вызвать выполнение команды
		/// </summary>
		public void Execute()
		{
			_prevSpeed = _ceilingFan.GetSpeed();
			_ceilingFan.High();
		}

		/// <summary>
		/// Вернуться к предыдущей 
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