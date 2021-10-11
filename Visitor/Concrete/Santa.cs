namespace Visitor
{
	internal class Santa : Visitor
	{
		/// <summary>
		/// Посетить парней
		/// </summary>
		/// <param name="boysHouse"></param>
		public override void VisitBoysHouse(BoysHouse boysHouse)
		{
			boysHouse.TellFairTale();
		}

		/// <summary>
		/// Посетить девушек
		/// </summary>
		/// <param name="girlsHouse"></param>
		public override void VisitGirlsHouse(GirlsHouse girlsHouse)
		{
			girlsHouse.GiveDress();
		}
	}
}