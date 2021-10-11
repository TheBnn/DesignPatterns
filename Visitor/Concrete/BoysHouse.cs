using System;

namespace Visitor
{
	internal class BoysHouse : Element
	{
		/// <summary>
		/// Принять гостя
		/// </summary>
		/// <param name="visitor"></param>
		public override void Accept(Visitor visitor)
		{
			visitor.VisitBoysHouse(this);
		}

		/// <summary>
		/// Рассказать сказку
		/// </summary>
		internal void TellFairTale()
		{
			Console.WriteLine("Fair");
		}
	}
}