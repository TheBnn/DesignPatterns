using System;
using System.Collections;
using System.Collections.Generic;
using Iterator.Iterators;
using Iterator.Iterators.Abstract;
using Iterator.Menus.Abstract;

namespace Iterator.Menus
{
	public class DinerMenu : IMenu
	{
		private int _menuItemIndex = 0;
		private readonly MenuItem[] _menuItems;

		public const int MenuMaxItems = 6;

		public DinerMenu()
		{
			_menuItems = new MenuItem[MenuMaxItems];

			AddMenuItem("Vegetarian BLT",
				"(Fakin') Bacon with lettuce & tomato on whole wheat", true, 2.99M);

			AddMenuItem("BLT",
				"Bacon with lettuce & tomato on whole wheat", false, 2.99M);

			AddMenuItem("Soup of the day",
				"Soup of the day, with a side of potato salad", false, 3.29M);

			AddMenuItem("Hotdog",
				"A hot dog, with saurkraut, relish, onions, topped with cheese",
				false, 3.05M);

			AddMenuItem("Steamed Veggies and Brown Rice",
				"Steamed vegetables over brown rice", true, 3.99M);

			AddMenuItem("Pasta",
				"Spaghetti with Marinara Sauce, and a slice of sourdough bread",
				true, 3.89M);
		}

		/// <summary>
		/// Добавить в меню элемент
		/// </summary>
		/// <param name="name"></param>
		/// <param name="description"></param>
		/// <param name="isVegetarian"></param>
		/// <param name="price"></param>
		public void AddMenuItem(string name, string description, bool isVegetarian, decimal price)
		{
			if (_menuItemIndex >= MenuMaxItems)
			{
				throw new Exception("Sorry, menu is full! Can't add item to menu");
			}

			if (String.IsNullOrEmpty(name))
			{
				throw new ArgumentException(nameof(name));
			}

			if (String.IsNullOrEmpty(description))
			{
				throw new ArgumentException(nameof(name));
			}

			if (price <= 0)
			{
				throw new ArgumentOutOfRangeException(nameof(price));
			}

			var menuItem = new MenuItem(name, description, isVegetarian, price);

			_menuItems[_menuItemIndex] = menuItem;
			_menuItemIndex = _menuItemIndex + 1;
		}

		/// <summary>
		/// Создать итератор меню
		/// </summary>
		/// <returns></returns>
		public IIterator<MenuItem> CreateIterator()
		{
			return new DinerMenuIterator(_menuItems);
		}

		/// <summary>
		/// Вернуть набор элементов меню
		/// </summary>
		/// <returns></returns>
		public IEnumerator<MenuItem> GetEnumerator()
		{
			return ((IEnumerable<MenuItem>)_menuItems).GetEnumerator();
		}
	}
}