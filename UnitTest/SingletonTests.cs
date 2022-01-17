using NUnit.Framework;
using SingletonNamespace;

namespace Patterns.Tests
{
	/// <summary>
	/// Тестирование синглтона
	/// </summary>
	[TestFixture]
	public class SingletonTests
	{
		/// <summary>
		/// Должен быть только один инстанс
		/// </summary>
		[Test]
		public void ShouldBeOnlyOneInstance()
		{
			var instance1 = Singleton.GetInstance;
			var instance2 = Singleton.GetInstance;

			Assert.True(object.ReferenceEquals(instance1, instance2));
		}
	}
}