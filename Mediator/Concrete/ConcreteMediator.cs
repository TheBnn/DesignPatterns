using System;

namespace MediatorFood
{
	public class ConcreteMediator : AbstractMediator
	{
		public ConcreteMediator()
		{
		}

		public Farmer Farmer { get; }
		public Cannery Cannery { get; }
		public Shop Shop { get; }

		/// <summary>
		/// Отправить продукт тому или иному потребителю
		/// </summary>
		/// <param name="msg"></param>
		/// <param name="colleague"></param>
		public override void Send(string msg, Colleague colleague)
		{

			if (string.IsNullOrEmpty(msg))
			{
				throw new ArgumentException(nameof(msg));
			}

			if (colleague == Farmer)
			{
				Cannery.MakeKetchup(msg);
			}
			else if (colleague == Cannery)
			{
				Shop.SellKetchup(msg);
			}
		}
	}
}