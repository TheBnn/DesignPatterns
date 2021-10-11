using System;

namespace MediatorFood
{
	public class Farmer : Colleague
	{
		public Farmer(AbstractMediator mediator) : base(mediator)
		{
		}

		/// <summary>
		/// Отправить томаты на переработку
		/// </summary>
		public void GrowTomato()
		{
			string tomato = "Tomato";
			Console.WriteLine(this.GetType().Name + " raised " + tomato);
			Mediator.Send(tomato, this);
		}
	}
}