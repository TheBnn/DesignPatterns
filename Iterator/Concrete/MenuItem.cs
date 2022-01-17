using System;

namespace Iterator.Menus
{
	public class MenuItem
	{
		/// <summary>
		/// Название блюда
		/// </summary>
		public string Name { get; private set; }

		/// <summary>
		/// Описание
		/// </summary>
		public string Description { get; private set; }

		/// <summary>
		/// Веганское ли оно
		/// </summary>
		public bool IsVegetarian { get; private set; }

		/// <summary>
		/// Цена
		/// </summary>
		public decimal Price { get; private set; }

		public MenuItem(string name, string description, bool isVegetarian, decimal price)
		{
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

			Name = name;
			Description = description;
			IsVegetarian = isVegetarian;
			Price = price;
		}


	}
}