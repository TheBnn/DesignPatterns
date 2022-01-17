namespace Patterns.Observer.Abstraction
{
	public interface ITemperatureSensor
	{
		/// <summary>
		/// Получить температуру
		/// </summary>
		/// <returns></returns>
		double GetTemperature();
	}
}
