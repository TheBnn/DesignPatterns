using System;

namespace State
{
	/// <summary>
	/// Состояние рабочего мотора
	/// </summary>
	public class MotorWorksState : ICarState
	{
		/// <summary>
		/// Инстанс
		/// </summary>
		private static readonly MotorWorksState instance = new MotorWorksState();
		/// <summary>
		/// Инстанс
		/// </summary>
		public static ICarState Instance
		{
			get { return instance; }
		}

		/// <summary>
		/// Запрещаем запуск двигателя до того как он будет остановлен
		/// </summary>
		/// <param name="c"></param>
		public void Start(Car c)
		{
			throw new Exception("Двигатель уже запущен!");
		}

		/// <summary>
		/// Остановка двигателя
		/// </summary>
		/// <param name="c"></param>
		public void Stop(Car c)
		{
			// Запрещаем остановку двигателя, если скорость не равно 0 (автомобиль ещё движется)
			if (c._speed == 0)
			{
				c._motorWorks = true;
				c.ChangeState(MotorStoppedState.Instance);
			}
			else
			{
				throw new Exception("Прежде чем остановить двигатель уменьшите скорость до 0!");
			}
		}

		/// <summary>
		/// Устанавливаем скорость
		/// </summary>
		/// <param name="c"></param>
		/// <param name="speed"></param>
		public void Speed(Car c, int speed)
		{
			if (speed >= 0)
			{
				c._speed = speed;
			}
			else
			{
				// Запрет ввода некорректных значений скорости
				throw new Exception("Значение скорости не может быть отрицательным!");
			}
		}
	}
}

