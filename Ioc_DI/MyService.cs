using System;
using System.Collections.Generic;
using System.Linq;

namespace Ioc_DI
{
    /// <summary>
    /// Сервис который что-то делает
    /// </summary>
	public class MyService : IMyService
    {
        /// <summary>
        /// Ссылка депенденси
        /// </summary>
        private readonly IMyDependency _myDependency;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="myDependency"></param>
        public MyService(IMyDependency myDependency)
        {
            Console.WriteLine("Конструктор MyService");
            _myDependency = myDependency;
        }

		///// <summary>
		///// Пример мультизависимости
		///// </summary>
		private readonly IEnumerable<IMyDependency> _myDependencies;
		public MyService(IEnumerable<IMyDependency> myDependencies)
		{
			Console.WriteLine("Конструктор MyService");
			_myDependencies = myDependencies;
		}

		/// <summary>
		/// Сделать что-то
		/// </summary>
		public void DoSomething()
        {
            _myDependency.DoWork();

			// Пример мультизависимости
			foreach (var dependency in _myDependencies)
			{
				dependency.DoWork();
			}
			_myDependencies
				.FirstOrDefault(x => x.GetType() == typeof(MyDependency))?.DoWork();
		}
    }
}