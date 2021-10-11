namespace MediatorFood
{
	public abstract class Colleague
	{
		protected AbstractMediator Mediator;

		public Colleague(AbstractMediator mediator)
		{
			this.Mediator = mediator;
		}
	}
}