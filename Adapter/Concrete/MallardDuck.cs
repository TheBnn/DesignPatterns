using System;

namespace Adapter.Ducks
{
	/// <summary>
	/// Утка обычная
	/// </summary>
	public class MallardDuck : IDuck
	{
		/// <summary>
		/// Кряк
		/// </summary>
		public void Quack()
		{
			Console.WriteLine("Quack");
		}

		/// <summary>
		/// Полетели
		/// </summary>
		public void Fly()
		{
			Console.WriteLine("I'm flying");
		}
	}
}