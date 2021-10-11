using NUnit.Framework;
using SingletonNamespace;

namespace Patterns.Tests
{
	[TestFixture]
	public class SingletonTests
	{
		[Test]
		public void ShouldBeOnlyOneInstance()
		{
			var instance1 = Singleton.GetInstance;
			var instance2 = Singleton.GetInstance;

			Assert.True(object.ReferenceEquals(instance1, instance2));
		}
	}
}
