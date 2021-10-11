using Iterator.Menus;

namespace Iterator.Iterators.Abstract
{
	public interface IIterator<T>
	{
		/// <summary>
		/// Есть следующий элемент
		/// </summary>
		/// <returns></returns>
		bool HasNext();
		
		/// <summary>
		/// Следующий элемент
		/// </summary>
		/// <returns></returns>
		T Next();
	}
}