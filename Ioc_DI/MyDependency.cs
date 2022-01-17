using System;

namespace Ioc_DI
{
    /// <summary>
    /// Несколько реализаций одного и того же примера интерфейса
    /// </summary>
	public class MyDependency : IMyDependency
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public MyDependency()
        {
            Console.WriteLine("Конструктор MyDependency");
        }

        /// <summary>
        /// Сделать какую-то работу
        /// </summary>
        public void DoWork()
        {
            Console.WriteLine("Сделать какую-то работу MyDependency");
        }
    }
}