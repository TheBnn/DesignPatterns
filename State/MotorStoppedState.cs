using System;

namespace State
{
	/// <summary>
	/// Состояние машины - мотор заглушен
	/// </summary>
	public class MotorStoppedState : ICarState
	{
		/// <summary>
		/// Инстанс 
		/// </summary>
		private static readonly MotorStoppedState instance = new MotorStoppedState();
		
		/// <summary>
		/// Инстанс
		/// </summary>
		public static ICarState Instance
		{
			get { return instance; }
		}
		
		/// <summary>
		/// Запуск двигателя
		/// </summary>
		/// <param name="c"></param>
		public void Start(Car c)
		{
			c._motorWorks = true;
			c.ChangeState(MotorWorksState.Instance);
		}
		/// <summary>
		/// Запрет остановки двигателя до того, как он будет снова запущен
		/// </summary>
		/// <param name="c"></param>
		public void Stop(Car c)
		{
			throw new Exception("Двигатель уже остановлен!");
		}

		/// <summary>
		/// Запрет изменения скорости при остановленном двигателе
		/// </summary>
		/// <param name="c"></param>
		/// <param name="speed"></param>
		public void Speed(Car c, int speed)
		{
			throw new Exception("Нельзя изменить скорость, когда двигатель остановлен!");
		}
	}
}

