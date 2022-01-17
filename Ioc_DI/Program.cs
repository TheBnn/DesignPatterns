using System;
using Microsoft.Extensions.DependencyInjection;

namespace Ioc_DI
{
    /// <summary>
    /// Хендлер контейнера
    /// </summary>
    class Program
    {
        /// <summary>
        /// Заглушка для тестирования 
        /// </summary>
        static void DoSomething()
        {
            // Зарегистрирует типы в контейнер
            var container = new ServiceCollection();
            container.AddScoped<IMyDependency, MyDependency>();
            container.AddScoped<IMyDependency, MyDependency2>();
            container.AddScoped<IMyService, MyService>();

            // Создает контейнер IoC и находит поставщика
            var provider = container.BuildServiceProvider();

            // Получить сервис и вызвать его работу
            var myService = provider.GetService<IMyService>();

            // Console.WriteLine("-----------");

            myService.DoSomething();
        }
    }
}
