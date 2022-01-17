using System;

namespace State
{
	/// <summary>
	/// Интерфейс состояний машины
	/// </summary>
	public interface ICarState
	{
		/// <summary>
		/// Запуск двигателя
		/// </summary>
		/// <param name="car"></param>
		void Start(Car car);

		/// <summary>
		/// Остановка двигателя
		/// </summary>
		/// <param name="car"></param>
		void Stop(Car car);

		/// <summary>
		/// Установка скорости машины
		/// </summary>
		/// <param name="car"></param>
		/// <param name="speed"></param>
		void Speed(Car car, int speed);
	}
}

