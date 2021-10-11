using System;

/**
 * Когда надо использовать Синглтон
 * Когда необходимо, чтобы для класса существовал только один экземпляр 
 */

namespace SingletonNamespace
{
	/// <summary>
	/// Паттерн - Одиночка
	/// Реализация через дабл чек локинг
	/// </summary>
	public class Singleton
	{
		/// <summary>
		/// Приватная переменная для хранения экземпляра
		/// </summary>
		private static Singleton _instance;

		private static readonly object _locker = new object();

		protected Singleton()
		{
		}

		/// <summary>
		/// Получить инстанс 
		/// </summary>
		/// <param name="dbConnectionString"></param>
		/// <returns></returns>
		public static Singleton GetInstance
		{
			get
			{
				if (_instance == null)
				{
					lock (_locker)
					{
						if (_instance == null)
							_instance = new Singleton();
					}
				}

				return _instance;
			}
		}
	}
}
