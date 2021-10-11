using System;

namespace MediatorFood
{
	public class Shop : Colleague
	{
		public Shop(AbstractMediator mediator) : base(mediator)
		{
		}

		/// <summary>
		/// Продать кетчуп
		/// </summary>
		/// <param name="message"></param>
		public void SellKetchup(string message)
		{
			if (string.IsNullOrEmpty(message))
			{
				throw new ArgumentException(nameof(message));
			}

			Console.WriteLine(GetType().Name + " sold " + message);
		}
	}
}