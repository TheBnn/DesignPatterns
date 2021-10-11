using System;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Command.Commands;
using Command.Commands.Abstract;

namespace Command.Invokers
{
	/// <summary>
	/// Пульт управления
	/// </summary>
	public class RemoteControl
	{
		/// <summary>
		/// Максимальное колличество команд
		/// </summary>
		public const int MaxCommandsCount = 7;

		/// <summary>
		/// Команды на включение
		/// </summary>
		private ICommand[] _onCommands;

		/// <summary>
		/// Команды на выключение
		/// </summary>
		private ICommand[] _offCommands;

		/// <summary>
		/// Команда на отмену
		/// </summary>
		private ICommand _undoCommand;

		public RemoteControl()
		{
			_onCommands = new ICommand[MaxCommandsCount];
			_offCommands = new ICommand[MaxCommandsCount];

			var noCommand = new NoCommand();
			for (int i = 0; i < MaxCommandsCount; i++)
			{
				_onCommands[i] = noCommand;
				_offCommands[i] = noCommand;
			}

			_undoCommand = noCommand;
		}

		/// <summary>
		/// Поставить команду в очередь на свой слот
		/// </summary>
		/// <param name="slot"></param>
		/// <param name="onCommand"></param>
		/// <param name="offCommand"></param>
		public void SetCommand([Range(0, MaxCommandsCount)]int slot, ICommand onCommand, ICommand offCommand)
		{
			// Косаемо конструкции RangeAttribute
			// .Net ее компилирует, но вот из коробки она не работает вот имеено так. 
			// Мне стало интересно как бы запустить ее вот в таком виде, но так и не нашел ничего полезного.
			// Будет замечательно если будет фидбек по этому вопросу. 

			if(slot > MaxCommandsCount || slot < 0) 
			{
				throw new ArgumentOutOfRangeException($"slot от 0 до {MaxCommandsCount}");
			}

			_onCommands[slot] = onCommand ?? throw new ArgumentException(nameof(onCommand));
			_offCommands[slot] = offCommand ?? throw new ArgumentException(nameof(offCommand));
		}

		/// <summary>
		/// Вызвать включающаю команду под своим слотом
		/// </summary>
		/// <param name="slot"></param>
		public void PressOnButton(int slot)
		{
			if (slot > _onCommands.Length || slot < 0)
			{
				throw new ArgumentOutOfRangeException($"slot от 0 до {_onCommands.Length}");
			}

			var command = _onCommands[slot];
			command.Execute();
			_undoCommand = command;
		}
		/// <summary>
		/// Вызвать выключающую команду под своим слотом
		/// </summary>
		/// <param name="slot"></param>
		public void PressOffButton(int slot)
		{
			if (slot > _offCommands.Length || slot < 0)
			{
				throw new ArgumentOutOfRangeException($"slot от 0 до {_offCommands.Length}");
			}

			var command = _offCommands[slot];
			command.Execute();
			_undoCommand = command;
		}

		/// <summary>
		/// Отменить последнюю команду
		/// </summary>
		public void PressUndoButton()
		{
			_undoCommand.Undo();
		}

		/// <summary>
		/// Вывести весь список команд в списке 
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			var messageBuilder = new StringBuilder();
			messageBuilder.Append("\n----- Remote control -----\n");

			for (int i = 0; i < MaxCommandsCount; i++)
			{
				messageBuilder.AppendLine($"[slot {i}]");
				messageBuilder.AppendLine($"on: {_onCommands[i].GetType().Name}");
				messageBuilder.AppendLine($"off: { _offCommands[i].GetType().Name}");

				messageBuilder.AppendLine();
			}

			return messageBuilder.ToString();
		}
	}
}