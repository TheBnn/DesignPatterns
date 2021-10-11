using Command.Commands.Abstract;

namespace Command.Commands
{
	/// <summary>
	/// Нет команд
	/// </summary>
	public class NoCommand : ICommand
	{
		/// <summary>
		/// Выполнить
		/// </summary>
		public void Execute()
		{

		}

		/// <summary>
		/// Вернуть
		/// </summary>
		public void Undo()
		{

		}
	}
}