namespace Patterns.Observer.Abstraction
{
	public interface IObservervable
	{
		/// <summary>
		/// Подписать на слежку
		/// </summary>
		/// <param name="observer"></param>
		void Add(IObserver observer);

		/// <summary>
		/// Отписать от наблюдения
		/// </summary>
		/// <param name="observer"></param>
		void Remove(IObserver observer);

		/// <summary>
		/// Уведомить подписчика
		/// </summary>
		void Notify();
	}
}
