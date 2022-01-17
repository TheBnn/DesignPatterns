using NSubstitute;
using NUnit.Framework;
using Patterns.Decorator.Abstraction;
using Patterns.Decorator.Concrete;

namespace Patterns.Tests
{
	/// <summary>
	/// Тестирование декоратора
	/// </summary>
	[TestFixture]
	public class DecoratorTests
	{
		/// <summary>
		/// Должен вернуть стоимость пиццы
		/// </summary>
		[Test]
		public void ShouldIncreaseCostWithAddons()
		{
			var basePizza = new NewYorkPizza();
			var pizzaWithOlives = new OlivesPizzaAddon(basePizza);
			var pizzaWithOlivesAndHam = new HamPizzaAddon(pizzaWithOlives);
			var pizzaWithOlivesHamAndSalami = new SalamiPizzaAddon(pizzaWithOlivesAndHam);

			Assert.AreEqual(14, pizzaWithOlivesHamAndSalami.GetCost());
		}

		/// <summary>
		/// Должен вернуть стоимость пиццы
		/// </summary>
		[Test]
		public void ShouldIncreaseCostWithAddonsAndDiscount()
		{
			var basePizza = new NewYorkPizza();
			var pizzaWithOlives = new OlivesPizzaAddon(basePizza);
			var pizzaWithOlivesAndHam = new HamPizzaAddon(pizzaWithOlives);
			var pizzaWithOlivesHamAndSalami = new SalamiPizzaAddon(pizzaWithOlivesAndHam);
			var pizzaWithAddonsAndDiscount = new DiscountPizzaAddon(pizzaWithOlivesHamAndSalami);

			Assert.AreEqual(13.65, pizzaWithAddonsAndDiscount.GetCost());
		}

		/// <summary>
		/// Должен вернуть валидную стоимость пиццы
		/// </summary>
		[Test]
		public void GetPizzaCost()
		{
			var pizza = Substitute.For<IPizza>();
			pizza.GetCost().Returns(10m);
			Assert.That(pizza.GetCost(), Is.EqualTo(10m));
		}
	}
}
