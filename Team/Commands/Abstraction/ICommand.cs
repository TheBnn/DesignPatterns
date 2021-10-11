namespace Command.Commands.Abstract
{
	/// <summary>
	/// Интерфейс функций команд
	/// </summary>
	public interface ICommand
	{
		/// <summary>
		/// Выполнить команду
		/// </summary>
		void Execute();
		
		/// <summary>
		/// Отменить команду
		/// </summary>
		void Undo();
	}
}