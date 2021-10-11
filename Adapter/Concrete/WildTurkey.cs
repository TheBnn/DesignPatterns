using System;

namespace Adapter.Turkeys
{
	public class WildTurkey : ITurkey
	{
		/// <summary>
		/// Кряк
		/// </summary>
		public void Gobble()
		{
			Console.WriteLine("Gobble gobble");
		}

		/// <summary>
		/// Полет
		/// </summary>
		public void Fly()
		{
			Console.WriteLine("I'm flying a short distance");
		}
	}
}