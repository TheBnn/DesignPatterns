using Adapter.Ducks;
using Adapter.Turkeys;

namespace Adapters
{
	/// <summary>
	/// Адаптер индюшки в утку
	/// </summary>
	public class DuckAdapter : ITurkey
	{
		/// <summary>
		/// Функциональность утки
		/// </summary>
		private readonly IDuck _duck;

		public DuckAdapter(IDuck duck)
		{
			_duck = duck;
		}

		/// <summary>
		/// Кряк утки вместо голдяща индюшки
		/// </summary>
		public void Gobble()
		{
			_duck.Quack();
		}

		/// <summary>
		/// Полетели как утка
		/// </summary>
		public void Fly()
		{
			_duck.Fly();
		}
	}
}