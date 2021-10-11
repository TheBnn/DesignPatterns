using System;
using Command.Commands.Abstract;

namespace Command.Commands
{
	/// <summary>
	/// Последовательное выполнение набора команд
	/// </summary>
	public class MacroCommand : ICommand
	{
		/// <summary>
		/// Набор команд
		/// </summary>
		private readonly ICommand[] _commands;

		public MacroCommand(ICommand[] commands)
		{
			_commands = commands;
		}

		/// <summary>
		/// Выполнить все команды
		/// </summary>
		public void Execute()
		{
			if (_commands.Length > 0)
			{
				foreach (var command in _commands)
				{
					command.Execute();
				}
			}
		}

		/// <summary>
		/// Отменить все команды
		/// </summary>
		public void Undo()
		{
			if (_commands.Length > 0)
			{
				for (int i = _commands.Length; i > 0; i--)
				{
					_commands[i].Undo();
				}
			}
		}
	}
}