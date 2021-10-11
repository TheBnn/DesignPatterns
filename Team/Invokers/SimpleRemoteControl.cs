using Command.Commands.Abstract;

namespace Command.Invokers
{
	/// <summary>
	/// Простой пульт управления
	/// </summary>
	public class SimpleRemoteControl
	{
		/// <summary>
		/// Команда
		/// </summary>
		private ICommand _command;

		public SimpleRemoteControl()
		{

		}

		/// <summary>
		/// Задать команду
		/// </summary>
		/// <param name="command"></param>
		public void SetCommand(ICommand command)
		{
			_command = command;
		}

		/// <summary>
		/// Выполнить команду
		/// </summary>
		public void PressTheButton()
		{
			_command.Execute();
		}
	}
}