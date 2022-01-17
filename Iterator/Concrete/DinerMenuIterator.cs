using System;
using Iterator.Iterators.Abstract;
using Iterator.Menus;

namespace Iterator.Iterators
{
	public class DinerMenuIterator : IIterator<MenuItem>
	{
		private readonly MenuItem[] _items;
		private int _position;

		public DinerMenuIterator(MenuItem[] items)
		{
			_items = items;
		}

		/// <summary>
		/// Есть ли следующий элемент
		/// </summary>
		/// <returns></returns>
		public bool HasNext()
		{
			return _position < _items.Length && _items[_position] != null;
		}

		/// <summary>
		/// Следующий элемент
		/// </summary>
		/// <returns></returns>
		public MenuItem Next()
		{
			var menuItem = _items[_position];
			_position = _position + 1;
			return menuItem;
		}
	}
}