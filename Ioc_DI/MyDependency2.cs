using System;

namespace Ioc_DI
{
    /// <summary>
    /// Несколько реализаций одного и того же примера интерфейса
    /// </summary>
    public class MyDependency2 : IMyDependency
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public MyDependency2()
        {
            Console.WriteLine("Конструктор MyDependency2");
        }

        /// <summary>
        /// Сделать какую-то работу
        /// </summary>
        public void DoWork()
        {
            Console.WriteLine("Сделать какую-то работу MyDependency2");
        }
    }
}