using System;

namespace State
{
	/// <summary>
	/// Класс машины
	/// </summary>
	public class Car
	{
		/// <summary>
		/// Состояние машины
		/// </summary>
		private ICarState _state;

		/// <summary>
		/// Скорость
		/// </summary>
		internal int _speed;

		/// <summary>
		/// Работа мотора
		/// </summary>
		internal bool _motorWorks;

		/// <summary>
		/// Конструктор
		/// </summary>
		public Car()
		{
			_speed = 0;
			_motorWorks = false;
			ChangeState(MotorStoppedState.Instance);
		}
		/// <summary>
		/// Геттер скорости
		/// </summary>
		public int Speed
		{
			//Отображение текущей скорости (только чтение)
			get { return _speed; }
		}
		/// <summary>
		/// Запустить двигатель
		/// </summary>
		public void StartMotor()
		{
			_state.Start(this);
		}
		
		/// <summary>
		/// Остановить двигатель
		/// </summary>
		public void StopMotor()
		{
			//Остановка двигателя
			_state.Stop(this);
		}
		
		/// <summary>
		/// Задать скорость
		/// </summary>
		/// <param name="speed"></param>
		public void SetSpeed(int speed)
		{
			_state.Speed(this, speed);
		}

		/// <summary>
		/// Изменить состояние машины
		/// </summary>
		/// <param name="s"></param>
		internal void ChangeState(ICarState s)
		{
			_state = s;
		}
	}
}

