namespace Visitor
{
	abstract class Visitor
	{
		/// <summary>
		/// Посетить дом мальчиков
		/// </summary>
		/// <param name="boysHouse"></param>
		public abstract void VisitBoysHouse(BoysHouse boysHouse);

		/// <summary>
		/// Посетить дом девочек
		/// </summary>
		/// <param name="boysHouse"></param>
		public abstract void VisitGirlsHouse(GirlsHouse boysHouse);
	}
}
