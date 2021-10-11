using Adapter.Ducks;
using Adapter.Turkeys;

namespace Adapter
{
	/// <summary>
	/// Адаптер утки в индюшку
	/// </summary>
	public class TurkeyAdapter : IDuck
	{
		/// <summary>
		/// Храним функциональность утки
		/// </summary>
		private readonly ITurkey _turkey;

		public TurkeyAdapter(ITurkey turkey)
		{
			_turkey = turkey;
		}

		/// <summary>
		/// Кряк
		/// </summary>
		public void Quack()
		{
			_turkey.Gobble();
		}

		/// <summary>
		/// Полет
		/// </summary>
		public void Fly()
		{
			_turkey.Fly();
		}
	}
}