using Command.Commands.Abstract;
using Command.Receivers;

namespace Command.Commands
{
	/// <summary>
	/// Выключить магнитолу с вынуть диск
	/// </summary>
	public class StereoOffWithCDCommand : ICommand
	{
		/// <summary>
		/// Экземпляр макнитолы
		/// </summary>
		private readonly Stereo _stereo;

		public StereoOffWithCDCommand(Stereo stereo)
		{
			_stereo = stereo;
		}

		/// <summary>
		/// Выключить
		/// </summary>
		public void Execute()
		{
			_stereo.Off();
		}

		/// <summary>
		/// Отменить
		/// </summary>
		public void Undo()
		{
			_stereo.On();
			_stereo.SetCD();
			_stereo.SetVolume(11);
		}
	}
}