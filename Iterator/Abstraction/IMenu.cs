using System.Collections.Generic;
using Iterator.Iterators.Abstract;

namespace Iterator.Menus.Abstract
{
	public interface IMenu
	{
		/// <summary>
		/// Создать итератор меню
		/// </summary>
		/// <returns></returns>
		IIterator<MenuItem> CreateIterator();
		
		/// <summary>
		/// Получить набор меню
		/// </summary>
		/// <returns></returns>
		IEnumerator<MenuItem> GetEnumerator();
	}
}