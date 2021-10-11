using Command.Commands.Abstract;
using Command.Receivers;

namespace Command.Commands
{
	/// <summary>
	/// Команда включения света
	/// </summary>
	public class LightsOnCommand : ICommand
	{
		/// <summary>
		/// Экземпляр светильника
		/// </summary>
		private readonly Light _light;

		public LightsOnCommand(Light light)
		{
			_light = light;
		}

		/// <summary>
		/// Включить свет
		/// </summary>
		public void Execute()
		{
			_light.On();
		}

		/// <summary>
		/// Выключить свет
		/// </summary>
		public void Undo()
		{
			_light.Off();
		}
	}
}