using System;

namespace Visitor
{
	internal class GirlsHouse : Element
	{
		/// <summary>
		/// Посетить дом девочек
		/// </summary>
		/// <param name="visitor"></param>
		public override void Accept(Visitor visitor)
		{
			visitor.VisitGirlsHouse(this);
		}

		/// <summary>
		/// Дать платье 
		/// </summary>
		internal void GiveDress()
		{
			Console.WriteLine("Dress");
		}
	}
}