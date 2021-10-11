namespace MediatorFood
{
	public abstract class AbstractMediator
	{
		/// <summary>
		/// Отправить продукт
		/// </summary>
		/// <param name="msg"></param>
		/// <param name="colleague"></param>
		public abstract void Send(string msg, Colleague colleague);
	}
}