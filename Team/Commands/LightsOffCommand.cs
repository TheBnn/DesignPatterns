using Command.Commands.Abstract;
using Command.Receivers;

namespace Command.Commands
{
	/// <summary>
	/// Команда выключения света
	/// </summary>
	public class LightsOffCommand : ICommand
	{
		/// <summary>
		/// Экземпляр светильника
		/// </summary>
		private readonly Light _light;

		public LightsOffCommand(Light light)
		{
			_light = light;
		}

		/// <summary>
		/// Выключаем свет
		/// </summary>
		public void Execute()
		{
			_light.Off();
		}

		/// <summary>
		/// Включаем свет
		/// </summary>
		public void Undo()
		{
			_light.On();
		}
	}
}