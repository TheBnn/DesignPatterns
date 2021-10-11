using Command.Commands.Abstract;
using Command.Receivers;

namespace Command.Commands
{
	/// <summary>
	/// Включить магнитолу с диском 
	/// </summary>
	public class StereoOnWithCDCommand : ICommand
	{
		/// <summary>
		/// Экземпляр
		/// </summary>
		private readonly Stereo _stereo;

		public StereoOnWithCDCommand(Stereo stereo)
		{
			_stereo = stereo;
		}

		/// <summary>
		/// Выполнить, включить магнитолу поставить звук на 1 и поставить диск
		/// </summary>
		public void Execute()
		{
			_stereo.On();
			_stereo.SetCD();
			_stereo.SetVolume(11);
		}

		/// <summary>
		/// Отмениьт
		/// </summary>
		public void Undo()
		{
			_stereo.Off();
		}
	}
}