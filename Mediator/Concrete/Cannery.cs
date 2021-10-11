using System;

namespace MediatorFood
{
	public class Cannery : Colleague
	{
		AbstractMediator mediator;
		public Cannery(AbstractMediator mediator) : base(mediator)
		{
		}

		/// <summary>
		/// Сделать магический кетчуп 
		/// </summary>
		/// <param name="message"></param>
		public void MakeKetchup(string message)
		{
			if (string.IsNullOrEmpty(message))
			{
				throw new ArgumentException(nameof(message));
			}

			string ketchup = message + "Ketchup";
			Console.WriteLine(this.GetType().Name + " produced " + ketchup);
			mediator.Send(ketchup, this);
		}
	}
}