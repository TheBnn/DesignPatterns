namespace Visitor
{
	abstract class Element
	{
		/// <summary>
		/// Принять посетителя
		/// </summary>
		/// <param name="visitor"></param>
		public abstract void Accept(Visitor visitor);
	}
}